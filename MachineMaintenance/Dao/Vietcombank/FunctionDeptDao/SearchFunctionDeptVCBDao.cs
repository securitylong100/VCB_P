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
    public class SearchFunctionDeptVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            FunctionDeptVo inVo = (FunctionDeptVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<FunctionDeptVo> voList = new ValueObjectList<FunctionDeptVo>();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"select c.vcb_functiondept_id, c.vcb_functiondept_cd, c.vcb_functiondept_name, c.user_name, c.registration_user_cd, c.registration_date_time, c.factory_cd, b.vcb_department_cd, b.vcb_department_name 
                    from  vcb_functiondept c 
                    left join vcb_department b on c.vcb_department_id  = b.vcb_department_id Where 1=1  "); 
           

            if (!string.IsNullOrEmpty(inVo.FunctionDeptCode))
            {
                sql.Append(" and c.vcb_functiondept_cd = :vcb_functiondept_cd ");
                sqlParameter.AddParameterString("vcb_functiondept_cd", inVo.FunctionDeptCode);
            }
            if (!string.IsNullOrEmpty(inVo.FunctionDeptName))
            {
                sql.Append(" and c.vcb_functiondept_name = :vcb_functiondept_name ");
                sqlParameter.AddParameterString("vcb_functiondept_name", inVo.FunctionDeptName);
            }
            if (!string.IsNullOrEmpty(inVo.DepartmentCode))
            {
                sql.Append(" and b.vcb_department_cd = :vcb_department_cd ");
                sqlParameter.AddParameterString("vcb_department_cd", inVo.DepartmentCode);
            }
            //if (!string.IsNullOrEmpty(inVo.UserName))
            //{
            //    sql.Append(" and c.user_name = :user_name ");
            //    sqlParameter.AddParameterString("user_name", inVo.UserName);
            //}
            if(inVo.HienThi == 1)
            {
                sql.Append(" and c.user_name != :tenhienthi");
                sqlParameter.AddParameter("tenhienthi", inVo.TenHienThi);
            }

            //create command
            //DbCommandAdaptor 
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                FunctionDeptVo outVo = new FunctionDeptVo
                {
                    DepartmentCode = dataReader["vcb_department_cd"].ToString(),
                    DepartmentName = dataReader["vcb_department_name"].ToString(),
                    
                    FunctionDeptId = int.Parse(dataReader["vcb_functiondept_id"].ToString()),
                    FunctionDeptCode = dataReader["vcb_functiondept_cd"].ToString(),
                    FunctionDeptName = dataReader["vcb_functiondept_name"].ToString(),
                    UserName = dataReader["user_name"].ToString(),
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
