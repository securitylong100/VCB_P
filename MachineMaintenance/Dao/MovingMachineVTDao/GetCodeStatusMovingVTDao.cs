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
    public class GetCodeStatusMovingVTDao : AbstractDataAccessObject
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
            sql.Append(@"select max(bg_cd) as bg_cd_max, max(m_cd) as m_cd_max, max(t_cd) as t_cd_max , max(th_cd) as th_cd_max from t_vt_moving");



            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                MovingMachineVTVo outVo = new MovingMachineVTVo
                {
                  
                    BGCode  = dataReader["bg_cd_max"].ToString(),
                    MCode = dataReader["m_cd_max"].ToString(),
                    TCode = dataReader["t_cd_max"].ToString(),
                    THCode = dataReader["th_cd_max"].ToString(),

                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
