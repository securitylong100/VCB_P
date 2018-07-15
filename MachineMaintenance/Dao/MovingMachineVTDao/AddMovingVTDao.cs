using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class AddMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_vt_moving(machine_serial,
            factory_tranfer_cd ,
          factory_received_cd ,
          bg_cd,
          m_cd,
          t_cd,
          th_cd,
          status,
          comments_machine,
           reason_tranfer,
            confirm_received,
          registration_user_cd,
          registration_date_time,
            factory_cd) ");
            sql.Append(@"values(:machine_serial ,
            :factory_tranfer_cd,
          :factory_received_cd ,
          :bg_cd ,
          :m_cd,
          :t_cd,
          :th_cd,
          :status,
          :comments_machine,
          :reason_tranfer,
            :confirm_received,
         :registration_user_cd,
          now(),
            :factory_cd)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("machine_serial", inVo.MachineSerial);
            sqlParameter.AddParameter("factory_tranfer_cd", inVo.TranferFactoryName);
            sqlParameter.AddParameter("factory_received_cd", inVo.ReceivedFactoryName);
            sqlParameter.AddParameter("bg_cd", inVo.BGCode);
            sqlParameter.AddParameter("m_cd", inVo.MCode);
            sqlParameter.AddParameter("t_cd", inVo.TCode);
            sqlParameter.AddParameter("th_cd", inVo.THCode);
            sqlParameter.AddParameter("status", inVo.Status);
            sqlParameter.AddParameter("comments_machine", inVo.CommentsMachine);
            sqlParameter.AddParameter("reason_tranfer", inVo.ReasonTranfer);
            sqlParameter.AddParameter("confirm_received", inVo.ConfirmReceived);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserCode);
            sqlParameter.AddParameter("factory_cd", UserData.GetUserData().FactoryCode);
          

            //execute SQL

            MovingMachineVTVo outVo = new MovingMachineVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
