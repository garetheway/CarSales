namespace CarSales
{
    partial class frmMainSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSection));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCustomerManagement = new System.Windows.Forms.Button();
            this.cmdStaffManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCarSales = new System.Windows.Forms.Button();
            this.cmdPartSales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use the menu below to navigate the system:";
            // 
            // cmdCustomerManagement
            // 
            this.cmdCustomerManagement.Location = new System.Drawing.Point(5, 31);
            this.cmdCustomerManagement.Name = "cmdCustomerManagement";
            this.cmdCustomerManagement.Size = new System.Drawing.Size(124, 23);
            this.cmdCustomerManagement.TabIndex = 1;
            this.cmdCustomerManagement.Text = "Customer Management";
            this.cmdCustomerManagement.UseVisualStyleBackColor = true;
            this.cmdCustomerManagement.Click += new System.EventHandler(this.cmdCustomerManagement_Click);
            // 
            // cmdStaffManagement
            // 
            this.cmdStaffManagement.Location = new System.Drawing.Point(5, 60);
            this.cmdStaffManagement.Name = "cmdStaffManagement";
            this.cmdStaffManagement.Size = new System.Drawing.Size(124, 23);
            this.cmdStaffManagement.TabIndex = 2;
            this.cmdStaffManagement.Text = "Staff Management";
            this.cmdStaffManagement.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Management Systems";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sales Systems";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmdCarSales
            // 
            this.cmdCarSales.Location = new System.Drawing.Point(178, 31);
            this.cmdCarSales.Name = "cmdCarSales";
            this.cmdCarSales.Size = new System.Drawing.Size(124, 23);
            this.cmdCarSales.TabIndex = 5;
            this.cmdCarSales.Text = "Car Sales";
            this.cmdCarSales.UseVisualStyleBackColor = true;
            this.cmdCarSales.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cmdPartSales
            // 
            this.cmdPartSales.Location = new System.Drawing.Point(178, 60);
            this.cmdPartSales.Name = "cmdPartSales";
            this.cmdPartSales.Size = new System.Drawing.Size(124, 23);
            this.cmdPartSales.TabIndex = 6;
            this.cmdPartSales.Text = "Part Sales";
            this.cmdPartSales.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 84);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdPartSales);
            this.panel1.Controls.Add(this.cmdCarSales);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdStaffManagement);
            this.panel1.Controls.Add(this.cmdCustomerManagement);
            this.panel1.Location = new System.Drawing.Point(11, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 93);
            this.panel1.TabIndex = 9;
            // 
            // frmMainSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainSection_FormClosed);
            this.Load += new System.EventHandler(this.MainSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCustomerManagement;
        private System.Windows.Forms.Button cmdStaffManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCarSales;
        private System.Windows.Forms.Button cmdPartSales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;

    }
}