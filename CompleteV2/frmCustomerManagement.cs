using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlServerCe;

namespace CarSales
{
    public partial class frmCustomerManagement : Form
    {
        // REGEX VALIDATION FOR EMAIL
        Regex emailRegex = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        int access;
        SqlCeConnection cn = new SqlCeConnection("Data Source = C:\\Users\\GWAY\\Documents\\Visual Studio 2012\\Projects\\CarSales\\CarSales\\Database.sdf");

        public frmCustomerManagement(int val)
        {
            InitializeComponent();
            this.access = val;
        }

        // ON FORM LOAD
        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }


        // GET AND LOSE FOCUS ON COMBO BOX
        private void cmbCustomer_Enter(object sender, EventArgs e)
        {
            this.cmbCustomer.Text = "";
        }

        private void cmbCustomer_Leave(object sender, EventArgs e)
        {
            this.cmbCustomer.Text = "Choose Customer...";
        }

        // BUTTON FUNCTIONS

      

        // SAVE CHANGES MADE
        private void cmdSave_Click(object sender, EventArgs e)
        {
            // Check for NULLs
            if (checkFields())
            {

            }
        }

        // DELETE CUSTOMER
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (this.cmbCustomer.SelectedItem == null)
            {
                this.lblErrors.Text = errorCheck(1);
            }
            else
            {
                this.lblErrors.Text = "";
            }


            // DELETE
        }

        // GO BACK
        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Main = new frmMainSection(this.access);
            Main.ShowDialog();
        }

        // ADD CUSTOMER

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // END OF BUTTON FUNCTIONS
     
        // END OF FUNCTIONS FOR LOCKING AND UNLOCKING FIELDS

        // ERROR LOOKUP FUNCTION
        private string errorCheck(int error)
        {
            if (error == 1)                          // Error #1, no customer selected for deletion
            {
                return "Error #" + error + ": No Customer is selected, please select one";
            }

            if (error == 2)                          // Error #2, missing input fields
            {
                return "Error #" + error + ": All fields are required, enter all data";
            }

            if (error == 3)                         // Error #3, invalid email
            {
                return "Error #" + error + ": Invalid Email or Missing Fields, please check input";
            }

            return "";
        }

        // CLEAR TEXT FIELDS
        void clearFields()
        {
            this.txtAddress.Text = "";
            this.txtEmail.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtPhone.Text = "";
            this.cmbCustomer.SelectedItem = null;
        }

        // FIELD VALIDATION
        bool checkFields()
        {
            if (this.txtAddress.Text == "")
            {
                this.lblErrors.Text = errorCheck(2);
                return false;
            }

            if (this.txtPhone.Text == "")
            {
                this.lblErrors.Text = errorCheck(2);
                return false;
            }

            if (this.txtFirstName.Text == "")
            {
                this.lblErrors.Text = errorCheck(2);
                return false;
            }

            if (this.txtLastName.Text == "")
            {
                this.lblErrors.Text = errorCheck(2);
                return false;
            }

            if (this.txtEmail.Text == "")
            {
                this.lblErrors.Text = errorCheck(2);
                return false;
            }

            // Email Validation
            if (emailRegex.IsMatch(txtEmail.Text))
            {

            }
            else
            {
                this.lblErrors.Text = errorCheck(3);
                return false;
            }

            return true;
        }

        private void frmCustomerManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PopulateComboBox()
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

            SqlCeCommand cm = new SqlCeCommand("SELECT ([FirstName] + ' ' + [LastName]) AS FullName FROM tblCustomer ORDER BY [FirstName]", cn);
            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    this.cmbCustomer.Items.Add(dr["FullName"]);
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
