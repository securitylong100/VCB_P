using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class AddWareHouseDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WareHouseVo inVo = (WareHouseVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_warehouse(asset_cd, rank_id, qty, unit, user_location_cd, time_start, 
                        location_before_cd, location_after_cd, comments_remake,   registration_user_cd, 
                        registration_date_time, factory_cd)");
            sql.Append(@"values(:asset_cd, :rank_id, :qty, :unit, :user_location_cd, :time_start, 
                       :location_before_cd, :location_after_cd, :comments_remake, :registration_user_cd, 
                       now(), :factory_cd)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            
            sqlParameter.AddParameter("asset_cd", inVo.AssetCode);
            sqlParameter.AddParameter("rank_id", inVo.RankId);
            sqlParameter.AddParameter("qty", inVo.Qty);
            sqlParameter.AddParameter("unit", inVo.Unit);
            sqlParameter.AddParameter("user_location_cd", inVo.UserLocationCode);
            sqlParameter.AddParameterDateTime("time_start", inVo.TimeStart);
            sqlParameter.AddParameter("location_before_cd", inVo.BeforeLocation);
            sqlParameter.AddParameter("location_after_cd", inVo.AfterLocation);
            sqlParameter.AddParameter("comments_remake", inVo.Comments);
            sqlParameter.AddParameter("registration_user_cd", inVo.RegistrationUserCode);
            sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);
            sqlParameter.AddParameter("factory_cd", inVo.FactoryCode);
            //execute SQL

            WareHouseVo outVo = new WareHouseVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
