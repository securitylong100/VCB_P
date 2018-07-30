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
    public class AddTranferListDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into vcb_tranfer_list(vcb_functiondept_id, vcb_code_request, vcb_type_list) ");
            sql.Append("values(:vcb_functiondept_id, :vcb_code_request, :vcb_type_list)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sqlParameter.AddParameterInteger("vcb_functiondept_id", inVo.FunctionDeptId);
            sqlParameter.AddParameterInteger("vcb_code_request", inVo.RequestCode);
            sqlParameter.AddParameterString("vcb_type_list", inVo.TypeList);

            //execute SQL

            TranferRequestVo outVo = new TranferRequestVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
