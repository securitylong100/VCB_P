using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class VTTranferVo : ValueObject
    {


        public int TranferMachineId { get; set; }
        public string CodeName { get; set; }
        public string FactoryBefore { get; set; }
        public string FactoryAfter { get; set; }
        public string MachineSerial { get; set; }
        public string ReasonTrafer { get; set; }
        public string StatusMachine { get; set; }
        public string AttachPart { get; set; }
        public string CommentF { get; set; }

        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string FactoryCode { get; set; }
        public int AffectedCount { get; set; }
        public List<VTTranferVo> WarehouseMainVo = new List<VTTranferVo>();
    }
}