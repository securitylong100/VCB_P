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
    public class DeleteTransferRequestDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append("delete from vcb_tranfer_list where 1=1  ");
            if(inVo.RequestCode > 0)
            {
                sql.Append(" and vcb_code_request = :vcb_code_request ");
                sqlParameter.AddParameter("vcb_code_request", inVo.RequestCode);
            }
            //create command

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //create parameter
            int t = sqlCommandAdapter.ExecuteNonQuery(sqlParameter);
            TranferRequestVo outVo = new TranferRequestVo();
            if (t > 0)//thuc hiên delete trong transfer khi đã delete trong list
            {
                StringBuilder sql_delete_transfer = new StringBuilder();
                DbCommandAdaptor sqlCommandAdapter2 = base.GetDbCommandAdaptor(trxContext, sql_delete_transfer.ToString());
                DbParameterList sqlParameter2 = sqlCommandAdapter2.CreateParameterList();

                sql_delete_transfer.Append("delete from vcb_trasfer_request where 1=1");
                sql_delete_transfer.Append(" and vcb_code_request = :vcb_code_request ");
                sqlParameter2.AddParameter("vcb_code_request", inVo.RequestCode);

                sqlCommandAdapter2 = base.GetDbCommandAdaptor(trxContext, sql_delete_transfer.ToString());
                outVo.AffectedCount = sqlCommandAdapter2.ExecuteNonQuery(sqlParameter2);
            }
            return outVo;
        }
    }
}
