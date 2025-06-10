using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affichagevolet5
{
    public partial class affichagevolet5: UserControl
    {
        private DataTable data;
        public affichagevolet5()
        {
            InitializeComponent();
        }

        private void affichagevolet5_Load(object sender, EventArgs e)
        {

        }
        public void majdonnee(DataTable dt)
        {
            data = dt;

            lv.FullRowSelect = true;
            lv.GridLines = true;

            lv.Columns.Clear();
            lv.Items.Clear();

            foreach (DataColumn col in data.Columns)
            {
                lv.Columns.Add(col.ColumnName, 100);
            }

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lv.Items.Add(item);
            }
            foreach (ColumnHeader col in lv.Columns)
            {
                col.Width = -2;
            }
        }
    }
}
