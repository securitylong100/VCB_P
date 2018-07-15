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
    class UpdateinfoMainternanceMachineVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MaintenanceMachineVTVo inVo = (MaintenanceMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_vt_maintenance set 
            start_day =:start_day,
            month_repeat =:month_repeat,
            check_status =:check_status,
            registration_user_cd =:registration_user_cd,
            registration_date_time = now(),
           factory_cd =:factory_cd");
            sql.Append(" where machine_serial =:machine_serial ");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("machine_model", inVo.MachineModel);
            sqlParameter.AddParameter("start_day", inVo.StartDay);
            sqlParameter.AddParameter("month_repeat", inVo.MonthRepeat);
            sqlParameter.AddParameter("check_status", inVo.CheckStatus);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserCode);
            sqlParameter.AddParameter("factory_cd", UserData.GetUserData().FactoryCode);



            //execute SQL

            MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
