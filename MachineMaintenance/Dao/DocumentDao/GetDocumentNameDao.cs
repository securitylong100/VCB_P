﻿using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class GetDocumentNameDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DocumentVo inVo = (DocumentVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<DocumentVo> voList = new ValueObjectList<DocumentVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"SELECT document_name from t_document order by document_name");

            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                DocumentVo outVo = new DocumentVo
                {
                    DocumentName = dataReader["document_name"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}