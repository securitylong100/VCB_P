﻿using System;
using System.Collections.Generic;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class FunctionDeptVo : ValueObject
    {
        /// <summary>
        /// get and set RankId
        /// </summary>
        public int DepartmentId { get; set; }

        public string DepartmentCode { get; set; }

        public string DepartmentName{ get; set; }

        public int FunctionDeptId { get; set; }
        /// <summary>
        /// get and set RankCode
        /// </summary>
        public string FunctionDeptCode { get; set; }

        public string UserName { get; set; }

        /// <summary>
        /// get and set RankName
        /// </summary>
        public string FunctionDeptName { get; set; }

        /// <summary>
        /// get and set RegistrationUserCode
        /// </summary>
        public string RegistrationUserCode { get; set; }

        /// <summary>
        /// get and set RegistrationDateTime
        /// </summary>
        public DateTime RegistrationDateTime { get; set; }

        /// <summary>
        /// get and set FactoryCode
        /// </summary>
        public string FactoryCode { get; set; }

        /// <summary>
        /// store AffectedCount
        /// </summary>
        public int AffectedCount { get; set; }
        public int HienThi { get; set; }
        public string TenHienThi { get; set; }

        public int CheckRow { get; set; }

        /// <summary>
        /// list of RankVo
        /// </summary>
        public List<FunctionDeptVo> FunctionDeptListVo = new List<FunctionDeptVo>();

    }
}
