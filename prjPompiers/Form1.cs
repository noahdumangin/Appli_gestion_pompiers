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
using UserControlVolet1;

namespace prjPompiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Connexion.Connec.State.ToString());

            pctFond.Image = Image.FromFile("C:\\Users\\darkl\\Documents\\Cours\\pompiers\\prjPompiers\\bin\\Debug\\fond-gif.gif");
            pctFond.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLeave.Image = Image.FromFile("C:\\Users\\darkl\\Documents\\Cours\\pompiers\\prjPompiers\\bin\\Debug\\ExitButton.png");
            pctLeave.SizeMode = PictureBoxSizeMode.StretchImage;

            List<string> list = new List<string> { "Tableau de bord", "Nouvelle Mission", "Gestion des engins", "Gestion du personnel", "Statistiques" };
            int x = 18;
            int y = 20;
            for (int i = 0; i < list.Count; i++)
            {   
                Image image = Image.FromFile("C:\\Users\\darkl\\Documents\\Cours\\pompiers\\prjPompiers\\bin\\Debug\\girophare.gif");
                string nom = list[i];
                Volet4 volet4 = new Volet4();
                UserControlPanel panel = new UserControlPanel(image, nom, volet4);
                panel.Name = "panel" + i;
                panel.BackgroundImage = Image.FromFile("C:\\Users\\darkl\\Documents\\Cours\\pompiers\\prjPompiers\\bin\\Debug\\fond-gif.gif");
                panel.Location = new Point(x,y);
                grbList.Controls.Add(panel);
                y+= panel.Height + 5;
            }

        }     
        private void pctLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userControlPanel1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
