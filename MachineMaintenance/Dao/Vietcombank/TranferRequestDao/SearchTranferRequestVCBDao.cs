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
    public class SearchTranferRequestVCBDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<TranferRequestVo> voList = new ValueObjectList<TranferRequestVo>();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select  a.vcb_id_request,a.vcb_code_request, b.user_name, c.vcb_department_name, a.vcb_datetime_request, e.user_name user_process,e.vcb_functiondept_name, d.vcb_type_list, a.vcb_header_request, a.vcb_contents_request, a.vcb_statuscheck_process, a.vcb_comments_process, a.vcb_datetime_process
	            from vcb_trasfer_request a 
	            left join vcb_functiondept b on a.vcb_functiondept_id_request = b.vcb_functiondept_id
	            left join vcb_department c on b.vcb_department_id = c.vcb_department_id
	            left join vcb_tranfer_list d on d.vcb_code_request = a.vcb_code_request 
	            left join vcb_functiondept e on e.vcb_functiondept_id = d.vcb_functiondept_id where 1=1 ");

            if (!string.IsNullOrEmpty(inVo.FunctionDeptName))
            {
                sql.Append(" and e.vcb_functiondept_name = :vcb_functiondept_name ");
                sqlParameter.AddParameterString("vcb_functiondept_name", inVo.FunctionDeptName);
            }
            if (!string.IsNullOrEmpty(inVo.DepartmentName))
            {
                sql.Append(" and c.vcb_department_name = :vcb_department_name ");
                sqlParameter.AddParameterString("vcb_department_name", inVo.DepartmentName);
            }
            if (!string.IsNullOrEmpty(inVo.SentReceive))
            {
                if(inVo.SentReceive == "Sent")//sent
                {
                    sql.Append(" and b.user_name = '" + UserData.GetUserData().UserName + "'");
                }
                else if(inVo.SentReceive == "Received")//receive
                    
                {
                    sql.Append(" and e.user_name = '" + UserData.GetUserData().UserName + "'");
                }
            }           

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                TranferRequestVo outVo = new TranferRequestVo
                {
                    RequestId = int.Parse(dataReader["vcb_id_request"].ToString()),
                    RequestCode =int.Parse(dataReader["vcb_code_request"].ToString()),
                    UserNameRequest = dataReader["user_name"].ToString(),
                    DepartmentName = dataReader["vcb_department_name"].ToString(),
                    RequestDateTime = DateTime.Parse(dataReader["vcb_datetime_request"].ToString()),
                    UserNameProcess= dataReader["user_process"].ToString(),
                    FunctionDeptName = dataReader["vcb_functiondept_name"].ToString(),
                    TypeList = dataReader["vcb_type_list"].ToString(),
                    RequestHeader = dataReader["vcb_header_request"].ToString(),
                    RequestContents = dataReader["vcb_contents_request"].ToString(),

                    ProcessStatusCheck = Convert.ToBoolean(dataReader["vcb_statuscheck_process"]),
                    ProcessComments = dataReader["vcb_comments_process"].ToString(),
                    ProcessDateTime = DateTime.Parse(dataReader["vcb_datetime_process"].ToString())
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
