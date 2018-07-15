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
    public class SearchMachineVTListDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTListVo inVo = (WarehouseVTListVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WarehouseVTListVo> voList = new ValueObjectList<WarehouseVTListVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"select a.check_id,b.rfid_cd,  a.machine_serial,  a.check_time,a.registration_user_cd,  a.registration_date_time, a.value_last
                        from t_vt_list_check a 
                        left join t_vt_machine b on a.machine_serial = b.machine_serial where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(@" and   b.machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.CheckTime.ToString()))
            {
                sql.Append(@" and   check_time  =:check_time");
                sqlParameter.AddParameterInteger("check_time", inVo.CheckTime);
            }
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTListVo outVo = new WarehouseVTListVo
                {
                    CheckId = int.Parse(dataReader["check_id"].ToString()),
                    RFId = dataReader["rfid_cd"].ToString(),
                    MachineSerial = dataReader["machine_serial"].ToString(),
                    CheckTime = int.Parse(dataReader["check_time"].ToString()),
                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    ValueCheck = bool.Parse( dataReader["value_last"].ToString()),
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;

            
        }
    }
}
