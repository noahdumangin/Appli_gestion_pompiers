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
using affichage;


namespace prjPompiers
{
    public partial class Volets5 : Form
    {
        //affichage des usercontrols
        private DataTable data;
        public Volets5()
        {
            InitializeComponent();
        }

        private void Volets5_Load(object sender, EventArgs e)
        {
            pbgif.SizeMode = PictureBoxSizeMode.StretchImage;
            pbgif2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WindowState = FormWindowState.Maximized;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            lblPlusutilise.Visible = false;
            panel1.AutoScroll = true;
            panel2.AutoScroll = true;


            //charger la cbo pour choisir la caserne
            string req = "SELECT * FROM Caserne";
            SQLiteDataAdapter da = new SQLiteDataAdapter(req, Connexion.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo1caserne.DataSource = dt;
            cbo1caserne.DisplayMember = "nom";
            cbo1caserne.ValueMember = "id";
            cbo1caserne.DropDownStyle = ComboBoxStyle.DropDownList;

            //charger la cbo pour l'ensemble des casernes

            Dictionary<int, string> choix = new Dictionary<int, string>
            {
                { 1, "Nombre d'interventions par sinistre" },
                { 2, "Habilitations les plus sollicitées" },
                { 3, "Pompier par habilitation" }
            };

            cboPartie2.DataSource = new BindingSource(choix, null);
            cboPartie2.DisplayMember = "Value";
            cboPartie2.ValueMember = "Key";
            cboPartie2.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbo1caserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet ds = MesDatas.DsGlobal;
            int caserne = Convert.ToInt32(cbo1caserne.SelectedValue);
            try
            {
                string reqdgv = @"SELECT e.numero AS 'N° d''engin', t.nom AS 'Nom de l''engin', t.code AS 'Code d''engin', COUNT(pa.idMission) AS 'Nombre d''utilisations', ROUND(SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24), 2) AS 'utilisation (en heures)'
                                          FROM Engin e
                                          LEFT JOIN PartirAvec pa ON pa.numeroEngin = e.numero AND pa.codeTypeEngin = e.codeTypeEngin
                                          LEFT JOIN Mission m ON m.id = pa.idMission
                                          JOIN TypeEngin t ON e.codeTypeEngin = t.code
                                          WHERE e.idCaserne = " +
                                          caserne +
                                        @" GROUP BY e.numero, t.nom, t.code
                                          ORDER BY ""utilisation (en heures)"" DESC, COUNT(pa.idMission) DESC, e.numero;";
                SQLiteCommand cmd = new SQLiteCommand(reqdgv, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                this.majdonnee1(dt);
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                lblPlusutilise.Visible = true;
                lblEngin.Location = new Point(lblPlusutilise.Location.X + lblPlusutilise.Width + 2, lblPlusutilise.Location.Y);
                lblEngin.Font = new Font(lblEngin.Font.FontFamily, 15);


                //afficher l'engin le plus utilisé
                string reqPlusUtilise = @"SELECT t.nom
                                            FROM Engin e
                                            JOIN TypeEngin t ON e.codeTypeEngin = t.code
                                            JOIN PartirAvec pa ON pa.numeroEngin = e.numero AND pa.codeTypeEngin = e.codeTypeEngin
                                            WHERE e.idCaserne = @idCaserne
                                            GROUP BY e.numero, t.nom
                                            ORDER BY COUNT(pa.idMission) DESC
                                            LIMIT 1;";

                SQLiteCommand cmdPlusUtilise = new SQLiteCommand(reqPlusUtilise, Connexion.Connec);
                cmdPlusUtilise.Parameters.AddWithValue("@idCaserne", caserne);

                object result = cmdPlusUtilise.ExecuteScalar();
                if (result != null)
                {
                    lblEngin.Text = result.ToString();
                }
                else
                {
                    lblEngin.Text = "Aucun engin utilisé";
                }

                //afficher le nombre d'utilisations

                string reqNbUtilisations = @"SELECT COUNT(pa.idMission)
                                            FROM Engin e
                                            JOIN PartirAvec pa ON pa.numeroEngin = e.numero AND pa.codeTypeEngin = e.codeTypeEngin
                                            JOIN TypeEngin t ON t.code = e.codeTypeEngin
                                            WHERE e.idCaserne = @idCaserne
                                            GROUP BY e.numero, t.nom, t.code
                                            ORDER BY COUNT(pa.idMission) DESC
                                            LIMIT 1;";

                SQLiteCommand cmdNbUtilisations = new SQLiteCommand(reqNbUtilisations, Connexion.Connec);
                cmdNbUtilisations.Parameters.AddWithValue("@idCaserne", caserne);
                object resultUtilisation = cmdNbUtilisations.ExecuteScalar();
                if (resultUtilisation != null)
                {
                    lblNombre.Text = "Nombre d'utilisations :   " + resultUtilisation.ToString();
                }
                else
                {
                    lblNombre.Text = "Nombre d'utilisations :   0";
                }
                lblNombre.Location = new Point(lblPlusutilise.Location.X, lblPlusutilise.Location.Y + lblPlusutilise.Height + 20);
                lblNombre.Font = new Font(lblNombre.Font.FontFamily, 15);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cboPartie2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = MesDatas.DsGlobal;
                int choix = (int)((KeyValuePair<int, string>)cboPartie2.SelectedItem).Key;

                AfficherDansListView(choix);
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }
        private void AfficherDansListView(int choix)
        {
            try
            {
                if (choix == 1)
                {
                    string reqdgv = @"SELECT s.libelle AS ""Type de sinistre"", COUNT(m.id) AS ""Nombre d'interventions""
                                    FROM NatureSinistre s
                                    LEFT JOIN Mission m ON m.idNatureSinistre = s.id
                                    GROUP BY s.libelle
                                    ORDER BY COUNT(m.id) DESC;";
                    SQLiteCommand cmd = new SQLiteCommand(reqdgv, Connexion.Connec);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.majdonnee2(dt);
                    
                }
                else if (choix == 2)
                {
                    string reqdgv = @"SELECT h.libelle, COUNT(m.id) AS ""nombre de sollicitations""
                                    FROM Habilitation h
                                    LEFT JOIN Embarquer e ON h.id = e.idHabilitation
                                    LEFT JOIN Necessiter n ON e.codeTypeEngin = n.codeTypeEngin
                                    LEFT JOIN Mission m ON n.idNatureSinistre = m.idNatureSinistre
                                    GROUP BY h.id
                                    ORDER BY COUNT(m.id) DESC;";
                    SQLiteCommand cmd = new SQLiteCommand(reqdgv, Connexion.Connec);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.majdonnee2(dt);
                }
                else if (choix == 3)
                {

                    // création du label
                    Label lblHabilitations = new Label();
                    lblHabilitations.Name = "lblHabilitations";
                    lblHabilitations.Text = "Choisissez l'habilitation :";
                    lblHabilitations.Font = new Font("Microsoft Sans Serif", 15F);
                    lblHabilitations.AutoSize = true;
                    lblHabilitations.Location = new Point(296 + cboPartie2.Width + 80, 35);
                    grpEnsembleCaserne.Controls.Add(lblHabilitations);

                    // création de la combobox
                    ComboBox cboHabilitations = new ComboBox();
                    cboHabilitations.Name = "cboHabilitations";
                    cboHabilitations.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboHabilitations.Font = new Font("Microsoft Sans Serif", 15F);
                    cboHabilitations.Location = new Point(lblHabilitations.Right + 10, 35);
                    cboHabilitations.DropDownStyle = ComboBoxStyle.DropDownList;
                    grpEnsembleCaserne.Controls.Add(cboHabilitations);


                    //remplissage de la combobox
                    string reqHabilitations = "SELECT * FROM Habilitation";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(reqHabilitations, Connexion.Connec);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboHabilitations.DataSource = dt;
                    cboHabilitations.DisplayMember = "libelle";
                    cboHabilitations.ValueMember = "id";

                    //ajuste la taille de la combobox
                    int maxWidth = 0;
                    using (Graphics g = cboHabilitations.CreateGraphics())
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string text = row["libelle"].ToString();
                            int width = TextRenderer.MeasureText(text, cboHabilitations.Font).Width;
                            if (width > maxWidth) maxWidth = width;
                        }
                    }
                    cboHabilitations.Width = maxWidth + 30;

                    cboHabilitations.SelectionChangeCommitted += cboHabilitations_SelectionChangeCommitted;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboHabilitations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // afficher dans le DataGridView
            ComboBox cbo = (ComboBox)sender;
            int habilitation = Convert.ToInt32(cbo.SelectedValue);

            string reqdgv = @"SELECT h.libelle AS Habilitation, p.nom || ' ' || p.prenom AS Pompier
                                    FROM Habilitation h
                                    LEFT JOIN Passer a ON a.idHabilitation = h.id
                                    LEFT JOIN Pompier p ON p.matricule = a.matriculePompier
                                    WHERE h.id = " + habilitation + @" 
                                    ORDER BY h.libelle, p.nom;";

            SQLiteCommand cmd = new SQLiteCommand(reqdgv, Connexion.Connec);
            SQLiteDataAdapter dadapt = new SQLiteDataAdapter(cmd);

            DataTable dtable = new DataTable();
            dadapt.Fill(dtable);
            this.majdonnee2(dtable);

            // Vérifie si aucun pompier
            bool aucunPompier = true;
            foreach (DataRow row in dtable.Rows)
            {
                if (!string.IsNullOrEmpty(row["Pompier"]?.ToString()))
                {
                    aucunPompier = false;
                    break;
                }
            }

            if (dtable.Rows.Count == 0 || aucunPompier)
            {
                MessageBox.Show("Aucun pompier trouvé pour cette habilitation.");
            }
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void majdonnee1(DataTable table)
        {
            panel1.Controls.Clear(); // Nettoyer le panel avant d'ajouter les nouvelles données

            int y = 20; // Position verticale de départ

            foreach (DataRow ligne in table.Rows)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                // Construire dynamiquement le texte à afficher
                string texteAffichage = string.Join(" - ", ligne.ItemArray.Select(item => item.ToString()));

                lbl.Text = texteAffichage;
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Location = new Point(10, y);

                panel1.Controls.Add(lbl);
                y += 30;
            }

        }
        public void majdonnee2(DataTable table)
        {
            panel2.Controls.Clear(); // Nettoyer le panel avant d'ajouter les nouvelles données

            int y = 20; // Position verticale de départ

            foreach (DataRow ligne in table.Rows)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                // Construire dynamiquement le texte à afficher
                string texteAffichage = string.Join(" - ", ligne.ItemArray.Select(item => item.ToString()));

                lbl.Text = texteAffichage;
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Location = new Point(10, y);

                panel2.Controls.Add(lbl);
                y += 30;
            }

        }
    }
}

