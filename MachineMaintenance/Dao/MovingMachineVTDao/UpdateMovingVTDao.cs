using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class UpdateMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_vt_moving set status =:status,
comments_machine =:comments_machine, 
registration_user_cd =:registration_user_cd,
registration_date_time = now()
            where moving_id =:moving_id");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("status", inVo.Status);
            sqlParameter.AddParameter("moving_id", inVo.MovingId);
            sqlParameter.AddParameter("comments_machine", inVo.CommentsMachine);
            sqlParameter.AddParameter("registration_user_cd", UserData.GetUserData().UserCode);
          //  sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);
            //execute SQL

            MovingMachineVTVo outVo = new MovingMachineVTVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }

    }
}