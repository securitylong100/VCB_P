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
    class AddNewMachineVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_vt_machine(rfid_cd ,machine_cd,
            machine_name ,
          machine_qty ,
          machine_serial,
          machine_model,
          machine_location,
          machine_suppiler,
          machine_invoice,
          machine_costvalue,
            machine_status,
          registration_user_cd,
          registration_date_time,
            factory_cd,
            time_check_fi) ");
                    sql.Append(@"values(:rfid_cd ,
            :machine_cd,
          :machine_name ,
          :machine_qty ,
          :machine_serial,
          :machine_model,
          :machine_location,
          :machine_suppiler,
          :machine_invoice,
          :machine_costvalue,
            :machine_status,
          :registration_user_cd,
          now(),
            :factory_cd,
          :time_check_fi)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("rfid_cd", inVo.RFId);
            sqlParameter.AddParameter("machine_cd", inVo.MachineCode);
            sqlParameter.AddParameter("machine_name", inVo.MachineName);
            sqlParameter.AddParameter("machine_qty", inVo.MachineQty);
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("machine_model", inVo.MachineModel);
            sqlParameter.AddParameter("machine_location", inVo.MachineLocation);
            sqlParameter.AddParameter("machine_suppiler", inVo.MachineSupplier);
            sqlParameter.AddParameter("machine_invoice", inVo.MachineInvoice);
            sqlParameter.AddParameter("machine_costvalue", double.Parse(inVo.MachineCostValue));
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserCode);
            sqlParameter.AddParameter("factory_cd", UserData.GetUserData().FactoryCode);
            sqlParameter.AddParameterInteger("time_check_fi", inVo.TimeCheck);
            sqlParameter.AddParameter("machine_status", inVo.MachineStatus);

            //execute SQL

            WarehouseVTVo outVo = new WarehouseVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
