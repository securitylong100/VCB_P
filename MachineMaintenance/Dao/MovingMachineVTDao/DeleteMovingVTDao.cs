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
    public class DeleteMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();


                sql.Append("Delete From t_vt_moving");
                sql.Append(" Where	");
            if (inVo.CodeStatus == "Bàn Giao")
            {
                sql.Append(" bg_cd = :code_name ;");
            }
            if (inVo.CodeStatus == "Mượn")
            {
                sql.Append(" m_cd = :code_name ;");
            }
            if (inVo.CodeStatus == "Trả")
            {
                sql.Append(" t_cd = :code_name ;");
            }
            if (inVo.CodeStatus == "Thuê")
            {
                sql.Append(" th_cd = :code_name ;");
            }

            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

                sqlParameter.AddParameter("code_name", inVo.CodeName);
    
            MovingMachineVTVo outVo = new MovingMachineVTVo { AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter) };
            return outVo;
        }
    }
}
