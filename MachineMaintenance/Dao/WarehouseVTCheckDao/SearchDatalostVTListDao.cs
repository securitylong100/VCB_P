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
    public class SearchDatalostVTListDao : AbstractDataAccessObject
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
            sql.Append(@"select datalost_id,  rfid,  machine_serial,check_time,  command 
                        from t_vt_datalost where 1=1 ");
            
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //check time ???


            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTListVo outVo = new WarehouseVTListVo
                {
                    DatalostId = int.Parse(dataReader["datalost_id"].ToString()),
                    RFId = dataReader["rfid"].ToString(),
                    MachineSerial = dataReader["machine_serial"].ToString(),
                    CheckTime = int.Parse(dataReader["check_time"].ToString()),
                    Comment = dataReader["command"].ToString(),
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;

            
        }
    }
}
