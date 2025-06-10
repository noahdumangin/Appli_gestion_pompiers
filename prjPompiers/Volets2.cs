using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using affichage_affectations;

namespace prjPompiers
{
    public partial class Volets2 : Form
    {
        //affichage_affectation uc = new affichage_affectation();

        private DataTable dtEngins;
        private DataTable dtPompiers;
        private DataTable dtNecessiter;
        private DataTable dtEmbarquer;
        private DataTable dtTypeEngin;
        private DataTable dtPasser;
        private DataTable dtMission;
        private DataTable dtMobiliser;
        private DataTable dtPartirAvec;

        private DataTable enginsSelectionne;
        private DataTable pompiersSelectionne;
        public Volets2()
        {
            InitializeComponent();
        }

        private void Volets2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            txt_raison.Focus();
            panelEngin.AutoScroll = true;
            panelPompier.AutoScroll = true;



            pbgif1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbgif2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbgif3.SizeMode = PictureBoxSizeMode.StretchImage;

            cbo_caserne.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_sinistre.DropDownStyle = ComboBoxStyle.DropDownList;

            // Liaison locale aux tables globales
            dtEngins = MesDatas.DsGlobal.Tables["Engin"];
            dtPompiers = MesDatas.DsGlobal.Tables["Pompier"];
            dtNecessiter = MesDatas.DsGlobal.Tables["Necessiter"];
            dtEmbarquer = MesDatas.DsGlobal.Tables["Embarquer"];
            dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];
            dtPasser = MesDatas.DsGlobal.Tables["Passer"];

            // Combo sinistres
            cbo_sinistre.DataSource = MesDatas.DsGlobal.Tables["NatureSinistre"];
            cbo_sinistre.DisplayMember = "libelle";
            cbo_sinistre.ValueMember = "id";

            // Combo casernes
            cbo_caserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cbo_caserne.DisplayMember = "nom";
            cbo_caserne.ValueMember = "id";

            cbo_sinistre.SelectedIndex = -1;
            cbo_caserne.SelectedIndex = -1;

            // Numéro mission
            lbl_num_mission.Text = (MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1).ToString();
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbl_heure.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_rue.Text = "";
            txt_cp.Text = "";
            txt_ville.Text = "";
            txt_raison.Text = "";

            cbo_sinistre.SelectedIndex = -1;
            cbo_caserne.SelectedIndex = -1;
            txt_raison.Focus();
        }
        private Dictionary<string, int> ObtenirEnginsRequis(int idTypeSinistre)
        {
            //dictionnaire qui stocke le code de l'engin et le nombre nécéssaire de ceux ci
            Dictionary<string, int> engins = new Dictionary<string, int>();
            //récupération des infos nécéssaires
            foreach (DataRow ligne in dtNecessiter.Rows)
            {
                int idSinistre = Convert.ToInt32(ligne["idNatureSinistre"]);
                if (idSinistre == idTypeSinistre)
                {
                    string codeEngin = ligne["codeTypeEngin"].ToString();
                    int nombrenecessaire = Convert.ToInt32(ligne["nombre"]);
                    if (engins.ContainsKey(codeEngin))
                    {
                        engins[codeEngin] += nombrenecessaire;
                    }
                    else
                    {
                        engins.Add(codeEngin, nombrenecessaire);
                    }
                }
            }
            //retourner tous les engins nécéssaires
            return engins;
        }

        private DataTable ChoisirEngins(int idCaserne, Dictionary<string, int> enginsRequis)
        {
            List<DataRow> enginsSelectionne = new List<DataRow>(); //liste pour stocker les engins qu'on va chhoisir
            foreach (KeyValuePair<string, int> enginDemande in enginsRequis)
            {
                //on récupère les infos qu'on a besoin
                DataRow[] data = MesDatas.DsGlobal.Tables["Engin"].Select($"codeTypeEngin = '{enginDemande.Key}' AND idCaserne = {idCaserne} AND enMission = 0 AND enPanne = 0");
                enginsSelectionne.AddRange(data.Take(enginDemande.Value));
            }

            DataTable dtEnginsSelectionne = enginsSelectionne.CopyToDataTable();
            return dtEnginsSelectionne;
        }


        private DataTable ChoisirPompiers(DataTable enginsSelectionne, int idCaserne)
        {
            Dictionary<int, int[]> habilitationsrequises = new Dictionary<int, int[]>();

            foreach (DataRow engins in enginsSelectionne.Rows)
            {
                DataRow[] data = MesDatas.DsGlobal.Tables["Embarquer"].Select($"codeTypeEngin = '{engins["codeTypeEngin"]}'");
                foreach (DataRow ligne in data)
                {
                    if (habilitationsrequises.ContainsKey(Convert.ToInt32(ligne["idHabilitation"])))
                    {
                        habilitationsrequises[Convert.ToInt32(ligne["idHabilitation"])][0] += Convert.ToInt32(ligne["nombre"]);
                    }
                    else
                    {
                        habilitationsrequises.Add(Convert.ToInt32(ligne["idHabilitation"]), new int[2] { Convert.ToInt32(ligne["nombre"]), 0 });
                    }
                }
            }
            List<DataRow> habilitationsDesPompiers = new List<DataRow>();
            int nombrePompiersChoisi = 0;
            foreach (int habilitation in habilitationsrequises.Keys)
            {
                nombrePompiersChoisi += habilitationsrequises[habilitation][0];

                DataRow[] datarow = MesDatas.DsGlobal.Tables["Passer"].Select($"idHabilitation = {habilitation}");
                habilitationsDesPompiers.AddRange(datarow);
            }
            DataTable dtHabiliationsDesPompiers = habilitationsDesPompiers.CopyToDataTable();

            List<DataRow> habilitationsPompiersCaserne = new List<DataRow>();
            foreach (DataRow affectationcaserne in MesDatas.DsGlobal.Tables["Affectation"].Select($"dateFin is NULL AND idCaserne = {idCaserne}"))
            {
                DataRow[] ligne = dtHabiliationsDesPompiers.Select($"matriculePompier = {affectationcaserne["matriculePompier"]}");
                if (ligne != null)
                {
                    habilitationsPompiersCaserne.AddRange(ligne);
                }
            }
            List<DataRow> PompiersChoisis = new List<DataRow>();
            List<int> matriculesDejaSelectionne = new List<int>(); //liste des matricules déjà pris pour une mission
            foreach (DataRow pompier in habilitationsPompiersCaserne)
            {
                int matricule = Convert.ToInt32(pompier["matriculePompier"]);//recupération du matricule
                DataRow[] pompierInfos = MesDatas.DsGlobal.Tables["Pompier"].Select($"matricule = {matricule}"); //récupération des infos du pompier
                if (pompierInfos.Length == 0)
                {
                    continue;
                }
                if (Convert.ToBoolean(pompierInfos[0]["enMission"]) || Convert.ToBoolean(pompierInfos[0]["enConge"]))//si en mission ou en panne on passe au prochain
                {
                    continue;
                }
                if (!matriculesDejaSelectionne.Contains(matricule))
                {
                    //verification qu'on a encore besoin de bompier et si c'est bon ajout
                    if (habilitationsrequises[Convert.ToInt32(pompier["idHabilitation"])][1] < habilitationsrequises[Convert.ToInt32(pompier["idHabilitation"])][0])
                    {
                        habilitationsrequises[Convert.ToInt32(pompier["idHabilitation"])][1]++;
                        matriculesDejaSelectionne.Add(matricule);
                        PompiersChoisis.Add(pompier);
                    }
                }
            }
            //verification du nombre de pompiers selectionnes
            foreach (int habilitations in habilitationsrequises.Keys)
            {
                if (habilitationsrequises[habilitations][1] < habilitationsrequises[habilitations][0])
                {
                    MessageBox.Show($"Pas assez de pompiers disponibles pour l'habilitation {habilitations}");
                    return null;
                }
            }
            DataTable dtPompiersChoisis = PompiersChoisis.CopyToDataTable();
            dtPompiersChoisis.Columns.Remove("dateObtention");
            return dtPompiersChoisis;
        }

        private async void btn_mobilisation_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_ajout_mission_Click(object sender, EventArgs e)
        {
            //récupération de certaines données
            int idMission = Convert.ToInt32(lbl_num_mission.Text);
            string date = lbl_date.Text + " " + lbl_heure.Text;
            int idSinistre = Convert.ToInt32(cbo_sinistre.SelectedValue);
            int idCaserne = Convert.ToInt32(cbo_caserne.SelectedValue);

            //table Mission
            dtMission = MesDatas.DsGlobal.Tables["Mission"];

            DataRow nouvelleMission = dtMission.NewRow();
            nouvelleMission["id"] = idMission;
            nouvelleMission["dateHeureDepart"] = date;
            nouvelleMission["motifAppel"] = txt_raison.Text;
            nouvelleMission["adresse"] = txt_rue.Text;
            nouvelleMission["cp"] = txt_cp.Text;
            nouvelleMission["ville"] = txt_ville.Text;
            nouvelleMission["terminee"] = 0;
            nouvelleMission["idNatureSinistre"] = idSinistre;
            nouvelleMission["idCaserne"] = idCaserne;
            dtMission.Rows.Add(nouvelleMission);

            //table engin
            dtEngins = MesDatas.DsGlobal.Tables["Engin"];
            foreach (DataRow engin in enginsSelectionne.Rows)
            {
                DataRow[] ligne = dtEngins.Select($"numero = {engin["numero"]} AND codeTypeEngin = '{engin["codeTypeEngin"]}' AND idCaserne = {idCaserne}");
                if (ligne.Length > 0)
                {
                    ligne[0]["enMission"] = 1;
                }
            }

            //table pompier
            dtPompiers = MesDatas.DsGlobal.Tables["Pompier"];
            foreach (DataRow lignepompier in pompiersSelectionne.Rows)
            {
                string matricule = lignepompier["matriculePompier"].ToString();
                DataRow[] ligne = dtPompiers.Select($"matricule = '{matricule}'");
                if (ligne.Length > 0)
                {
                    ligne[0]["enMission"] = 1;
                }
            }

            //table PartirAvec
            dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            foreach (DataRow engin in enginsSelectionne.Rows)
            {
                DataRow newPartir = dtPartirAvec.NewRow();
                newPartir["idCaserne"] = idCaserne;
                newPartir["codeTypeEngin"] = engin["codeTypeEngin"];
                newPartir["numeroEngin"] = engin["numero"];
                newPartir["idMission"] = idMission;
                newPartir["reparationsEventuelles"] = DBNull.Value;
                dtPartirAvec.Rows.Add(newPartir);
            }

            //table mobiliser
            dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
            foreach (DataRow pompier in pompiersSelectionne.Rows)
            {
                DataRow newMobiliser = dtMobiliser.NewRow();
                newMobiliser["matriculePompier"] = pompier["matriculePompier"];
                newMobiliser["idMission"] = idMission;
                newMobiliser["idHabilitation"] = pompier["idHabilitation"];
                dtMobiliser.Rows.Add(newMobiliser);
            }
            MessageBox.Show("la mission à été crée !");
            this.Close();
        }

        private async void btn_mobilisation_Click_1(object sender, EventArgs e)
        {
            //pour pouvoir cliquer sur le bouton "simulation de mission" il faut que tout soit rempli
            if (string.IsNullOrWhiteSpace(txt_raison.Text) || string.IsNullOrWhiteSpace(txt_rue.Text) ||
                string.IsNullOrWhiteSpace(txt_cp.Text) || string.IsNullOrWhiteSpace(txt_ville.Text) ||
                cbo_sinistre.SelectedIndex == -1 || cbo_caserne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //affichage du formulaire de chargement
                loading frm = new loading();
                frm.Show();
                await Task.Delay(6000);
                frm.Close();


                int idMission = Convert.ToInt32(lbl_num_mission.Text);
                string date = lbl_date.Text + " " + lbl_heure.Text;
                int idSinistre = Convert.ToInt32(cbo_sinistre.SelectedValue);
                int idCaserne = Convert.ToInt32(cbo_caserne.SelectedValue);

                //création d'un dictionnaire pour savoir quels engins il faut pour quel type de sinistre
                Dictionary<string, int> enginsDemandes = ObtenirEnginsRequis(idSinistre);

                //vérification des engins             
                enginsSelectionne = ChoisirEngins(idCaserne, enginsDemandes);
                bool enginsok = false;
                foreach (KeyValuePair<string, int> besoin in enginsDemandes)
                {
                    string code = besoin.Key;
                    int nbRequis = besoin.Value;
                    int nbTrouves = 0;
                    foreach (DataRow ligne in enginsSelectionne.Rows)
                    {
                        string codeEngin = ligne["codeTypeEngin"].ToString();
                        if (codeEngin == code)
                        {
                            nbTrouves++;
                        }
                    }
                    if (nbTrouves < nbRequis)
                    {
                        enginsok = true;
                        break;
                    }
                }
                if (enginsok == true)
                {
                    MessageBox.Show("Mission annulée : il n'y a pas assez de véhicules dans cette caserne.");
                    return;
                }

                //vérification des pompiers

                pompiersSelectionne = ChoisirPompiers(enginsSelectionne, idCaserne);

                //engins: codeTypeEngin + Nom + numéro
                DataTable enginsAffichage = new DataTable();
                enginsAffichage.Columns.Add("codeTypeEngin");
                enginsAffichage.Columns.Add("nom");
                enginsAffichage.Columns.Add("numero");
                foreach (DataRow engin in enginsSelectionne.Rows)
                {
                    string code = engin["codeTypeEngin"].ToString(); // le type d'engin (ex: VSAV)
                    string numero = engin["numero"].ToString(); // le numéro de l'engin

                    // On cherche le nom dans la table TypeEngin grâce au code
                    DataRow[] lignesType = MesDatas.DsGlobal.Tables["TypeEngin"].Select($"code = '{code}'");

                    string nom = "Nom inconnu";
                    if (lignesType.Length > 0)
                    {
                        nom = lignesType[0]["nom"].ToString();
                    }

                    // On ajoute la ligne complète dans le nouveau DataTable
                    enginsAffichage.Rows.Add(code, nom, numero);
                }

                //pompier: matricule + nom +habilitation
                DataTable pompiersAffichage = new DataTable();
                pompiersAffichage.Columns.Add("matricule");
                pompiersAffichage.Columns.Add("nom");
                pompiersAffichage.Columns.Add("prenom");
                pompiersAffichage.Columns.Add("Habilitation");

                foreach (DataRow lignepompier in pompiersSelectionne.Rows)
                {
                    string matricule = lignepompier["matriculePompier"].ToString();
                    string idHab = lignepompier["idHabilitation"].ToString();

                    // On cherche le nom dans la table TypeEngin grâce au code
                    DataRow[] lignetablepompier = MesDatas.DsGlobal.Tables["Pompier"].Select($"matricule = '{matricule}'");

                    string nom = "Nom inconnu";
                    string prenom = "Nom inconnu";
                    if (lignetablepompier.Length > 0)
                    {
                        nom = lignetablepompier[0]["nom"].ToString();
                        prenom = lignetablepompier[0]["prenom"].ToString();
                    }

                    DataRow[] lignetableHabilitation = MesDatas.DsGlobal.Tables["Habilitation"].Select($"id = '{idHab}'");
                    string habilitation = "Nom inconnu";
                    if (lignetableHabilitation.Length > 0)
                    {
                        habilitation = lignetableHabilitation[0]["libelle"].ToString();
                    }

                    // On ajoute la ligne complète dans le nouveau DataTable
                    pompiersAffichage.Rows.Add(matricule, nom, prenom, habilitation);
                }
                this.majdonnee(enginsAffichage, pompiersAffichage);
               /*grp_equipe_choisie.Controls.Add(uc);
                uc.majdonnee(enginsAffichage, pompiersAffichage, idCaserne);*/
            }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void majdonnee(DataTable engins, DataTable pompiers)
        {
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
