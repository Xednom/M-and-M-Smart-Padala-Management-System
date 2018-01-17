using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MetroFramework;

namespace M_and_M_Smart_Padala_Management_System
{
    public partial class Login : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT * FROM login WHERE UN = @un and PW=@pw";
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pw", txt_pw.Text);

            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MetroMessageBox.Show(this, "Welcome!", "Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Main_menu mainmenu = new Main_menu();
                mainmenu.Show();
                Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong username or password", "Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cmd.Parameters.Clear();
            conn.Close();
        }
    }
}
