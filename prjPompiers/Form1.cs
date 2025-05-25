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
                MessageBox.Show(pict.Name);
                pict.Location = new Point(x,y);
                pict.Click += new EventHandler(Afficher);
                grbList.Controls.Add(pict);
                y+= pict.Height + 50;
            }

            AjouteMission();
        }

        public void AjouteMission()
        {
            flpMission.Controls.Clear();
            int x = 6;
            int y = 100;
            for (int i = 0; i < ds.Tables["Mission"].Rows.Count; i++)
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

            // Récupérer le nom pour déterminer quel formulaire ouvrir
            string name = clickedPict.Name;

            switch (name)
             {
                 case "Tableau de bord":
                    AjouteMission();
                     break;
                 case "Nouvelle Mission":
                     new Volets2().Show();
                     break;
                 case "Gestion des engins":
                     new Volets3().Show();
                     break;
                 case "Gestion du personnel":
                     new Volet4().Show();
                     break;
                 case "Statistiques":
                     new Volets5().Show();
                     break;
                 // Ajoute autant de cas que nécessaire
                 default:
                     MessageBox.Show("Aucun formulaire associé à cette PictureBox.");
                     break;
             }
         }

        private void pctLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloturerMission(int idMission)
        {
            if (ds.Tables["Mission"].Select($"id = {idMission} AND terminee = 0").Length > 0)
            {
                // Demander un compte rendu et un s'il y a des réparations à faire avant de faire l'update
                string compteRendu = Interaction.InputBox("Entrez le compte rendu de la mission :", "Compte Rendu");
                string reparations = Interaction.InputBox("Entrez les réparations à faire (laisser vide s'il n'y en a pas) :", "Réparations");
                string dateFin = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Date de fin de la mission
                                                                               //requete pour cloturer la mission

                string requete = $"UPDATE Mission SET dateHeureRetour = '{dateFin}', compteRendu = '{compteRendu}',terminee=1 WHERE id = {idMission}";
                SQLiteConnection cx = Connexion.Connec;
                DataRow[] rows = ds.Tables["Mission"].Select($"id = {idMission}");
                if (rows.Length > 0) // Recherche de la ligne à mettre à jour dans la table "Mission"
                {
                    DataRow row = rows[0];
                    row["dateHeureRetour"] = dateFin;
                    row["compteRendu"] = compteRendu;
                    row["terminee"] = 1;
                }

                // Synchronisation avec la base de données

                var adapter = new SQLiteDataAdapter("SELECT * FROM Mission", cx);
                var builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(ds, "Mission");
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                cmd.ExecuteNonQuery(); // Exécuter la requête

                Connexion.FermerConnexion(); // Fermer la connexion
            }
            else
            {
                MessageBox.Show("La mission est déjà terminée.");
            }
        }

        private void chkEnCours_CheckedChanged_1(object sender, EventArgs e)
        {
            flpMission.Controls.Clear();
            if (chkEnCours.Checked == true)
            {
                for(int i = 0; i < ds.Tables["Mission"].Rows.Count; i++)
                {
                    int x = 6;
                    int y = 100;

                    UserControlMission mission = new UserControlMission(MesDatas.DsGlobal, i, Connexion.Connec);
                    mission.Name = "panel" + i;
                    mission.Location = new Point(x, y);
                    y += mission.Height;
                    if (mission.enMission()) {
                        continue;
                    }else
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
    }
}
