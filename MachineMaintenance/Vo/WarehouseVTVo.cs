using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class WarehouseVTVo : ValueObject
    {

        public int MachineId { get; set; }
        public string RFId { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public int MachineQty { get; set; }
        public string MachineSerial { get; set; }
        public string MachineModel { get; set; }
        public string MachineLocation { get; set; }

        public string MachineSupplier { get; set; }
        public string MachineInvoice { get; set; }
        public string MachineCostValue { get; set; }

        public string MachineStatus { get; set; }

        /// </summary>
        //common
        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string FactoryCode { get; set; }
        public int TimeCheck { get; set; }
        public int AffectedCount { get; set; }
        /// <summary>
        /// //check RFid
        /// </summary>
        public string CheckCountID { get; set; }
       
        public string MacLocal { get; set; }

        //add them
        public string ValueResult { get; set; }

        public List<WarehouseVTVo> WarehouseMainVo = new List<WarehouseVTVo>();
    }
}