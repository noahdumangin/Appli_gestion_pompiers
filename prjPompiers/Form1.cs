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
            pctLeave.Image = Image.FromFile("C:\\Users\\darkl\\Documents\\Cours\\pompiers\\prjPompiers\\bin\\Debug\\ExitButton.jpg");
            pctLeave.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pctLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
