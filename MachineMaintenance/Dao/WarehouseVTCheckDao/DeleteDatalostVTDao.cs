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
    public class DeleteDatalostVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTListVo inVo = (WarehouseVTListVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"Delete From t_vt_datalost Where ");
            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(@"  machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.RFId))
            {
                sql.Append(@" or   rfid  =:rfid");
                sqlParameter.AddParameterString("rfid", inVo.RFId);
            }

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            WarehouseVTListVo outVo = new WarehouseVTListVo { AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter) };

            return outVo;
        }
    }
}
