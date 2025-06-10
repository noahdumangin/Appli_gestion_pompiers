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
    public partial class Login : Form
    {
        public Volet4 parent;
        public Login(Volet4 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pbZ.SizeMode = PictureBoxSizeMode.StretchImage;
            parent.grbinfos.Visible = false;
            parent.btninfos.Visible = true;

        }

        private void btnanul_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            parent.grbinfos.Visible = false; 
            parent.btninfos.Visible = true;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            try
            {
                string req = "SELECT * FROM Admin WHERE login = @login AND mdp = @mdp";
                SQLiteCommand cmd = new SQLiteCommand(req, Connexion.Connec);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@mdp", txtmdp.Text);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Si les identifiants sont corrects, on ferme la fenêtre de connexion
                    this.DialogResult = DialogResult.OK;
                    parent.grbinfos.Visible = true; 
                }
                else
                {
                    // Si les identifiants sont incorrects, on affiche un message d'erreur
                    MessageBox.Show("Identifiants incorrects, veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtmdp.Clear();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Erreur lors de la connexion à la base de données : {err.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
