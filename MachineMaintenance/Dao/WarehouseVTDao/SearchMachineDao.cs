using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    public class SearchMachineDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WarehouseVTVo> voList = new ValueObjectList<WarehouseVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            //sql.Append(@"select a.machine_id, a.rfid_cd, a.machine_cd,  a.machine_name, a.machine_qty,  a.machine_serial, a.machine_type,  a.machine_symbol, a.machine_suppiler, a.machine_invoice, a.machine_costvalue, a.registration_user_cd ,a.registration_date_time,a.time_check_fi,
            //b.registration_user_cd user_cd_vt, b.registration_date_time date_time_vt, b.value_last 
            //from t_vt_machine a
            //left join t_vt_list_check b on b.machine_cd = a.machine_cd
            //where 1=1 and b.check_time = a.time_check_fi ");
            sql.Append(@"select machine_id, rfid_cd, machine_cd,  machine_name, machine_qty,  machine_serial, machine_model,  machine_location, machine_suppiler, machine_invoice, machine_status, machine_costvalue, registration_user_cd ,registration_date_time,time_check_fi,factory_cd
              from t_vt_machine
              where 1=1 ");
            if (!String.IsNullOrEmpty(inVo.RFId))
            {
                sql.Append(@" and   rfid_cd  =:rfid_cd");
                sqlParameter.AddParameterString("rfid_cd", inVo.RFId);
            }
          
            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(" and machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.MachineModel))
            {
                sql.Append(" and machine_model  =:machine_model");
                sqlParameter.AddParameterString("machine_model", inVo.MachineModel);
            }
            if (!String.IsNullOrEmpty(inVo.MachineSupplier))
            {
                sql.Append(" and machine_suppiler  =:machine_suppiler");
                sqlParameter.AddParameterString("machine_suppiler", inVo.MachineSupplier);
            }
            if (!String.IsNullOrEmpty(inVo.MachineLocation))
            {
                sql.Append(" and machine_location  =:machine_location");
                sqlParameter.AddParameterString("machine_location", inVo.MachineLocation);
            }
            if (!String.IsNullOrEmpty(inVo.MachineStatus))
            {
                sql.Append(" and machine_status  =:machine_status");
                sqlParameter.AddParameterString("machine_status", inVo.MachineStatus);
            }

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTVo outVo = new WarehouseVTVo
                {
                    MachineId = int.Parse(dataReader["machine_id"].ToString()),
                    RFId = dataReader["rfid_cd"].ToString(),
                    MachineCode = dataReader["machine_cd"].ToString(),
                    MachineName = dataReader["machine_name"].ToString(),
                    MachineQty = int.Parse(dataReader["machine_qty"].ToString()),
                    MachineSerial = dataReader["machine_serial"].ToString(),
                    MachineModel = dataReader["machine_model"].ToString(),
                    MachineLocation = dataReader["machine_location"].ToString(),
                    MachineSupplier = dataReader["machine_suppiler"].ToString(),
                    MachineInvoice = dataReader["machine_invoice"].ToString(),
                    MachineStatus = dataReader["machine_status"].ToString(),

                    MachineCostValue = (dataReader["machine_costvalue"].ToString()),
                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    TimeCheck = int.Parse(dataReader["time_check_fi"].ToString()),
                    FactoryCode = dataReader["factory_cd"].ToString(),

                    //ValueCheckCheck = bool.Parse(dataReader["value_last"].ToString()),
                    //RegistrationUserCodeCheck = dataReader["user_cd_vt"].ToString(),
                    //RegistrationDateTimeCheck = DateTime.Parse(dataReader["date_time_vt"].ToString())



                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
