using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using System.Net.NetworkInformation;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common
{
    public class callmac
    {
        public string maclist = "";
        public void LoadMac()
        {

             
        string DanhSachMAC = "";

            NetworkInterface[] DanhSachCardMang = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < DanhSachCardMang.Length; i++)
            {
                PhysicalAddress DiaChiMAC = DanhSachCardMang[i].GetPhysicalAddress();
                DanhSachMAC += DanhSachCardMang[i].Name + " : ";
                byte[] ByteDiaChi = DiaChiMAC.GetAddressBytes();
                for (int j = 0; j < ByteDiaChi.Length; j++)
                {
                    DanhSachMAC += ByteDiaChi[j].ToString("X2");
                    if (j != ByteDiaChi.Length - 1)
                    {
                        DanhSachMAC += "-";
                    }
                }
                DanhSachMAC += "\r\n";
                maclist += DanhSachMAC;
            }
        }

    }
}
