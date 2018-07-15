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
    public class UpdateDepartmentVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DepartmentVo inVo = (DepartmentVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("update vcb_department set vcb_department_cd =:vcb_department_cd,vcb_department_name =:vcb_department_name");
            sql.Append(" where vcb_department_id =:vcb_department_id");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterString("vcb_department_cd", inVo.DepartmentCode);
            sqlParameter.AddParameterString("vcb_department_name", inVo.DepartmentName);
            sqlParameter.AddParameterInteger("vcb_department_id", inVo.DepartmentId);
            sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            sqlParameter.AddParameterString("registration_user_cd", inVo.RegistrationUserCode);
            //execute SQL

            DepartmentVo outVo = new DepartmentVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
