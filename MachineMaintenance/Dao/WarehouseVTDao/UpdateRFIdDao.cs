using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateRFIdDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_vt_machine set rfid_cd =:rfid_cd,
            machine_cd =:machine_cd,
            machine_name =:machine_name,
            machine_qty =:machine_qty, 
            machine_serial =:machine_serial,
            machine_model =:machine_model,
            machine_location =:machine_location,
            machine_suppiler =:machine_suppiler,
            machine_invoice =:machine_invoice,
            machine_costvalue =:machine_costvalue,
            registration_user_cd =:registration_user_cd,
            time_check_fi =:time_check_fi,
            factory_cd =:factory_cd,
            registration_date_time = now()
            where machine_id =:machine_id");

            //      
            //     ,
            //                                             

            //

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_id", inVo.MachineId);
            sqlParameter.AddParameter("rfid_cd", inVo.RFId);
            sqlParameter.AddParameter("machine_cd", inVo.MachineCode);
            sqlParameter.AddParameter("machine_name", inVo.MachineName);
            sqlParameter.AddParameter("machine_qty", inVo.MachineQty);
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("machine_model", inVo.MachineModel);
            sqlParameter.AddParameter("machine_location", inVo.MachineLocation);
            sqlParameter.AddParameter("machine_suppiler", inVo.MachineSupplier);
            sqlParameter.AddParameter("machine_invoice", inVo.MachineInvoice);
            sqlParameter.AddParameter("time_check_fi", inVo.TimeCheck);
            sqlParameter.AddParameter("machine_costvalue", double.Parse(inVo.MachineCostValue));      
            sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserName);
            sqlParameter.AddParameter("factory_cd", UserData.GetUserData().FactoryCode);
            //execute SQL

            WarehouseVTVo outVo = new WarehouseVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }

    }
}