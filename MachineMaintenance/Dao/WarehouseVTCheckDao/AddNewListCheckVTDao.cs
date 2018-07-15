using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class AddNewListCheckVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTListVo inVo = (WarehouseVTListVo)vo;
            
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_vt_list_check(machine_serial,
            check_time,
          registration_user_cd,
          registration_date_time,
          value_last) ");
                    sql.Append(@"values(:machine_serial,
            :check_time ,
          :registration_user_cd ,
          now(),
          :value_last)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("check_time", inVo.CheckTime);
            sqlParameter.AddParameter("registration_user_cd", inVo.RegistrationUserCode);
            sqlParameter.AddParameter("value_last", inVo.ValueCheck);
            sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);

            WarehouseVTListVo outVo = new WarehouseVTListVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
            
        }
    }
}
