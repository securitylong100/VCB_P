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
    public class SearchMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<MovingMachineVTVo> voList = new ValueObjectList<MovingMachineVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //Bàn Giao
            //Mượn
            //Trả
            //Thuê
            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select a.moving_id, a.machine_serial, a.factory_tranfer_cd, a.factory_received_cd, a.bg_cd, a.m_cd, a.t_cd, a.th_cd,  a.status, 
            a.comments_machine, a.reason_tranfer, a.confirm_received, a.registration_user_cd, a.registration_date_time, a.factory_cd, b.machine_name, b.machine_model, b.machine_costvalue
            from t_vt_moving a
            left join t_vt_machine b on a.machine_serial = b.machine_serial
              where 1=1 ");


            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(" and a.machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }
            if (!String.IsNullOrEmpty(inVo.TranferFactoryName))
            {
                sql.Append(" and a.factory_tranfer_cd  =:factory_tranfer_cd");
                sqlParameter.AddParameterString("factory_tranfer_cd", inVo.TranferFactoryName);
            }
            if (!String.IsNullOrEmpty(inVo.ReceivedFactoryName))
            {
                sql.Append(" and a.factory_received_cd  =:factory_received_cd");
                sqlParameter.AddParameterString("factory_received_cd", inVo.ReceivedFactoryName);
            }
            if (inVo.CodeStatus == "Bàn Giao")
            {
                if (!String.IsNullOrEmpty(inVo.CodeName))
                {
                    sql.Append(" and a.bg_cd  =:bg_cd");
                    sqlParameter.AddParameterString("bg_cd", inVo.CodeName);
                }
                else
                {
                    sql.Append(" and a.bg_cd  >'0'");
                }
            }
            if (inVo.CodeStatus == "Mượn")
            {
                if (!String.IsNullOrEmpty(inVo.CodeName))
                {
                    sql.Append(" and a.m_cd  =:m_cd");
                    sqlParameter.AddParameterString("m_cd", inVo.CodeName);
                }
                else
                {
                    sql.Append(" and a.m_cd  >'0'");
                }
            }
            if (inVo.CodeStatus == "Trả")
            {
                if (!String.IsNullOrEmpty(inVo.CodeName))
                {
                    sql.Append(" and a.t_cd  =:t_cd");
                    sqlParameter.AddParameterString("t_cd", inVo.CodeName);
                }
                else
                {
                    sql.Append(" and a.t_cd  >'0'");
                }
            }
            if (inVo.CodeStatus == "Thuê")
            {
                if (!String.IsNullOrEmpty(inVo.CodeName))
                {
                    sql.Append(" and a.th_cd  =:th_cd");
                    sqlParameter.AddParameterString("th_cd", inVo.CodeName);
                }
                else
                {
                    sql.Append(" and a.th_cd  >'0'");
                }
            }

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                if (inVo.CodeStatus == "Bàn Giao")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo
                    {
                        MovingId = int.Parse(dataReader["moving_id"].ToString()),
                        MachineSerial = dataReader["machine_serial"].ToString(),
                        TranferFactoryName = dataReader["factory_tranfer_cd"].ToString(),
                        ReceivedFactoryName = dataReader["factory_received_cd"].ToString(),
                        CodeName = dataReader["bg_cd"].ToString(), //only change
                        Status = dataReader["status"].ToString(),
                        CommentsMachine = dataReader["comments_machine"].ToString(),
                        ReasonTranfer = dataReader["reason_tranfer"].ToString(),
                        ConfirmReceived = dataReader["confirm_received"].ToString(),
                        MachineName = (dataReader["machine_name"].ToString()),
                        RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                        RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                        FactoryCode = dataReader["factory_cd"].ToString(),
                        CodeStatus = inVo.CodeStatus,
                        MachineModel = dataReader["machine_model"].ToString(),
                        MachineCostValue =dataReader["machine_costvalue"].ToString(),
                    };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Mượn")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo
                    {
                        MovingId = int.Parse(dataReader["moving_id"].ToString()),
                        MachineSerial = dataReader["machine_serial"].ToString(),
                        TranferFactoryName = dataReader["factory_tranfer_cd"].ToString(),
                        ReceivedFactoryName = dataReader["factory_received_cd"].ToString(),
                        CodeName = dataReader["m_cd"].ToString(),//only change
                        Status = dataReader["status"].ToString(),
                        CommentsMachine = dataReader["comments_machine"].ToString(),
                        ReasonTranfer = dataReader["reason_tranfer"].ToString(),
                        ConfirmReceived = dataReader["confirm_received"].ToString(),
                        MachineName = (dataReader["machine_name"].ToString()),
                        RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                        RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                        FactoryCode = dataReader["factory_cd"].ToString(),
                        CodeStatus = inVo.CodeStatus,
                        MachineModel = dataReader["machine_model"].ToString(),
                        MachineCostValue =dataReader["machine_costvalue"].ToString(),
                       
                    };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Trả")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo
                    {
                        MovingId = int.Parse(dataReader["moving_id"].ToString()),
                        MachineSerial = dataReader["machine_serial"].ToString(),
                        TranferFactoryName = dataReader["factory_tranfer_cd"].ToString(),
                        ReceivedFactoryName = dataReader["factory_received_cd"].ToString(),
                        CodeName = dataReader["t_cd"].ToString(),//only change
                        Status = dataReader["status"].ToString(),
                        CommentsMachine = dataReader["comments_machine"].ToString(),
                        ReasonTranfer = dataReader["reason_tranfer"].ToString(),
                        ConfirmReceived = dataReader["confirm_received"].ToString(),
                        MachineName = (dataReader["machine_name"].ToString()),
                        RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                        RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                        FactoryCode = dataReader["factory_cd"].ToString(),
                        CodeStatus = inVo.CodeStatus,
                        MachineModel = dataReader["machine_model"].ToString(),
                      MachineCostValue = dataReader["machine_costvalue"].ToString(),
                       
                    };
                    voList.add(outVo);
                }
                if (inVo.CodeStatus == "Thuê")
                {
                    MovingMachineVTVo outVo = new MovingMachineVTVo
                    {
                        MovingId = int.Parse(dataReader["moving_id"].ToString()),
                        MachineSerial = dataReader["machine_serial"].ToString(),
                        TranferFactoryName = dataReader["factory_tranfer_cd"].ToString(),
                        ReceivedFactoryName = dataReader["factory_received_cd"].ToString(),
                        CodeName = dataReader["th_cd"].ToString(),//only change
                        Status = dataReader["status"].ToString(),
                        CommentsMachine = dataReader["comments_machine"].ToString(),
                        ReasonTranfer = dataReader["reason_tranfer"].ToString(),
                        ConfirmReceived = dataReader["confirm_received"].ToString(),
                        MachineName = (dataReader["machine_name"].ToString()),
                        RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                        RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                        FactoryCode = dataReader["factory_cd"].ToString(),
                        CodeStatus = inVo.CodeStatus,
                        MachineModel = dataReader["machine_model"].ToString(),
                        MachineCostValue = dataReader["machine_costvalue"].ToString(),
                    };
                    voList.add(outVo);
                }
            }
            dataReader.Close();
            return voList;
        }
    }
}
