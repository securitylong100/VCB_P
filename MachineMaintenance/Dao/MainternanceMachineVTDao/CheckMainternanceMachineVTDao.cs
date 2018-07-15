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
    public class CheckMainternanceMachineVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MaintenanceMachineVTVo inVo = (MaintenanceMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
           MaintenanceMachineVTVo voNOList = new MaintenanceMachineVTVo();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"select count(*) as SerialCount from t_vt_maintenance where ");
            sql.Append(" machine_serial  =:machine_serial");
            sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo
                {
                  
                    AffectedCount  = Convert.ToInt32(dataReader["SerialCount"].ToString()),
            
                };
                voNOList.AffectedCount = outVo.AffectedCount;
            }
            dataReader.Close();
            return voNOList;
        }
    }
}
