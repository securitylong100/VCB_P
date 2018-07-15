﻿using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao;
using Com.Nidec.Mes.Framework;


namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm
{
    public class GetGroupCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new GetGroupDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                //throw ApplicationException
                return null;
            }

            return getDao.Execute(trxContext, vo);
        }
    }
}
