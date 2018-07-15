using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using System.Data;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class SearchListWareHouseDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WareHouseVo inVo = (WareHouseVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WareHouseVo> voList = new ValueObjectList<WareHouseVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
           
            sql.Append(@"select d.warehouse_id, d.asset_cd, b.rank_name,b.rank_cd,d.time_start, a.asset_name, a.asset_model, a.asset_type, a.asset_invoice, d.comments_remake, a.asset_supplier, d.qty, d.unit, c.user_location_name, d.registration_date_time, d.location_before_cd, d.location_after_cd from t_warehouse d
                           left join m_asset a on a.asset_cd = d.asset_cd
                           left join m_rank b on b.rank_id = d.rank_id
                            left join m_user_location c on c.user_location_cd = d.user_location_cd
                      where 1=1   ");
           
            if (!String.IsNullOrEmpty(inVo.AssetCode))
            {
                sql.Append(@" and   d.asset_cd  =:asset_cd");
                sqlParameter.AddParameterString("asset_cd", inVo.AssetCode);
            }
            if (!String.IsNullOrEmpty(inVo.RankCode))
            {
                sql.Append(" and b.rank_cd  =:rank_cd");
                sqlParameter.AddParameterString("rank_cd", inVo.RankCode);
            }

            if (!String.IsNullOrEmpty(inVo.AssetModel))

            {
                sql.Append(" and a.asset_model =:asset_model");
                sqlParameter.AddParameterString("asset_model", inVo.AssetModel);
            }
            if (!String.IsNullOrEmpty(inVo.AssetName))
            {
                sql.Append(" and a.asset_name =:asset_name");
                sqlParameter.AddParameterString("asset_name", inVo.AssetName);
            }
            if (!String.IsNullOrEmpty(inVo.AssetType))
            {
                sql.Append(" and a.asset_type =:asset_type");
                sqlParameter.AddParameterString("asset_type", inVo.AssetType);
            }
            if (!String.IsNullOrEmpty(inVo.Invoice))
            {
                sql.Append(" and a.asset_invoice =:asset_invoice");
                sqlParameter.AddParameterString("asset_invoice", inVo.Invoice);
            }
            if (!String.IsNullOrEmpty(inVo.AfterLocation))
            {
                sql.Append(" and d.location_after_cd =:location_after_cd");
                sqlParameter.AddParameterString("location_after_cd", inVo.AfterLocation);
            }
            sql.Append(" and d.warehouse_id in(select Max(warehouse_id) from t_warehouse  group by asset_cd)  ");
            sql.Append(" order by  d.registration_date_time desc");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WareHouseVo outVo = new  WareHouseVo
                {
                    //  , h., i., k., o.prodution_work_content_name
                    WareHouseId = int.Parse(dataReader["warehouse_id"].ToString()),
                    TimeStart = DateTime.Parse(dataReader["time_start"].ToString()),
                    AssetCode = dataReader["asset_cd"].ToString(),
                    RankName = dataReader["rank_name"].ToString(),
                    AssetName = dataReader["asset_name"].ToString(),
                    Qty = int.Parse(dataReader["qty"].ToString()),
                    Unit = dataReader["unit"].ToString(),
                    AssetModel = dataReader["asset_model"].ToString(),
                    AssetSupplier = dataReader["asset_supplier"].ToString(),
                    AssetType = dataReader["asset_type"].ToString(),
                    UserLocationName = dataReader["user_location_name"].ToString(),
                    Comments = dataReader["comments_remake"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    BeforeLocation = dataReader["location_before_cd"].ToString(),
                    AfterLocation = dataReader["location_after_cd"].ToString(),
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }

    }
}
