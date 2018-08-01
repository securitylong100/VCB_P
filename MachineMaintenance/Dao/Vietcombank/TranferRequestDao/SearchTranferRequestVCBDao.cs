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

            sql.Append(@"select a.vcb_id_request ,a.vcb_header_request, a.vcb_contents_request , a.vcb_statuscheck_process,b.vcb_functiondept_name,     
                        a.vcb_datetime_request, a.vcb_comments_process ,  a.vcb_datetime_process 
                        from vcb_trasfer_request a 
                        left join vcb_functiondept b on a.vcb_functiondept_id_request = b.vcb_functiondept_id where 1=1 ");           

            //if (!string.IsNullOrEmpty(inVo.FunctionDeptCode))
            //{
            //    sql.Append(" and c.vcb_functiondept_cd = :vcb_functiondept_cd ");
            //    sqlParameter.AddParameterString("vcb_functiondept_cd", inVo.FunctionDeptCode);
            //}
            
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                TranferRequestVo outVo = new TranferRequestVo
                {
                    RequestId = int.Parse(dataReader["vcb_id_request"].ToString()),
                    RequestHeader = dataReader["vcb_id_request"].ToString(),
                    RequestContents = dataReader["vcb_id_request"].ToString(),
                    //ProcessStatusCheck = dataReader["vcb_id_request"].ToString(),
                    FunctionDeptName = dataReader["vcb_id_request"].ToString(),
                    RequestDateTime =DateTime.Parse(dataReader["vcb_id_request"].ToString()),
                    //ProcessComments = dataReader["vcb_id_request"].ToString(),
                    //ProcessDateTime =DateTime.Parse( dataReader["vcb_id_request"].ToString())
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
