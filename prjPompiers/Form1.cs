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
using UserControlMissions;
using System.Reflection;
using Microsoft.VisualBasic;



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
            this.WindowState = FormWindowState.Maximized;

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
                Label label = new Label();
                label.Text = list[i].ToString();
                label.Location = new Point(x + 90, y + 20);
                label.ForeColor = Color.Black;
                label.Font = new Font("Arial", 15);
                label.Size = new Size(200, 50);
                pict.Image = Image.FromFile("girophare.gif");
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                pict.Name = list[i];
                pict.Cursor = Cursors.Hand;
                pict.Size = new Size(80, 60);
                pict.Location = new Point(x, y);
                pict.Click += new EventHandler(Afficher);
                grbList.Controls.Add(pict);
                grbList.Controls.Add(label);
                y += pict.Height + 50;
            }

            AjouteMission();
        }

        public void AjouteMission()
        {
            flpMission.Controls.Clear();
            int x = 6;
            int y = 100;
            for (int i = ds.Tables["Mission"].Rows.Count - 1; i >= 0; i--)
            {
                UserControlMission mission = new UserControlMission(MesDatas.DsGlobal, i, Connexion.Connec);
                mission.Name = "panel" + i;
                mission.Location = new Point(x, y);
                flpMission.Controls.Add(mission);
                y += mission.Height;
            }
        }
        private void Afficher(object sender, EventArgs e)
        {
            PictureBox clickedPict = sender as PictureBox;
            if (clickedPict == null) return;

            string name = clickedPict.Name;

            switch (name)
            {
                case "Tableau de bord":
                    AjouteMission();
                    break;
                case "Nouvelle Mission":
                    new Volets2().ShowDialog();
                    break;
                case "Gestion des engins":
                    new Volets3(MesDatas.DsGlobal, Connexion.Connec).ShowDialog();
                    break;
                case "Gestion du personnel":
                    new Volet4().ShowDialog();
                    break;
                case "Statistiques":
                    new Volets5().ShowDialog();
                    break;
                default:
                    MessageBox.Show("Aucun formulaire associé à cette PictureBox.");
                    break;
            }
        }

        private void pctLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkEnCours_CheckedChanged_1(object sender, EventArgs e)
        {
            flpMission.Controls.Clear();
            if (chkEnCours.Checked == true)
            {
                for (int i = 0; i < ds.Tables["Mission"].Rows.Count; i++)
                {
                    int x = 6;
                    int y = 100;

                    UserControlMission mission = new UserControlMission(MesDatas.DsGlobal, i, Connexion.Connec);
                    mission.Name = "panel" + i;
                    mission.Location = new Point(x, y);
                    y += mission.Height;
                    if (mission.enMission())
                    {
                        continue;
                    }
                    else
                    {
                        flpMission.Controls.Add(mission);
                    }
                }
            }
            else

            {
                AjouteMission();

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}