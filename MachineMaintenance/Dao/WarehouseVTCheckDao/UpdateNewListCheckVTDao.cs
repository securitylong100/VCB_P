using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateNewListCheckVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTListVo inVo = (WarehouseVTListVo)vo;
            StringBuilder sql = new StringBuilder();
  
            sql.Append(@"update t_vt_list_check set machine_cd =:machine_cd
            check_time =:check_time,
            registration_user_cd =:registration_user_cd, 
            value_last =:value_last,
            where check_id =:check_id");
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_cd", inVo.MachineCode);
            sqlParameter.AddParameter("check_time", inVo.CheckTime);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserName);
            sqlParameter.AddParameter("value_last", inVo.ValueCheck);
            //execute SQL

            WarehouseVTListVo outVo = new WarehouseVTListVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }

    }
}