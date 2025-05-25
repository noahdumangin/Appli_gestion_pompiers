using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;

namespace UserControlMissions
{
    public partial class UserControlMission: UserControl
    {
        private string res;
        private string nature;
        private DataSet ds;
        private int indexMission;

        public UserControlMission()
        {
            InitializeComponent();
            
        }
        
        public UserControlMission(DataSet ds,int i, SQLiteConnection connec)
        {
            this.ds = ds;
            this.indexMission = i;
            try
            {
                string chaine = @"Select nom 
                                  From Caserne 
                                  Where id ='" + ds.Tables["Mission"].Rows[i][10].ToString() +"'";
                
                SQLiteCommand cmd = new SQLiteCommand(chaine,connec);
                res = cmd.ExecuteScalar().ToString();

                string chaine2 = @"Select libelle
                                  From NatureSinistre
                                  Where id ='" + ds.Tables["Mission"].Rows[i][9].ToString() + "'";

                SQLiteCommand cmdd = new SQLiteCommand(chaine2, connec);
                nature = cmdd.ExecuteScalar().ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            InitializeComponent();
            lblID.Text += ds.Tables["Mission"].Rows[i][0].ToString();
            lblID.ForeColor = Color.Black;
            lblDate.Text += ds.Tables["Mission"].Rows[i][1].ToString();
            lblDate.ForeColor = Color.Black;
            lblCaserne.Text += res;
            lblCaserne.ForeColor = Color.Black;
            lblType.Text += nature;
            lblType.ForeColor = Color.Black;
            lblResum.Text += ds.Tables["Mission"].Rows[i][3].ToString();
            lblResum.ForeColor = Color.Black;
            

            if(nature == "Assistance non urgente")
            {
                pctType.Image = Image.FromFile("sirene.gif");

            } else
            {
                pctType.Image = Image.FromFile("fond-gif.gif");
            }
            pctType.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPDF.Image = Image.FromFile("pdf.png");
            pctPDF.SizeMode = PictureBoxSizeMode.StretchImage;
            pctRes.Image = Image.FromFile("image.png");
            pctRes.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public bool enMission()
        {
            return ds.Tables["Mission"].Rows[indexMission][7].ToString() == "1";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
"é"