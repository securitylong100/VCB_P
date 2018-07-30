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
    public class AddTranferRequestDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into vcb_trasfer_request(vcb_code_request, vcb_functiondept_cd_request, vcb_datetime_request,vcb_header_request, vcb_contents_request,vcb_statuscheck_process ) ");
            sql.Append("values(:vcb_code_request, :vcb_functiondept_cd_request, now(), :vcb_header_request, :vcb_contents_request, :vcb_statuscheck_process )");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sqlParameter.AddParameterInteger("vcb_code_request", inVo.RequestCode);
            sqlParameter.AddParameterString("vcb_functiondept_cd_request", inVo.FunctionDeptRequestCd);
            sqlParameter.AddParameterString("vcb_header_request", inVo.RequestHeader);
            sqlParameter.AddParameterString("vcb_contents_request", inVo.RequestContents);
            sqlParameter.AddParameter("vcb_statuscheck_process", inVo.ProcessStatusCheck);


            //execute SQL

            TranferRequestVo outVo = new TranferRequestVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
