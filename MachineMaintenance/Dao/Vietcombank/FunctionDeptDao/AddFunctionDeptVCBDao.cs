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
    public class AddFunctionDeptVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            FunctionDeptVo inVo = (FunctionDeptVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into vcb_functiondept(vcb_department_id, vcb_functiondept_cd, vcb_functiondept_name, registration_user_cd, registration_date_time, factory_cd) ");
            sql.Append("values(:vcb_department_id, :vcb_functiondept_cd, :vcb_functiondept_name, :registration_user_cd, now(), :factory_cd)");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterInteger("vcb_department_id", inVo.DepartmentId);
            sqlParameter.AddParameterString("vcb_functiondept_cd", inVo.FunctionDeptCode);
            sqlParameter.AddParameterString("vcb_functiondept_name", inVo.FunctionDeptName);
        
            sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            sqlParameter.AddParameterString("registration_user_cd", inVo.RegistrationUserCode);
            //execute SQL

            FunctionDeptVo outVo = new FunctionDeptVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
