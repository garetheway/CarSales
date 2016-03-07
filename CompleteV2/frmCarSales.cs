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
    public partial class frmCarSales : Form
    {
        int access;
        SqlCeConnection cn = new SqlCeConnection("Data Source = C:\\Users\\GWAY\\Documents\\Visual Studio 2012\\Projects\\CarSales\\CarSales\\Database.sdf");

        public frmCarSales(int val)
        {
            this.access = val;
            InitializeComponent();
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MainSection = new frmMainSection(this.access);
            MainSection.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCarSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // GO BACK
        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Main = new frmMainSection(this.access);
            Main.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCarSales_Load(object sender, EventArgs e)
        {

        }

        private void PopulateListBox()
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

            SqlCeCommand cm = new SqlCeCommand("SELECT ([Make] + '       -       ' + [Model] + '        -      ' + [Price] + '      -       ' + [Stock]) AS Info  FROM tblVehicleStock WHERE Make = '" + this.txtMake.Text + "' OR Model = '" + this.txtModel.Text + "' ORDER BY Make", cn);
            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    this.listVehicles.Items.Add(dr["Info"]);
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            this.PopulateListBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
