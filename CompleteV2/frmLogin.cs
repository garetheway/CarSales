using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace CarSales
{
    public partial class frmLogin : Form
    {
        SqlCeConnection cn = new SqlCeConnection("Data Source = C:\\Users\\GWAY\\Documents\\Visual Studio 2012\\Projects\\CarSales\\CarSales\\Database.sdf");
        public frmLogin()
        {
            InitializeComponent();

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            int access = this.ValidateLogin();

            if (access != 9001)
            {
                this.Hide();
                Form Main = new frmMainSection(access);
                Main.ShowDialog();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private int ValidateLogin()
        {
            try
            {
                cn.Open();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            SqlCeCommand cm = new SqlCeCommand("SELECT AccessLevel FROM tblStaff WHERE StaffID = " + this.txtUsername.Text + " AND Password = '" + this.txtPassword.Text + "'", cn);
            try
            {
                int result = ((int)cm.ExecuteScalar());
                MessageBox.Show("Authentication successful! Logging in...", "Alert!");
                cn.Close();
                return result;

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect/No Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
                return 9001;
            }
            
        }
    }
}
