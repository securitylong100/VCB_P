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
    public class DeleteDepartmentVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DepartmentVo inVo = (DepartmentVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("delete from  vcb_department Where 1=1 ");
            if (!String.IsNullOrEmpty(inVo.FactoryCode))
            {
                sql.Append(" and factory_cd = :factory_cd ");
                sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            }
            if (inVo.DepartmentId > 0)
            {
                sql.Append(" and vcb_department_id = :vcb_department_id ");
                sqlParameter.AddParameterInteger("vcb_department_id", inVo.DepartmentId);
            }
            if (!string.IsNullOrEmpty(inVo.DepartmentCode))
            {
                sql.Append(" and vcb_department_cd = :vcb_department_cd ");
                sqlParameter.AddParameterString("vcb_department_cd", inVo.DepartmentCode);
            }
            if (!string.IsNullOrEmpty(inVo.DepartmentName))
            {
                sql.Append(" and vcb_department_name = :vcb_department_name ");
                sqlParameter.AddParameterString("vcb_department_name", inVo.DepartmentName);
            }

           

            //create command
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL

            DepartmentVo outVo = new DepartmentVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
