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
            FunctionDeptVo inVo = (FunctionDeptVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("update vcb_trasfer_request set vcb_statuscheck_process =:vcb_statuscheck_process, vcb_comments_process =:vcb_comments_process, vcb_datetime_process =:vcb_datetime_process");
            sql.Append(" where vcb_functiondept_id =:vcb_functiondept_id");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sqlParameter.AddParameterString("vcb_functiondept_cd", inVo.FunctionDeptCode);
            sqlParameter.AddParameterString("vcb_functiondept_name", inVo.FunctionDeptName);
            sqlParameter.AddParameterString("user_name", inVo.UserName);

       
            //execute SQL

            FunctionDeptVo outVo = new FunctionDeptVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
