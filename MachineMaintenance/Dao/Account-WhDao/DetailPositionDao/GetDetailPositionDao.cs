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
    public class GetDetailPositionDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DetailPositionVo inVo = (DetailPositionVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<DetailPositionVo> voList = new ValueObjectList<DetailPositionVo>();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select detail_postion_id, detail_postion_cd, detail_postion_name, registration_user_cd,registration_date_time,factory_cd from  m_detail_postion");
            sql.Append(" Where 1=1 ");
        
            if (inVo.DetailPositionId > 0)
            {
                sql.Append(" and detail_postion_id = :detail_postion_id ");
                sqlParameter.AddParameterInteger("detail_postion_id", inVo.DetailPositionId);
            }
            if (!string.IsNullOrEmpty(inVo.DetailPositionCode))
            {
                sql.Append(" and detail_postion_cd = :detail_postion_cd ");
                sqlParameter.AddParameterString("detail_postion_cd", inVo.DetailPositionCode);
            }
            if (!string.IsNullOrEmpty(inVo.DetailPositionName))
            {
                sql.Append(" and detail_postion_name = :detail_postion_name ");
                sqlParameter.AddParameterString("detail_postion_name", inVo.DetailPositionName);
            }
           

            //create command
            //DbCommandAdaptor 
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                DetailPositionVo outVo = new DetailPositionVo
                {
                    DetailPositionCode = dataReader["detail_postion_cd"].ToString(),
                    DetailPositionId = int.Parse(dataReader["detail_postion_id"].ToString()),
                    DetailPositionName = dataReader["detail_postion_name"].ToString(),

                    RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    FactoryCode = dataReader["factory_cd"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
