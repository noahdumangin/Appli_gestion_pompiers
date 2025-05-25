using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace prjPompiers
{
    public partial class volet5 : Form
    {
        public volet5()
        {
            InitializeComponent();
        }

        private void volet5_Load(object sender, EventArgs e)
        {
            //charger la cbo
            string req = "SELECT * FROM Caserne";
            SQLiteDataAdapter da = new SQLiteDataAdapter(req, Connexion.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo1caserne.DataSource = dt;
            cbo1caserne.DisplayMember = "nom";
            cbo1caserne.ValueMember = "id";
        }

        private void cbo1caserne_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //afficher dans le data grid view
            DataSet ds = MesDatas.DsGlobal;
            int caserne = Convert.ToInt32(cbo1caserne.SelectedValue);
            try
            {            
                string reqdgv = @"SELECT e.numero AS 'Numéro d''engin', t.nom AS 'Nom de l''engin', t.code AS 'Code de l''engin', COUNT(pa.idMission) AS 'Nombre d''utilisations', ROUND(SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24), 2) AS 'Cumul d''utilisation (en heures)'
                                          FROM Engin e
                                          LEFT JOIN PartirAvec pa ON pa.numeroEngin = e.numero AND pa.codeTypeEngin = e.codeTypeEngin
                                          LEFT JOIN Mission m ON m.id = pa.idMission
                                          JOIN TypeEngin t ON e.codeTypeEngin = t.code
                                          WHERE e.idCaserne = " +
                                          caserne +
                                        @" GROUP BY e.numero, t.nom, t.code
                                          ORDER BY ""Cumul d'utilisation (en heures)"" DESC, COUNT(pa.idMission) DESC, e.numero;";
                SQLiteCommand cmd = new SQLiteCommand(reqdgv, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv1caserne.DataSource = dt;
                dgv1caserne.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception error)
            {
               MessageBox.Show(error.Message);
            }
            
            try
            {
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
                    lblNombre.Text = "Nombre d'utilisations : " + resultUtilisation.ToString();
                }
                else
                {
                    lblNombre.Text = "Nombre d'utilisations : 0";
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
