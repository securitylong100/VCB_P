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
    public class SearchResuftCheckVTDao : AbstractDataAccessObject
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
            if (inVo.ValueResult == "True")
            {
                sql.Append(@"select machine_id, rfid_cd, machine_cd,  machine_name, machine_qty,  machine_serial, machine_model,  machine_location, machine_suppiler, machine_invoice, machine_costvalue, registration_user_cd ,registration_date_time,time_check_fi
              from t_vt_machine
              where 1=1  ");
                sql.Append(@" and   time_check_fi  =:time_check_fi");
                sqlParameter.AddParameterInteger("time_check_fi", inVo.TimeCheck);
                sql.Append(" AND machine_status = 'Máy CTY' or  machine_status = 'Đã Cho Mượn' ");
            }
            else   if (inVo.ValueResult == "False")
                {
                    sql.Append(@"select machine_id, rfid_cd, machine_cd,  machine_name, machine_qty,  machine_serial, machine_model,  machine_location, machine_suppiler, machine_invoice, machine_costvalue, registration_user_cd ,registration_date_time,time_check_fi
              from t_vt_machine
              where 1=1 ");
                sql.Append(@" and   time_check_fi  !=:time_check_fi");
                sqlParameter.AddParameterInteger("time_check_fi", inVo.TimeCheck);
                sql.Append(" AND machine_status = 'Máy CTY' or  machine_status = 'Đã Cho Mượn' ");
            }
            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(@" and   machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
           
            if (!String.IsNullOrEmpty(inVo.RFId))
            {
                sql.Append(@" and   rfid_cd  =:rfid_cd");
                sqlParameter.AddParameter("rfid_cd", inVo.RFId);
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

                    MachineCostValue = (dataReader["machine_costvalue"].ToString()),
                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    TimeCheck = int.Parse(dataReader["time_check_fi"].ToString()),

                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;


        }
    }
}
