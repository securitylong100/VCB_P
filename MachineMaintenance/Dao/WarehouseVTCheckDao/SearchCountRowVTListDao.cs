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
    public class SearchCountRowVTListDao : AbstractDataAccessObject
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
            sql.Append(@"select count(*) as counter from t_vt_list_check b
left join t_vt_machine a on a.machine_serial = b.machine_serial where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(@" and   b.machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.CheckTime.ToString()))
            {
                sql.Append(@" and   b.check_time  =:check_time");
                sqlParameter.AddParameterInteger("check_time", inVo.CheckTime);
            }
            if (!String.IsNullOrEmpty(inVo.RFId))
            {
                sql.Append(@" and   a.rfid_cd  =:rfid_cd");
                sqlParameter.AddParameterString("rfid_cd", inVo.RFId);
            }
                   

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTListVo outVo = new WarehouseVTListVo
                {


                    CounterRow = dataReader["counter"].ToString(),
                  
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;

            
        }
    }
}
