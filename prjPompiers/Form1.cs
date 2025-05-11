using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using UserControlVolet1;
using UserControlMissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Linq.Expressions;
using System.Xml;

namespace prjPompiers
{
    public partial class Form1 : Form
    {
        private DataSet ds = MesDatas.DsGlobal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Connexion.Connec.State.ToString());

            pctFond.Image = Image.FromFile("fond-gif.gif");
            pctFond.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLeave.Image = Image.FromFile("ExitButton.png");
            pctLeave.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                string req;
                DataTable schema = Connexion.Connec.GetSchema("Tables");
                string liste = "";
                for (int i = 0; i < schema.Rows.Count; i++)
                {
                    string nomTable = schema.Rows[i][2].ToString();
                    req = "Select * from " + nomTable;
                    SQLiteCommand cmd = new SQLiteCommand(req, Connexion.Connec);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(MesDatas.DsGlobal, nomTable);
                    liste = liste + nomTable + "\n";
                }
                MessageBox.Show(liste + "\n" + ds.Tables.Count.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            List<string> list = new List<string> { "Tableau de bord", "Nouvelle Mission", "Gestion des engins", "Gestion du personnel", "Statistiques" };
            int x = 18;
            int y = 20;
            for (int i = 0; i < list.Count; i++)
            {   
                Image image = Image.FromFile("girophare.gif");
                string nom = list[i];
                Form volet = new Form();
                UserControlPanel panel = new UserControlPanel(image, nom, volet);
                panel.Name = "panel" + i;
                panel.Location = new Point(x,y);
                grbList.Controls.Add(panel);
                y+= panel.Height + 5;
            }

            x = 6;
            y = 100;
            for(int i = 0; i < ds.Tables["Mission"].Rows.Count; i++)
            {
                
                UserControlMission mission = new UserControlMission();
                mission.Name = "panel" + i;
                mission.Location = new Point(x, y);
                mission.BackgroundImage = Image.FromFile("fond-gif.gif");
                panMission.Controls.Add(mission);
                y += mission.Height ;
            }


            //vScrollBar1.Minimum = 0;
            //vScrollBar1.SmallChange = 20;
            //vScrollBar1.LargeChange = grpMission.Height ;
            //int totalContentHeight = grpMission.Controls.Cast<Control>().Sum(c => c.Height + 5); // 5 = l’espace entre les contrôles
            //vScrollBar1.Maximum = Math.Max(0, totalContentHeight - grpMission.Height);
            //foreach (Control ctrl in grpMission.Controls)
            //{
            //    ctrl.Tag = ctrl.Top; // on enregistre la position de base
            //}
        }     
        private void pctLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userControlPanel1_Load(object sender, EventArgs e)
        {
            
        }


        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    int scrollValue = vScrollBar1.Value;

        //    foreach (Control ctrl in grpMission.Controls)
        //    {
        //        ctrl.Top = ctrl.Tag is int originalTop
        //            ? originalTop - scrollValue
        //            : ctrl.Top - scrollValue; // fallback si Tag non défini
        //    }
        //}
    }
}
