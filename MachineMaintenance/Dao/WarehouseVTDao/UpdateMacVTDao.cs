using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateMacVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update m_ncvp set ncvp_cd =:ncvp_cd");

            //      
            //     ,
            //                                             

            //

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
       
            sqlParameter.AddParameter("ncvp_cd", inVo.MacLocal);
           
            //execute SQL

            WarehouseVTVo outVo = new WarehouseVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }

    }
}