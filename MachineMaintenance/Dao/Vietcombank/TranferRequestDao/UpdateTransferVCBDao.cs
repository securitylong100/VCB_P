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
    public class UpdateTransferVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("update vcb_trasfer_request set vcb_statuscheck_process =:vcb_statuscheck_process, vcb_comments_process =:vcb_comments_process, vcb_datetime_process = now() ");
            sql.Append(" where vcb_id_request =:vcb_id_request");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sqlParameter.AddParameter("vcb_statuscheck_process", inVo.ProcessStatusCheck);
            sqlParameter.AddParameterString("vcb_comments_process", inVo.ProcessComments);
            sqlParameter.AddParameterInteger("vcb_id_request", inVo.RequestId);

       
            //execute SQL

            TranferRequestVo outVo = new TranferRequestVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
