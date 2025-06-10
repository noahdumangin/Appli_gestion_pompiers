using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affectationvolet2
{
    public partial class affichage_affectation: UserControl
    {
        public affichage_affectation()
        {
            InitializeComponent();
        }

        private void affectation_mission_Load(object sender, EventArgs e)
        {

        }
        public void majdonnee(DataTable engins, DataTable pompiers, int idcaserne)
        {
            lblCaserne.Text = $"Caserne {idcaserne} :";
            panelEngin.Controls.Clear();
            panelPompier.Controls.Clear();

            int y = 20;

            // Afficher les engins dans grpboxEngin
            foreach (DataRow ligne in engins.Rows)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                string code = ligne["codeTypeEngin"].ToString();
                string nom = ligne["nom"].ToString();
                string numero = "n°" + ligne["numero"].ToString();

                lbl.Text = $"{code}    ·    {nom}    ·    {numero}";
                lbl.Font = new Font("Microsoft Sans Serif", 15);
                lbl.Location = new Point(10, y);

                panelEngin.Controls.Add(lbl);
                y += 30;
            }

            // Afficher les pompiers dans grpboxPompier
            y = 20;
            foreach (DataRow ligne in pompiers.Rows)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                string matricule = ligne["matricule"].ToString();
                string nom = ligne["nom"].ToString();
                string prenom = ligne["prenom"].ToString();
                string habilitation = ligne["Habilitation"].ToString();

                lbl.Text = $"{matricule}    ·    {nom} {prenom}    ·    {habilitation}";
                lbl.Font = new Font("Microsoft Sans Serif", 15);
                lbl.Location = new Point(10, y);

                panelPompier.Controls.Add(lbl);
                y += 30;
            }
        }

    }
}
