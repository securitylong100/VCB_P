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
    public class SearchCheckTimeVTDao : AbstractDataAccessObject
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
            sql.Append(@"select max(check_time) from t_vt_list_check where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(@" and   machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTListVo outVo = new WarehouseVTListVo
                {
                    CheckTime = int.Parse(dataReader["check_time"].ToString()),
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;

            
        }
    }
}
