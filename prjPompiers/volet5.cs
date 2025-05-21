using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPompiers
{
    public partial class volet5 : Form
    {
        public volet5()
        {
            InitializeComponent();
        }

        private void volet5_Load(object sender, EventArgs e)
        {
            //charger la cbo
            string req = "SELECT * FROM Caserne";
            SQLiteDataAdapter da = new SQLiteDataAdapter(req, Connexion.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo1caserne.DataSource = dt;
            cbo1caserne.DisplayMember = "nom";
            cbo1caserne.ValueMember = "id";
        }
    }
}
