using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogicUtilits;
using System.Windows.Forms;

namespace FormsUtils
{
    public class DGVUtils
    {
        public static List<Tablets> DGVToTabletsList(DataGridView dgv)
        {
            List<Tablets> tablets = new List<Tablets>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string name = row.Cells["InputDGVName"].Value.ToString();
                int memory = (int)Convert.ChangeType(row.Cells["InputGDVAmountOfMemory"].Value, typeof(int));
                int raiting = (int)Convert.ChangeType(row.Cells["InputGDVRaiting"].Value, typeof(int));
                int coast = (int)Convert.ChangeType(row.Cells["InputGDVCount"].Value, typeof(int));
                Tablets tablet = new Tablets { Model = name, AmoutOfMemory = memory, Raiting = raiting, Coast = coast };
                tablets.Add(tablet);
            }

            return tablets;
        }

        public static List<Tablets> OutDGVToTabletsList(DataGridView dgv)
        {
            List<Tablets> tablets = new List<Tablets>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string name = row.Cells["OutputGDVName"].Value.ToString();
                int memory = (int)Convert.ChangeType(row.Cells["OutputGDVAmmountOfMemory"].Value, typeof(int));
                int raiting = (int)Convert.ChangeType(row.Cells["OutputGDVRaiting"].Value, typeof(int));
                int coast = (int)Convert.ChangeType(row.Cells["OutputGDVCount"].Value, typeof(int));
                Tablets tablet = new Tablets { Model = name, AmoutOfMemory = memory, Raiting = raiting, Coast = coast };
                tablets.Add(tablet);
            }

            return tablets;
        }

        public static void TabletsListToInputDGV(DataGridView dgv, List<Tablets> tablets)
        {
            dgv.Rows.Clear();

            foreach (Tablets tablet in tablets)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["InputDGVName"].Value = tablet.Model;
                lastRow.Cells["InputGDVAmountOfMemory"].Value = tablet.AmoutOfMemory;
                lastRow.Cells["InputGDVRaiting"].Value = tablet.Raiting;
                lastRow.Cells["InputGDVCount"].Value = tablet.Coast;
            }
        }

        public static void TabletsListToOutputDGV(DataGridView dgv, List<Tablets> tablets)
        {
            dgv.Rows.Clear();

            foreach (Tablets tablet in tablets)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["OutputGDVName"].Value = tablet.Model;
                lastRow.Cells["OutputGDVAmmountOfMemory"].Value = tablet.AmoutOfMemory;
                lastRow.Cells["OutputGDVRaiting"].Value = tablet.Raiting;
                lastRow.Cells["OutputGDVCount"].Value = tablet.Coast;
            }
        }
    }
}
