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
                PictureBox pict = new PictureBox();
                pict.Image = Image.FromFile("girophare.gif");
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                pict.Name = list[i];
                pict.Location = new Point(x,y);
                pict.Click += new EventHandler(Afficher);
                grbList.Controls.Add(pict);
                y+= pict.Height + 20;
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
        }    
        
        private void Afficher(object sender, EventArgs e)
        {
            Volet4 form = new Volet4();
            DialogResult dr = form.ShowDialog();

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
