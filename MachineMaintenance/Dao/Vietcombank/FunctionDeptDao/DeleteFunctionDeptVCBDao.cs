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
    public class DeleteFunctionDeptVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            FunctionDeptVo inVo = (FunctionDeptVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("delete from  vcb_functiondept Where 1=1 ");
          
            if (inVo.FunctionDeptId > 0)
            {
                sql.Append(" and vcb_functiondept_id = :vcb_functiondept_id ");
                sqlParameter.AddParameterInteger("vcb_functiondept_id", inVo.FunctionDeptId);
            }
           

           

            //create command
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL

            FunctionDeptVo outVo = new FunctionDeptVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
