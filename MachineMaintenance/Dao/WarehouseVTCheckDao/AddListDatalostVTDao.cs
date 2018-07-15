using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class AddListDatalostVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTListVo inVo = (WarehouseVTListVo)vo;
            
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_vt_datalost(rfid,
            machine_serial,
            check_time,
            command) ");
                    sql.Append(@"values(:rfid,
            :machine_serial,
            :check_time,
            :command)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("rfid", inVo.RFId);
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("check_time", inVo.CheckTime);
            sqlParameter.AddParameter("command", inVo.Comment);

            WarehouseVTListVo outVo = new WarehouseVTListVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
            
        }
    }
}
