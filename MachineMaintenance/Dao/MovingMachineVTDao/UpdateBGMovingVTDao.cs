using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateBGMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_vt_machine set machine_suppiler =:machine_suppiler,
machine_status =:machine_status, 
registration_user_cd =:registration_user_cd,
registration_date_time =:registration_date_time
            where machine_serial =:machine_serial");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_status", inVo.MachineStatus);
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("machine_suppiler", inVo.MachineSupplier);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserCode);
            sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);
            //execute SQL

            WarehouseVTVo outVo = new WarehouseVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }

    }
}