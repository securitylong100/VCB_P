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
    public class CheckFunctionDeptVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            FunctionDeptVo inVo = (FunctionDeptVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("Select Count(*) as FunctionCount ");
            sql.Append(" from  vcb_functiondept");
            sql.Append(" Where 1=1 ");
    
          
            if (!string.IsNullOrEmpty(inVo.FunctionDeptCode))
            {
                sql.Append(" and UPPER(vcb_functiondept_cd) = UPPER(:vcb_functiondept_cd) ");
                sqlParameter.AddParameterString("vcb_functiondept_cd", inVo.FunctionDeptCode);
            }
            
            if (inVo.FunctionDeptId > 0)
            {
                sql.Append(" and vcb_department_id != :vcb_department_id "); ///?????
                sqlParameter.AddParameterInteger("vcb_department_id", inVo.FunctionDeptId);
            }
          

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            FunctionDeptVo outVo = new FunctionDeptVo();
            while (dataReader.Read())
            {
                outVo.CheckRow = Convert.ToInt32(dataReader["FunctionCount"].ToString());
            }
            dataReader.Close();
            return outVo;
        }
    }
}
