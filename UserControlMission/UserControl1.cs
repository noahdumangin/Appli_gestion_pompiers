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
using Microsoft.VisualBasic;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp;
using PdfSharp.Fonts;
using System.Diagnostics;


namespace UserControlMissions
{
    public partial class UserControlMission: UserControl
    {
        private string res;
        private string nature;
        private DataSet ds;
        private int indexMission;
        private SQLiteConnection Connexion;

        public UserControlMission()
        {
            InitializeComponent();
            
        }
        
        public UserControlMission(DataSet ds,int i, SQLiteConnection connec)
        {
            Font LargeFont = new Font("Arial", 12);
            this.ds = ds;
            this.Connexion = connec;
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
            lblID.Font = LargeFont;
            lblDate.Text += ds.Tables["Mission"].Rows[i][1].ToString();
            lblDate.ForeColor = Color.Black;
            lblDate.Font = LargeFont;
            lblCaserne.Text += res;
            lblCaserne.ForeColor = Color.Black;
            lblCaserne.Font = LargeFont;
            lblType.Text += nature;
            lblType.ForeColor = Color.Black;
            lblType.Font = LargeFont;
            lblResum.Text += ds.Tables["Mission"].Rows[i][3].ToString();
            lblResum.ForeColor = Color.Black;
            lblResum.Font = LargeFont;



            if (nature == "Assistance non urgente")
            {
                pctType.Image = Image.FromFile("sirene.gif");

            } else
            {
                pctType.Image = Image.FromFile("fond-gif.gif");
            }
            pctType.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPDF.Image = Image.FromFile("pdf.png");
            pctPDF.Cursor = Cursors.Hand;
            pctPDF.SizeMode = PictureBoxSizeMode.StretchImage;
            pctRes.Image = Image.FromFile("check.png");
            pctRes.Cursor = Cursors.Hand;
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

        private void pctRes_Click(object sender, EventArgs e)
        {          
            if (ds.Tables["Mission"].Select($"id = {(indexMission + 1)} AND terminee = 0").Length > 0)
            {
                // Demander un compte rendu et un s'il y a des réparations à faire avant de faire l'update
                string compteRendu = Interaction.InputBox("Entrez le compte rendu de la mission :", "Compte Rendu");
                string reparations = Interaction.InputBox("Entrez les réparations à faire (laisser vide s'il n'y en a pas) :", "Réparations");
                string dateFin = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Date de fin de la mission
                                                                               //requete pour cloturer la mission

                string requete = $"UPDATE Mission SET dateHeureRetour = '{dateFin}', compteRendu = '{compteRendu}',terminee=1 WHERE id = {(indexMission + 1)}";
                DataRow[] rows = ds.Tables["Mission"].Select($"id = {(indexMission + 1)}");
                if (rows.Length > 0) // Recherche de la ligne à mettre à jour dans la table "Mission"
                {
                    DataRow row = rows[0];
                    row["dateHeureRetour"] = dateFin;
                    row["compteRendu"] = compteRendu;
                    row["terminee"] = 1;
                }
                try
                {
                    string sql = "select codeTypeEngin, numeroEngin , idCaserne from PartirAvec p where idMission =" + (indexMission + 1);
                    SQLiteCommand cmdd = new SQLiteCommand(sql, Connexion);
                    SQLiteDataReader rd = cmdd.ExecuteReader();
                    while (rd.Read())
                    {
                        string update = @"Update Engin Set EnMission = 0 where  idCaserne = " + int.Parse(rd[2].ToString()) + " AND  codeTypeEngin = '" + rd[0].ToString() + "' AND numero = " + int.Parse(rd[1].ToString());
                        MessageBox.Show(update);
                        SQLiteCommand commande = new SQLiteCommand(update, Connexion);
                        commande.ExecuteNonQuery();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                try
                {
                    string sql = @"Select matriculePompier 
                                  From Mobiliser 
                                  Where idMission = '" + ds.Tables["Mission"].Rows[indexMission][0].ToString() + "'";
                    SQLiteCommand cmdd = new SQLiteCommand(sql, Connexion);
                    SQLiteDataReader rd = cmdd.ExecuteReader();
                    while (rd.Read())
                    {
                        string update = @"Update Pompier Set EnMission = 0 where matricule = " + int.Parse(rd[0].ToString()) ;
                        SQLiteCommand commande = new SQLiteCommand(update, Connexion);
                        commande.ExecuteNonQuery();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                // Synchronisation avec la base de données

                //var adapter = new SQLiteDataAdapter("SELECT * FROM Mission", Connexion);
                //var builder = new SQLiteCommandBuilder(adapter);
                //adapter.Update(ds, "Mission");
                //SQLiteCommand cmd = new SQLiteCommand(requete, Connexion);
                //cmd.ExecuteNonQuery(); // Exécuter la requête
            }
            else
            {
                MessageBox.Show("La mission est déjà terminée.");
            }
        }

        private void pctPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(indexMission.ToString());
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Rapport de mission";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fontTitre = new XFont("Arial", 14, XFontStyle.Bold);
            XFont fontNormal = new XFont("Arial", 10, XFontStyle.Regular);
            XFont fontGras = new XFont("Arial", 10, XFontStyle.Bold);

            double y = 40;

            void Write(string text, XFont font, double indent = 40)
            {
                gfx.DrawString(text, font, XBrushes.Black, new XRect(indent, y, page.Width, page.Height), XStringFormats.TopLeft);
                y += 20;
            }

            Write("Rapport de mission", fontTitre, 40);
            Write("Déclenchée le " + ds.Tables["Mission"].Rows[indexMission][1].ToString(), fontNormal);
            Write("Retour le " + ds.Tables["Mission"].Rows[indexMission][2].ToString(), fontNormal);
            y += 10;
            gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y);
            y += 10;

            Write("Type de sinistre : "+ nature, fontGras);
            Write("Motif : "+ ds.Tables["Mission"].Rows[indexMission][3].ToString(), fontNormal);
            Write("Adresse : " + ds.Tables["Mission"].Rows[indexMission][4].ToString() + " " + ds.Tables["Mission"].Rows[indexMission][5].ToString() + " " + ds.Tables["Mission"].Rows[indexMission][6].ToString(), fontNormal);
            if (!ds.Tables["Mission"].Rows[indexMission][8].Equals(null))
            {
                Write("Compte-rendu :" + ds.Tables["Mission"].Rows[indexMission][8].ToString(), fontNormal);
            }
            else
            {
                Write("Compte-rendu : Le compte-rendu est vide " , fontNormal);

            }
            y += 10;
            gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y);
            y += 10;

            Write("Caserne : "+ res, fontGras);
            Write("Pompiers affectés :", fontGras);
            try
            {
                string chaine = @"Select matriculePompier ,(Select libelle from Habilitation where id =  m.idHabilitation)
                                  From Mobiliser m 
                                  Where idMission ='" + ds.Tables["Mission"].Rows[indexMission][0].ToString() + "'";

                SQLiteCommand cmd = new SQLiteCommand(chaine, Connexion);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    int matricule = int.Parse(rd[0].ToString());
                    string chaine2 = @"Select nom , prenom ,(Select libelle From Grade where code = p.codeGrade) from Pompier p where matricule =" + matricule;

                    SQLiteCommand sql = new SQLiteCommand(chaine2, Connexion);
                    SQLiteDataReader rdd = sql.ExecuteReader();
                    while (rdd.Read())
                    {
                        Write("--> " + rdd[2].ToString() + " " + rdd[1].ToString() + " " + rdd[0].ToString() + " (" + rd[1].ToString() + ")", fontNormal);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            y += 20;
            Write("Engins utilisés :", fontGras);
            
            try
            {
                string chaine = @"select (Select nom from TypeEngin where code = p.codeTypeEngin), numeroEngin, reparationsEventuelles , codeTypeEngin from PartirAvec p where idMission = " + (indexMission + 1);

                SQLiteCommand cmd = new SQLiteCommand(chaine, Connexion);
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (!rd[2].Equals(null))
                    {
                        Write("--> " + rd[0].ToString() + " " + (indexMission + 1) + "-" + rd[3].ToString()+ "-" + rd[1].ToString() + " (pas de réparations prévues)", fontNormal);

                    } else
                    {
                        Write("--> " + rd[0].ToString() + " " + (indexMission + 1) + "-" + rd[3].ToString() + "-"+ rd[1].ToString() + "(" + rd[2].ToString() +")", fontNormal);
                    }

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            document.Save("RapportMission.pdf");
            Process.Start("RapportMission.pdf");
        }
    }
}
    
    
