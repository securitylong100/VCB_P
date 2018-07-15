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
    public class GetCodeNameMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<MovingMachineVTVo> voList = new ValueObjectList<MovingMachineVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            //Bàn Giao
            //Mượn
            //Trả
            //Thuê
            if (inVo.CodeStatus == "Bàn Giao")
            {
                sql.Append(@"select distinct bg_cd from t_vt_moving order by bg_cd DESC ");
            }
            if (inVo.CodeStatus == "Mượn")
            {
                sql.Append(@"select distinct m_cd from t_vt_moving order by m_cd  DESC");
            }
            if (inVo.CodeStatus == "Trả")
            {
                sql.Append(@"select distinct t_cd from t_vt_moving order by t_cd DESC ");
            }
            if (inVo.CodeStatus == "Thuê")
            {
                sql.Append(@"select distinct th_cd from t_vt_moving order by th_cd DESC ");
            }


            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {

                if (inVo.CodeStatus == "Bàn Giao")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo { CodeName = dataReader["bg_cd"].ToString(), };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Mượn")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo { CodeName = dataReader["m_cd"].ToString(), };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Trả")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo { CodeName = dataReader["t_cd"].ToString(), };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Thuê")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo { CodeName = dataReader["th_cd"].ToString(), };
                    voList.add(outVo);
                }
            }
            dataReader.Close();
            return voList;
        }
    }
}
