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

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common
{
    public class csvclass
    {
        public void exportcsv(ref DataGridViewCommon dgv, string link, string filename)
        {
            try
            {
                //StreamWriter sw = new StreamWriter(link + @"\" + filename + ".csv" ,false);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text File|*.txt";
                dialog.FileName = link + @"\" + filename + ".csv";
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                StringBuilder builder = new StringBuilder();
                int rowcount = dgv.Rows.Count;
                int columncount = dgv.Columns.Count;

                for (int i = 0; i < rowcount; i++)
                {
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount - 1; j++)
                    {
                        cols.Add(dgv.Rows[i].Cells[j].Value.ToString() + @",");
                    }
                    builder.AppendLine(string.Join("\t", cols.ToArray()));
                }
                System.IO.File.WriteAllText(dialog.FileName, builder.ToString());
                MessageBox.Show("Save ok. Filename: "+ link +@"\"+filename+".csv");
            }
            catch
            {
                MessageBox.Show("ERROR. Please create folder " + link + " to save as...");
                return;

            }
        }
    }
}
