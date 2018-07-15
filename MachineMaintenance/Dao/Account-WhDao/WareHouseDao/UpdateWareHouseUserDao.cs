using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateWareHouseUserDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WareHouseVo inVo = (WareHouseVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_warehouse set rank_id=:rank_id,
                                           qty=:qty,                                      
                                           location_before_cd=:location_before_cd,
                                           location_after_cd=:location_after_cd,
                                           user_location_cd=:user_location_cd,
                                           comments_remake=:comments_remake, 
                                            registration_date_time= :registration_date_time
                                            ");
            sql.Append(" where warehouse_id =:warehouse_id");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("warehouse_id", inVo.WareHouseId);
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