using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlMissions
{
    public partial class UserControlMission: UserControl
    {
        public UserControlMission()
        {
            InitializeComponent();
        }

        public UserControlMission(DataSet ds)
        {
            InitializeComponent();
            pctType.Image = Image.FromFile("");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
