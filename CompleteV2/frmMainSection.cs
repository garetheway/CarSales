using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarSales
{
    public partial class frmMainSection : Form
    {
        int access;
        public frmMainSection(int val)
        {
            InitializeComponent();
            this.access = val;
            this.SetAccess(val);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Car = new frmCarSales(this.access);
            Car.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Login = new frmLogin();
            Login.ShowDialog();
        }

        private void cmdCustomerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CustomerManagement = new frmCustomerManagement(this.access);
            CustomerManagement.ShowDialog();
        }

        private void MainSection_Load(object sender, EventArgs e)
        {

        }

        private void MainSection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SetAccess(int access)
        {
            if (access == 0)                                // Access level 0, all disabled
            {
                this.cmdCarSales.Enabled = false;
                this.cmdCustomerManagement.Enabled = false;
                this.cmdPartSales.Enabled = false;
                this.cmdStaffManagement.Enabled = false;
            }

            if (access == 1)                                 // Access level 1, all enabled
            {
                this.cmdCarSales.Enabled = true;
                this.cmdCustomerManagement.Enabled = true;
                this.cmdPartSales.Enabled = true;
                this.cmdStaffManagement.Enabled = true;
            }

            if (access == 2)                                    // Access level 2, customer management
            {
                this.cmdCarSales.Enabled = false;
                this.cmdCustomerManagement.Enabled = true;
                this.cmdPartSales.Enabled = false;
                this.cmdStaffManagement.Enabled = false;
            }

            if (access == 3)                                    // Access level 3, car sales
            {
                this.cmdCarSales.Enabled = true;
                this.cmdCustomerManagement.Enabled = false;
                this.cmdPartSales.Enabled = false;
                this.cmdStaffManagement.Enabled = false;
            }

            if (access == 4)                                    // Access level 4, part sales
            {
                this.cmdCarSales.Enabled = false;
                this.cmdCustomerManagement.Enabled = false;
                this.cmdPartSales.Enabled = true;
                this.cmdStaffManagement.Enabled = false;
            }

            if (access == 5)                                    // Access level 5, staff management
            {
                this.cmdCarSales.Enabled = false;
                this.cmdCustomerManagement.Enabled = false;
                this.cmdPartSales.Enabled = false;
                this.cmdStaffManagement.Enabled = true;
            }
        }
        
    }

}
