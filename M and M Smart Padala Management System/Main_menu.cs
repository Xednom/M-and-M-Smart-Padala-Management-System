using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using MetroFramework.Forms;

namespace M_and_M_Smart_Padala_Management_System
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 50)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 220;
                PanelAnimator.ShowSync(sidemenu);
            }
            else
            {
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                PanelAnimator.ShowSync(sidemenu);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
