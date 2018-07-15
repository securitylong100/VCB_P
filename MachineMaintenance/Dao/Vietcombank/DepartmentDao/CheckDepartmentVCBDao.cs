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
    public class CheckDepartmentVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DepartmentVo inVo = (DepartmentVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("Select Count(*) as DepartmentCount ");
            sql.Append(" from  vcb_department");
            sql.Append(" Where 1=1 ");
    
            if (!String.IsNullOrEmpty(inVo.FactoryCode))
            {
                sql.Append(" and factory_cd = :factory_cd ");
                sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            }
            if (!string.IsNullOrEmpty(inVo.DepartmentCode))
            {
                sql.Append(" and UPPER(vcb_department_cd) = UPPER(:vcb_department_cd) ");
                sqlParameter.AddParameterString("vcb_department_cd", inVo.DepartmentCode);
            }
            if (inVo.DepartmentId > 0)
            {
                sql.Append(" and vcb_department_id != :vcb_department_id "); ///?????
                sqlParameter.AddParameterInteger("vcb_department_id", inVo.DepartmentId);
            }
          

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            DepartmentVo outVo = new DepartmentVo();
            while (dataReader.Read())
            {
                outVo.AffectedCount = Convert.ToInt32(dataReader["DepartmentCount"].ToString());
            }
            dataReader.Close();
            return outVo;
        }
    }
}
