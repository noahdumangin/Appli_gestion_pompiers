using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlVolet1
{
    public partial class UserControlPanel : UserControl
    {

        public UserControlPanel()
        {
            InitializeComponent();
        }
        public UserControlPanel(Image image, string nom,Form volet)
        {
            InitializeComponent();

            lbInfo.Text = nom;
            lbInfo.ForeColor = Color.Black;
            pctLogo.Image = image;
            pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void pctLogo_Click(object sender, EventArgs e)
        {
            Form volet = new Form();
            DialogResult dr = volet.ShowDialog();


        }
    }
}
