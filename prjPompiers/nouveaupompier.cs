using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPompiers
{
    public partial class nouveaupompier : Form
    {
        public nouveaupompier()
        {
            InitializeComponent();
           
        }
       
        private void nouveaupompier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxphoto.SizeMode = PictureBoxSizeMode.StretchImage;
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

                    cbocaserne.Items.Add(nommCaserne);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }

            try
            {
                string reqgrade = "Select code from Grade";
                SQLiteCommand cmdd = new SQLiteCommand(reqgrade, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdd);
                SQLiteDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    string nommgrade = reader[0].ToString();
                    cboGrade.Items.Add(nommgrade);
                    
                }
                
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {err.Message}");
            }
           
            try
            {
                string req = "SELECT Libelle FROM Habilitation";
                SQLiteCommand cmd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();
                clbHabil.Items.Clear(); // Nettoyer les anciennes données

                while (reader.Read())
                {
                    string libelle = reader["Libelle"].ToString();
                    if (!clbHabil.Items.Contains(libelle))
                    {
                        clbHabil.Items.Add(libelle);
                    }
                }

                reader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des habilitations : {ex.Message}");
            }

        }

        private void txtmatricule_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar))
             {
                e.Handled = false;
            }
        }

        private void txtprn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnanul_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtBip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if  (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtprn.Text) || string.IsNullOrWhiteSpace(txttel.Text) || string.IsNullOrWhiteSpace(txtBip.Text) || cbocaserne.SelectedItem == null || cboGrade.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }
            int idCaserne = -1;
            string selectedCaserne = cbocaserne.SelectedItem.ToString();
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
            int nouveauMatricule = 1;
            string reqMatricule = "SELECT MAX(matricule) FROM Pompier";
            using (SQLiteCommand cmdMatricule = new SQLiteCommand(reqMatricule, Connexion.Connec))
            {
                object result = cmdMatricule.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nouveauMatricule = Convert.ToInt32(result) + 1;
                }
            }

            // Insertion du pompier
            string insertQuery = @"INSERT INTO Pompier
        (matricule, nom, prenom, sexe, type, portable, bip, codeGrade, dateNaissance, dateEmbauche,enMission,enConge)
        VALUES
        (@Matricule, @Nom, @Prenom, @Sexe, @Type, @Tel, @Bip, @Grade, @DateNaissance, @DateEmbauche,@mission,@conge)";

            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, Connexion.Connec))
            {
                insertCmd.Parameters.AddWithValue("@Matricule", nouveauMatricule);
                insertCmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                insertCmd.Parameters.AddWithValue("@Prenom", txtprn.Text);
                insertCmd.Parameters.AddWithValue("@Sexe", txtsexe.Text);
                insertCmd.Parameters.AddWithValue("@Type", txttype.Text);
                insertCmd.Parameters.AddWithValue("@Tel", txttel.Text);
                insertCmd.Parameters.AddWithValue("@Bip", txtBip.Text);
                insertCmd.Parameters.AddWithValue("@Grade", cboGrade.SelectedItem.ToString());
                insertCmd.Parameters.AddWithValue("@DateNaissance", dtpnaissance.Value.Date);
                insertCmd.Parameters.AddWithValue("@DateEmbauche", dtpenboche.Value.Date);
                insertCmd.Parameters.AddWithValue("@mission", 0); 
                insertCmd.Parameters.AddWithValue("@conge", 0);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    string insertAFF = "INSERT INTO Affectation (matriculePompier, idCaserne,dateFin) VALUES (@matricule, @idCaserne,NULL)";
                    using (SQLiteCommand insertAffCmd = new SQLiteCommand(insertAFF, Connexion.Connec))
                    {
                        insertAffCmd.Parameters.AddWithValue("@matricule", nouveauMatricule);
                        insertAffCmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                        insertAffCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Le pompier a bien été ajouté !");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Erreur lors de l'insertion : {ex.Message}");
                    return;
                }
            }
            try
            {
                foreach (var item in clbHabil.CheckedItems)
                {
                    string libelle = item.ToString();

                    // Récupération de l'id de l'habilitation à partir du libellé
                    string reqHab = "SELECT id FROM Habilitation WHERE libelle = @libelle";
                    using (SQLiteCommand cmdHab = new SQLiteCommand(reqHab, Connexion.Connec))
                    {
                        cmdHab.Parameters.AddWithValue("@libelle", libelle);
                        object result = cmdHab.ExecuteScalar();

                        if (result != null)
                        {
                            int idHabilitation = Convert.ToInt32(result);

                            // Insertion dans la table Passer
                            string insertPasser = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) VALUES (@matricule, @idHabilitation, @dateObtention)";
                            using (SQLiteCommand insertPasserCmd = new SQLiteCommand(insertPasser, Connexion.Connec))
                            {
                                insertPasserCmd.Parameters.AddWithValue("@matricule", nouveauMatricule);
                                insertPasserCmd.Parameters.AddWithValue("@idHabilitation", idHabilitation);
                                insertPasserCmd.Parameters.AddWithValue("@dateObtention", DateTime.Now.ToString("yyyy-MM-dd"));
                                insertPasserCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Habilitations ajoutées avec succès !");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout des habilitations : {ex.Message}");
            }
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

            string path = null;
            path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagesGrades", cboGrade.SelectedItem.ToString() + ".png");
            pibgrade.Image = Image.FromFile(path);
        }

        private void txtsexe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //faire en sorte qu'on puisse écrire qu'une seule lettre en minuscule pour le sexe
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) && e.KeyChar.ToString().Length == 1 && (e.KeyChar == 'm' || e.KeyChar == 'f'))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Veuillez entrer 'm' pour masculin ou 'f' pour féminin.");
            }

        }

        private void txttype_KeyPress(object sender, KeyPressEventArgs e)
        {
            //faire en sorte que l'on puisse limiter la saisie à une lettre soit p soit v en minuscule
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) && e.KeyChar.ToString().Length == 1 && (e.KeyChar == 'p' || e.KeyChar == 'v'))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Veuillez entrer 'p' pour pompier ou 'v' pour volontaire.");
            }
        }
    }
}
