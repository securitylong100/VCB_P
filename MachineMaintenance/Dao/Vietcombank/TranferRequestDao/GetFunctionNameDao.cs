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
    public class GetFunctionNameDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            TranferRequestVo inVo = (TranferRequestVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<TranferRequestVo> voList = new ValueObjectList<TranferRequestVo>();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select distinct vcb_functiondept_name
	            from vcb_functiondept order by vcb_functiondept_name ");  
                    
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                TranferRequestVo outVo = new TranferRequestVo
                {
                    FunctionDeptName = dataReader["vcb_functiondept_name"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
