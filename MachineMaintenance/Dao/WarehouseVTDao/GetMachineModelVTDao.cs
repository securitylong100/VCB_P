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
    public class GetMachineModelVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WarehouseVTVo inVo = (WarehouseVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WarehouseVTVo> voList = new ValueObjectList<WarehouseVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@" select distinct machine_model from t_vt_machine order by machine_model");



            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WarehouseVTVo outVo = new WarehouseVTVo
                {
                  
                    MachineModel = dataReader["machine_model"].ToString(),
                  
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
