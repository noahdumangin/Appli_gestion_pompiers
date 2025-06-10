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

namespace prjPompiers
{
    
    public partial class Volets3 : Form
    {
        BindingSource bs;
        DataSet ds;
        public Volets3()
        {
            InitializeComponent();
        }

        public Volets3(DataSet dataset, SQLiteConnection connec)
        {
            InitializeComponent();
            ds = dataset;
            this.bs = new BindingSource();
            bs.DataSource = ds.Tables["Engin"];

            
            pctboxVROUMVROUM.SizeMode = PictureBoxSizeMode.StretchImage;
            remplirFormulaire(0);
            gdvVROUMVROUM.DataSource = bs ;
            

        }
        private void Volets3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            this.bs.MoveLast();
            remplirFormulaire(ds.Tables["Engin"].Rows.Count - 1);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.bs.MoveNext();
            int currentIndex = gdvVROUMVROUM.CurrentCell.RowIndex;
            remplirFormulaire(currentIndex);
        }

        private void btnALLLeft_Click(object sender, EventArgs e)
        {
            this.bs.MoveFirst();
            remplirFormulaire(0);
           
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.bs.MovePrevious();
            int currentIndex = gdvVROUMVROUM.CurrentCell.RowIndex;
            remplirFormulaire(currentIndex);

        }

        public void remplirFormulaire(int currentIndex)
        {   
            lblNom.Text = "Numéro du véhicule : " + ds.Tables["Engin"].Rows[currentIndex][0].ToString() + "-" + ds.Tables["Engin"].Rows[currentIndex][1].ToString() + "-" + ds.Tables["Engin"].Rows[currentIndex][2].ToString();
            lblDate.Text = "Date de reception : " + ds.Tables["Engin"].Rows[currentIndex][3].ToString();
            if (ds.Tables["Engin"].Rows[currentIndex][4].ToString() == "1")
            {
               chkboxMission.Checked = true;
            }
            else
            {
                chkboxMission.Checked = false;

            }

            if (ds.Tables["Engin"].Rows[currentIndex][5].ToString() == "1")
            {
                chkboxPanne.Checked = true;
            }
            else
            {
                chkboxPanne.Checked = false;

            }

            switch (ds.Tables["Engin"].Rows[currentIndex][1].ToString())
            {
                case "VSAV":
                    pctboxVROUMVROUM.Image = Image.FromFile("0.gif");
                    break;
                case "FPT":
                    pctboxVROUMVROUM.Image = Image.FromFile("1.gif");
                    break;
                case "CCF":
                    pctboxVROUMVROUM.Image = Image.FromFile("2.gif");
                    break;
                case "VSS":
                    pctboxVROUMVROUM.Image = Image.FromFile("3.gif");
                    break;
                case "VPC":
                    pctboxVROUMVROUM.Image = Image.FromFile("4.gif");
                    break;
                case "VID":
                    pctboxVROUMVROUM.Image = Image.FromFile("5.gif");
                    break;
                case "VSR":
                    pctboxVROUMVROUM.Image = Image.FromFile("6.gif");
                    break;
                case "EPA":
                    pctboxVROUMVROUM.Image = Image.FromFile("7.gif");
                    break;
                case "BRS":
                    pctboxVROUMVROUM.Image = Image.FromFile("8.gif");
                    break;
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
