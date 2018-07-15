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
    public class SearchMainternanceMachineVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MaintenanceMachineVTVo inVo = (MaintenanceMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<MaintenanceMachineVTVo> voList = new ValueObjectList<MaintenanceMachineVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select a.maintenance_id,  a.machine_model, a.machine_serial, a.start_day, a.month_repeat, a.check_status, a.registration_user_cd, 
                        a.registration_date_time, a.factory_cd, b.machine_name, b.machine_suppiler, b.machine_status, b.machine_qty, b.rfid_cd, b.machine_location
                         from t_vt_maintenance a 
                          left join t_vt_machine b on a.machine_serial = b.machine_serial where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.RFId))
            {
                sql.Append(@" and   b.rfid_cd  =:rfid_cd");
                sqlParameter.AddParameterString("rfid_cd", inVo.RFId);
            }

            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(" and a.machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.MachineModel))
            {
                sql.Append(" and b.machine_model  =:machine_model");
                sqlParameter.AddParameterString("machine_model", inVo.MachineModel);
            }
            if (!String.IsNullOrEmpty(inVo.MachineSupplier))
            {
                sql.Append(" and b.machine_suppiler  =:machine_suppiler");
                sqlParameter.AddParameterString("machine_suppiler", inVo.MachineSupplier);
            }
            if (!String.IsNullOrEmpty(inVo.MachineLocation))
            {
                sql.Append(" and b.machine_location  =:machine_location");
                sqlParameter.AddParameterString("machine_location", inVo.MachineLocation);
            }
            if (!String.IsNullOrEmpty(inVo.MachineStatus))
            {
                sql.Append(" and b.machine_status  =:machine_status");
                sqlParameter.AddParameterString("machine_status", inVo.MachineStatus);
            }
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo
                {
                    MainternanceId = int.Parse(dataReader["maintenance_id"].ToString()),
                    RFId = dataReader["rfid_cd"].ToString(),
                    MachineName = dataReader["machine_name"].ToString(),
                    MachineSerial = dataReader["machine_serial"].ToString(),
                    MachineModel = dataReader["machine_model"].ToString(),
                    MachineLocation = dataReader["machine_location"].ToString(),
                    MachineSupplier = dataReader["machine_suppiler"].ToString(),
                    MachineStatus = dataReader["machine_status"].ToString(),

                    StartDay =DateTime.Parse( dataReader["start_day"].ToString()),
                    MonthRepeat = int.Parse(dataReader["month_repeat"].ToString()),
                    CheckStatus = bool.Parse( dataReader["check_status"].ToString()),

                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),                  
                    FactoryCode = dataReader["factory_cd"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;


        }
    }
}

