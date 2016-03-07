namespace CarSales
{
    partial class frmCustomerManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            this.strpStatus = new System.Windows.Forms.StatusStrip();
            this.Container = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabPage_1 = new System.Windows.Forms.TabPage();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.tabPage_2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strpStatus
            // 
            this.strpStatus.Location = new System.Drawing.Point(0, 504);
            this.strpStatus.Name = "strpStatus";
            this.strpStatus.Size = new System.Drawing.Size(832, 22);
            this.strpStatus.SizingGrip = false;
            this.strpStatus.TabIndex = 0;
            this.strpStatus.Text = "statusStrip";
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.Controls.Add(this.pictureBox1);
            this.Container.Panel1.Controls.Add(this.cmdNew);
            this.Container.Panel1.Controls.Add(this.cmdDelete);
            this.Container.Panel1.Controls.Add(this.cmdExit);
            this.Container.Panel1.Controls.Add(this.cmdSave);
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.Controls.Add(this.tabCustomer);
            this.Container.Size = new System.Drawing.Size(832, 504);
            this.Container.SplitterDistance = 318;
            this.Container.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 84);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(3, 97);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(311, 39);
            this.cmdNew.TabIndex = 4;
            this.cmdNew.Text = "New Customer";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(3, 142);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(311, 39);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Delete Customer";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(3, 462);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(311, 39);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Go Back";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(3, 187);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(311, 39);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.tabPage_1);
            this.tabCustomer.Controls.Add(this.tabPage_2);
            this.tabCustomer.Location = new System.Drawing.Point(3, 3);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(495, 498);
            this.tabCustomer.TabIndex = 3;
            // 
            // tabPage_1
            // 
            this.tabPage_1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage_1.Controls.Add(this.txtPhone);
            this.tabPage_1.Controls.Add(this.txtEmail);
            this.tabPage_1.Controls.Add(this.lblEmail);
            this.tabPage_1.Controls.Add(this.lblErrors);
            this.tabPage_1.Controls.Add(this.lblPhone);
            this.tabPage_1.Controls.Add(this.txtAddress);
            this.tabPage_1.Controls.Add(this.txtLastName);
            this.tabPage_1.Controls.Add(this.txtFirstName);
            this.tabPage_1.Controls.Add(this.lblAddress);
            this.tabPage_1.Controls.Add(this.lblSurname);
            this.tabPage_1.Controls.Add(this.lblFirstName);
            this.tabPage_1.Controls.Add(this.cmbCustomer);
            this.tabPage_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_1.Name = "tabPage_1";
            this.tabPage_1.Size = new System.Drawing.Size(487, 472);
            this.tabPage_1.TabIndex = 0;
            this.tabPage_1.Text = "Customer Details";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(84, 204);
            this.txtPhone.Mask = "00000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(4, 456);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(37, 206);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 96);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "";
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(84, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(26, 76);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(352, 3);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(132, 21);
            this.cmbCustomer.Sorted = true;
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.Text = "Choose Customer...";
            // 
            // tabPage_2
            // 
            this.tabPage_2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_2.Name = "tabPage_2";
            this.tabPage_2.Size = new System.Drawing.Size(487, 472);
            this.tabPage_2.TabIndex = 1;
            this.tabPage_2.Text = "Customer Vehicles";
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 526);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.strpStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomerManagement_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            this.Container.Panel1.ResumeLayout(false);
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip strpStatus;
        private System.Windows.Forms.SplitContainer Container;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabPage_1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TabPage tabPage_2;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

