using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using System.Data;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class MaintenanceMachineVTVo : ValueObject
    {
        public int MainternanceId { get; set; }
        public string MachineSerial { get; set; }
        public string MachineModel { get; set; }
        public DateTime StartDay { get; set; }
        public int MonthRepeat { get; set; }
        public bool CheckStatus { get; set; }
        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string FactoryCode { get; set; }

        public string RFId { get; set; }
        public string MachineName { get; set; }
        public string MachineSupplier { get; set; }
        public string MachineLocation { get; set; }
        public string MachineStatus { get; set; }

        public int AffectedCount { get; set; }
        /// <summary>
        /// //check RFid
        /// </summary>


        public List<MaintenanceMachineVTVo> mainternancemachineVo = new List<MaintenanceMachineVTVo>();
    }
}