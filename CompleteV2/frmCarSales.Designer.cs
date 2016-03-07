namespace CarSales
{
    partial class frmCarSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarSales));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listVehicles = new System.Windows.Forms.ListBox();
            this.strpStatus = new System.Windows.Forms.StatusStrip();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblMakeResult = new System.Windows.Forms.Label();
            this.lnlModelResult = new System.Windows.Forms.Label();
            this.lblPriceResult = new System.Windows.Forms.Label();
            this.lblStockResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cmdExit);
            this.splitContainer1.Panel1.Controls.Add(this.txtMake);
            this.splitContainer1.Panel1.Controls.Add(this.lblMake);
            this.splitContainer1.Panel1.Controls.Add(this.txtModel);
            this.splitContainer1.Panel1.Controls.Add(this.lblModel);
            this.splitContainer1.Panel1.Controls.Add(this.lblInstruction);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.Controls.Add(this.lblStockResult);
            this.splitContainer1.Panel2.Controls.Add(this.lblPriceResult);
            this.splitContainer1.Panel2.Controls.Add(this.lnlModelResult);
            this.splitContainer1.Panel2.Controls.Add(this.lblMakeResult);
            this.splitContainer1.Panel2.Controls.Add(this.listVehicles);
            this.splitContainer1.Size = new System.Drawing.Size(832, 504);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 11;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(3, 462);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(311, 39);
            this.cmdExit.TabIndex = 15;
            this.cmdExit.Text = "Go Back";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(88, 169);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(162, 20);
            this.txtMake.TabIndex = 14;
            this.txtMake.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(28, 169);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 13;
            this.lblMake.Text = "Make:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(88, 207);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(162, 20);
            this.txtModel.TabIndex = 12;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(28, 207);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 17);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model: ";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(16, 117);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(283, 17);
            this.lblInstruction.TabIndex = 10;
            this.lblInstruction.Text = "Please select an option to search for below:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 84);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // listVehicles
            // 
            this.listVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVehicles.FormattingEnabled = true;
            this.listVehicles.ItemHeight = 20;
            this.listVehicles.Location = new System.Drawing.Point(27, 39);
            this.listVehicles.MultiColumn = true;
            this.listVehicles.Name = "listVehicles";
            this.listVehicles.Size = new System.Drawing.Size(460, 384);
            this.listVehicles.TabIndex = 0;
            this.listVehicles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // strpStatus
            // 
            this.strpStatus.Location = new System.Drawing.Point(0, 504);
            this.strpStatus.Name = "strpStatus";
            this.strpStatus.Size = new System.Drawing.Size(832, 22);
            this.strpStatus.SizingGrip = false;
            this.strpStatus.TabIndex = 12;
            this.strpStatus.Text = "statusStrip";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(88, 245);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(162, 23);
            this.cmdSearch.TabIndex = 16;
            this.cmdSearch.Text = "Submit Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lblMakeResult
            // 
            this.lblMakeResult.AutoSize = true;
            this.lblMakeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeResult.Location = new System.Drawing.Point(34, 19);
            this.lblMakeResult.Name = "lblMakeResult";
            this.lblMakeResult.Size = new System.Drawing.Size(46, 17);
            this.lblMakeResult.TabIndex = 1;
            this.lblMakeResult.Text = "Make";
            // 
            // lnlModelResult
            // 
            this.lnlModelResult.AutoSize = true;
            this.lnlModelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlModelResult.Location = new System.Drawing.Point(128, 19);
            this.lnlModelResult.Name = "lnlModelResult";
            this.lnlModelResult.Size = new System.Drawing.Size(51, 17);
            this.lnlModelResult.TabIndex = 2;
            this.lnlModelResult.Text = "Model";
            // 
            // lblPriceResult
            // 
            this.lblPriceResult.AutoSize = true;
            this.lblPriceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceResult.Location = new System.Drawing.Point(241, 19);
            this.lblPriceResult.Name = "lblPriceResult";
            this.lblPriceResult.Size = new System.Drawing.Size(45, 17);
            this.lblPriceResult.TabIndex = 3;
            this.lblPriceResult.Text = "Price";
            // 
            // lblStockResult
            // 
            this.lblStockResult.AutoSize = true;
            this.lblStockResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockResult.Location = new System.Drawing.Point(330, 19);
            this.lblStockResult.Name = "lblStockResult";
            this.lblStockResult.Size = new System.Drawing.Size(48, 17);
            this.lblStockResult.TabIndex = 4;
            this.lblStockResult.Text = "Stock";
            // 
            // frmCarSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 526);
            this.Controls.Add(this.strpStatus);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Sales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarSales_FormClosed);
            this.Load += new System.EventHandler(this.frmCarSales_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.StatusStrip strpStatus;
        private System.Windows.Forms.ListBox listVehicles;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lnlModelResult;
        private System.Windows.Forms.Label lblMakeResult;
        private System.Windows.Forms.Label lblStockResult;
        private System.Windows.Forms.Label lblPriceResult;
    }
}

