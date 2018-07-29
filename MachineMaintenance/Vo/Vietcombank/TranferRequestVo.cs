using System;
using System.Collections.Generic;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class TranferRequestVo : ValueObject
    {
        /// <summary>
        /// get and set RankId
        /// </summary>

        public int RequestId { get; set; }
        public int RequestCode { get; set; }
        public int FunctionDeptId { get; set; }
        public DateTime RequestDateTime { get; set; }
        public string RequestHeader { get; set; }
        public string RequestContents { get; set; }
        public string ProcessStatusCheck { get; set; }
        public string ProcessComments { get; set; }

        public DateTime ProcessDateTime { get; set; }

        public string RegistrationUserCode { get; set; }

        public string FunctionDeptCode { get; set; }
        public string FunctionDeptName { get; set; }
        public string UserName { get; set; }
        public string DepartmentCode { get; set; }

        public string DepartmentName { get; set; }
        /// <summary>
        /// get and set RegistrationDateTime
        /// </summary>


        /// <summary>
        /// get and set FactoryCode
        /// </summary>
        public string FactoryCode { get; set; }

        /// <summary>
        /// store AffectedCount
        /// </summary>
        public int AffectedCount { get; set; }



        /// <summary>
        /// list of RankVo
        /// </summary>
        public List<TranferRequestVo> FunctionDeptListVo = new List<TranferRequestVo>();

    }
}
