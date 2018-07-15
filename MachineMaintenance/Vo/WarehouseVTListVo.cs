using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class WarehouseVTListVo : ValueObject
    {
        public int CheckId { get; set; } 
        public string MachineSerial { get; set; }
        public string RFId { get; set; }
        public int CheckTime { get; set; }
        /// </summary>
        //common
        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public bool ValueCheck { get; set; }

        public string Comment { get; set; }

        public string CounterRow { get; set; }

        public int DatalostId { get; set; }
        public int AffectedCount { get; set; }

        public List<WarehouseVTListVo> WarehouseMainVo = new List<WarehouseVTListVo>();
    }
}