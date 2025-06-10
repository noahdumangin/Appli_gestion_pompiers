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
    public partial class Volet4 : Form
    {
        private int matricule { get; set; }
        private int matriculePompier;
        public Volet4()
        {
            InitializeComponent();
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Volet4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbretour.SizeMode = PictureBoxSizeMode.StretchImage;
            rdbVolontaire.ForeColor = Color.White;
            rdbPro.ForeColor = Color.White;

            try
            {

                string req = "Select * from Caserne";
                SQLiteCommand cmdd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string nommCaserne = dt.Rows[i][1].ToString();
                    cboCaserne.Items.Add(nommCaserne);
                }
                cboPompier.Enabled = false;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
        }

        private void btninfos_Click(object sender, EventArgs e)
        {
            btninfos.Visible = false;
            grbinfos.Visible = true;
            Login lo = new Login(this);
            DialogResult dr = lo.ShowDialog();
            try
            {

                string reqc = "Select * from Caserne";
                SQLiteCommand cmdd = new SQLiteCommand(reqc, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                SQLiteDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    string nommCaserne = reader[1].ToString();
                    cbocas.Items.Add(nommCaserne);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }


            try
            {
                string reqgrade = "Select * from Grade";
                SQLiteCommand cmdd = new SQLiteCommand(reqgrade, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                SQLiteDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    string nommgrade = reader[1].ToString();
                    cbograde.Items.Add(nommgrade);

                }

            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
        }

        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboPompier.Items.Clear();
            if (cboCaserne.SelectedIndex == -1)
            {
                cboPompier.Enabled = false;
                return;
            }
            try
            {
                int nomCaserne = cboCaserne.SelectedIndex;
                cboPompier.Enabled = true;
                string reqId = "SELECT matriculePompier FROM Affectation WHERE idCaserne =" + (nomCaserne + 1);


                SQLiteCommand cmdId = new SQLiteCommand(reqId, Connexion.Connec);
                SQLiteDataReader readerId = cmdId.ExecuteReader();
                while (readerId.Read())
                {
                    string req2 = "SELECT matricule ,nom, prenom FROM Pompier where matricule =" + readerId[0].ToString();
                    SQLiteCommand cmd = new SQLiteCommand(req2, Connexion.Connec);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nomPrenom = reader[1].ToString() + " " + reader[2].ToString();
                        cboPompier.ValueMember = reader[0].ToString();
                        cboPompier.DisplayMember = nomPrenom;
                        cboPompier.Items.Add(nomPrenom);
                    }

                }


            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
        }

        private void cboPompier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                string reqp = "SELECT matricule,nom,prenom,sexe,dateEmbauche,type,bip,portable,codeGrade FROM Pompier WHERE nom||' '||prenom ='" + cboPompier.SelectedItem.ToString() + "'";

                SQLiteCommand cmdId = new SQLiteCommand(reqp, Connexion.Connec);
                SQLiteDataReader readerp = cmdId.ExecuteReader();
                string path = null;
                while (readerp.Read())
                {
                    lblNom.Text = "Nom:" + readerp[1].ToString();
                    matriculePompier = int.Parse(readerp[0].ToString());
                    lblMatricule.Text = "Matricule: " + readerp[0].ToString();
                    lblPrn.Text = "Prénom: " + readerp[2].ToString();
                    lblemboche.Text = "Date d'embauche: " + readerp[4].ToString();
                    lblsexe.Text = "Sexe: " + readerp[3].ToString();
                    lblbip.Text = "Bip: " + readerp[6].ToString();
                    lblTelep.Text = "Téléphone: " + readerp[7].ToString();
                    path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagesGrades", readerp[8].ToString() + ".png");
                    pbGrade.Image = Image.FromFile(path);
                    rdbPro.Enabled = false;
                    rdbVolontaire.Enabled = false;
                    rdbVolontaire.ForeColor = Color.White;
                    rdbPro.ForeColor = Color.White;


                    if (readerp[5].ToString() == "V")
                    {
                        rdbVolontaire.Checked = true;
                    }
                    else
                    {
                        rdbPro.Checked = true;
                    }
                }
                grbPompier.Visible = true;
                btninfos.Visible = true;

            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");

            }

            try
            {
                string reql = "SELECT (SELECT libelle from Habilitation where id = p.idHabilitation) from Passer p where matriculePompier ='" + matriculePompier + "'";
                SQLiteCommand cmdHabil = new SQLiteCommand(reql, Connexion.Connec);

                SQLiteDataReader readerHabil = cmdHabil.ExecuteReader();
                lsthabil.Items.Clear();
                while (readerHabil.Read())
                {

                    lsthabil.Items.Add(readerHabil[0].ToString());
                }

            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }


            try
            {
                string reqaff = "SELECT (SELECT nom FROM Caserne WHERE id = a.idCaserne), dateA , dateFin  FROM Affectation a WHERE matriculePompier ='" + matriculePompier + "'";
                SQLiteCommand cmdAff = new SQLiteCommand(reqaff, Connexion.Connec);

                SQLiteDataReader readerAff = cmdAff.ExecuteReader();
                lstaff.Items.Clear();
                while (readerAff.Read())
                {
                    if (!readerAff[2].Equals(null))
                    {
                        lstaff.Items.Add("De " + readerAff[1].ToString() + " à " + readerAff[2].ToString() + " dans la " + readerAff[0].ToString());
                    }
                    else
                    {
                        lstaff.Items.Add("De " + readerAff[1].ToString() + "dans la " + readerAff[0].ToString());
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
        }

        private void pbajout_Click(object sender, EventArgs e)
        {
            nouveaupompier fe = new nouveaupompier();
            DialogResult dr = fe.ShowDialog();
            if (dr == DialogResult.OK)
            {

                MessageBox.Show("Création d'un nouveau pompier : ");
            }
            else
            {
                MessageBox.Show("Opération annulée");
            }
        }
        private void pbretour_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            grbinfos.Visible = false;
            btninfos.Visible = true;
        }

        private void btnjour_Click(object sender, EventArgs e)
        {
            int cong = 0;
            if (cbconger.Checked)
            {
                cong = 1;
            }
            try
            {
                int idCaserne = -1;
                string selectedCaserne = cbocas.SelectedItem.ToString();
                string reqIdCaserne = "SELECT Id FROM Caserne WHERE Nom = @nom";
                using (var cmdId = new SQLiteCommand(reqIdCaserne, Connexion.Connec))
                {
                    cmdId.Parameters.AddWithValue("@nom", selectedCaserne);
                    object result = cmdId.ExecuteScalar();
                    if (result != null)
                        idCaserne = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Caserne non trouvée.");
                        return;
                    }
                }

                String reqgrade = null;
                string selectedGrade = cbograde.SelectedItem.ToString();
                string reqIdGrade = "SELECT code FROM Grade WHERE Libelle = @libelle";
                using (var cmdIdGrade = new SQLiteCommand(reqIdGrade, Connexion.Connec))
                {
                    cmdIdGrade.Parameters.AddWithValue("@libelle", selectedGrade);
                    object resultGrade = cmdIdGrade.ExecuteScalar();
                    if (resultGrade != null)
                        reqgrade = resultGrade.ToString();
                    else
                    {
                        MessageBox.Show("Grade non trouvé.");
                        return;
                    }
                }
                string requp = @"UPDATE Pompier set enConge =@conge,codeGrade= @grade";
                requp += " WHERE matricule = " + matriculePompier;
                using (var cmd = new SQLiteCommand(requp, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@conge", cong);
                    cmd.Parameters.AddWithValue("@grade", reqgrade);
                    cmd.ExecuteNonQuery();
                }
                string requp2 = @"UPDATE Affectation set idCaserne = " + idCaserne + " WHERE matriculePompier = " + matriculePompier;
                using (var cmd2 = new SQLiteCommand(requp2, Connexion.Connec))
                {
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Mise à jour effectuée avec succès.");
            }

            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
        }

        private void lblnewpomp_Click(object sender, EventArgs e)
        {
            nouveaupompier fe = new nouveaupompier();
            DialogResult dr = fe.ShowDialog();
            if (dr == DialogResult.OK)
            {

                MessageBox.Show("Création d'un nouveau pompier : ");
            }
            else
            {
                MessageBox.Show("Opération annulée");
            }
        }

        private void pbretour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
