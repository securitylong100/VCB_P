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
    public class GetDepartmentVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DepartmentVo inVo = (DepartmentVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<DepartmentVo> voList = new ValueObjectList<DepartmentVo>();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select vcb_department_id, vcb_department_cd, vcb_department_name, registration_user_cd,registration_date_time,factory_cd from  vcb_department");
            sql.Append(" Where 1=1 ");
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
            //DbCommandAdaptor 
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                DepartmentVo outVo = new DepartmentVo
                {
                    DepartmentCode = dataReader["vcb_department_cd"].ToString(),
                    DepartmentId = int.Parse(dataReader["vcb_department_id"].ToString()),
                    DepartmentName =dataReader["vcb_department_name"].ToString(),

                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    FactoryCode = dataReader["factory_cd"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
