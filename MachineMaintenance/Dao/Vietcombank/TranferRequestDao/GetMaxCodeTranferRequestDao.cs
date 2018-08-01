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
    public class GetMaxCodeTranferRequestDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
        TranferRequestVo voList = new TranferRequestVo();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"select Case when Max(vcb_code_request) is null then 0 else Max(vcb_code_request) + 1 end maxcode from  vcb_tranfer_list ");   
           


            //create command
            //DbCommandAdaptor 
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                TranferRequestVo outVo = new TranferRequestVo
                {

                    RequestCode = int.Parse(dataReader["maxcode"].ToString())
                };

                voList.RequestCode = outVo.RequestCode;
            }
            dataReader.Close();
            return voList;
        }
    }
}
