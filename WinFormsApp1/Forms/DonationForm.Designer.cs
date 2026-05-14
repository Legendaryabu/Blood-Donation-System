namespace BloodBankApp.Forms
{
    partial class DonationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSelectDonor = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.gbDonationDetails = new System.Windows.Forms.GroupBox();
            this.lblDonorInfo = new System.Windows.Forms.Label();
            this.btnSaveDonation = new System.Windows.Forms.Button();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDonationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSelectDonor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.gbDonationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelectDonor
            // 
            this.gbSelectDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectDonor.BackColor = System.Drawing.Color.White;
            this.gbSelectDonor.Controls.Add(this.btnSearch);
            this.gbSelectDonor.Controls.Add(this.txtSearch);
            this.gbSelectDonor.Controls.Add(this.label1);
            this.gbSelectDonor.Controls.Add(this.dgvDonors);
            this.gbSelectDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSelectDonor.Location = new System.Drawing.Point(12, 12);
            this.gbSelectDonor.Name = "gbSelectDonor";
            this.gbSelectDonor.Size = new System.Drawing.Size(776, 303);
            this.gbSelectDonor.TabIndex = 0;
            this.gbSelectDonor.TabStop = false;
            this.gbSelectDonor.Text = "Step 1: Select Donor";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnSearch.Location = new System.Drawing.Point(674, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(151, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(517, 23);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Name or ID:";
            // 
            // dgvDonors
            // 
            this.dgvDonors.AllowUserToAddRows = false;
            this.dgvDonors.AllowUserToDeleteRows = false;
            this.dgvDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonors.ColumnHeadersHeight = 30;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(219)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonors.EnableHeadersVisualStyles = false;
            this.dgvDonors.Location = new System.Drawing.Point(16, 61);
            this.dgvDonors.MultiSelect = false;
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonors.RowHeadersVisible = false;
            this.dgvDonors.RowTemplate.Height = 25;
            this.dgvDonors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonors.Size = new System.Drawing.Size(745, 226);
            this.dgvDonors.TabIndex = 0;
            this.dgvDonors.SelectionChanged += new System.EventHandler(this.dgvDonors_SelectionChanged);
            // 
            // gbDonationDetails
            // 
            this.gbDonationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDonationDetails.BackColor = System.Drawing.Color.White;
            this.gbDonationDetails.Controls.Add(this.lblDonorInfo);
            this.gbDonationDetails.Controls.Add(this.btnSaveDonation);
            this.gbDonationDetails.Controls.Add(this.cmbComponent);
            this.gbDonationDetails.Controls.Add(this.label5);
            this.gbDonationDetails.Controls.Add(this.dtpExpiryDate);
            this.gbDonationDetails.Controls.Add(this.label4);
            this.gbDonationDetails.Controls.Add(this.dtpDonationDate);
            this.gbDonationDetails.Controls.Add(this.label3);
            this.gbDonationDetails.Controls.Add(this.numVolume);
            this.gbDonationDetails.Controls.Add(this.label2);
            this.gbDonationDetails.Enabled = false;
            this.gbDonationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDonationDetails.Location = new System.Drawing.Point(12, 321);
            this.gbDonationDetails.Name = "gbDonationDetails";
            this.gbDonationDetails.Size = new System.Drawing.Size(776, 217);
            this.gbDonationDetails.TabIndex = 1;
            this.gbDonationDetails.TabStop = false;
            this.gbDonationDetails.Text = "Step 2: Record Donation";
            // 
            // lblDonorInfo
            // 
            this.lblDonorInfo.AutoSize = true;
            this.lblDonorInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDonorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lblDonorInfo.Location = new System.Drawing.Point(16, 32);
            this.lblDonorInfo.Name = "lblDonorInfo";
            this.lblDonorInfo.Size = new System.Drawing.Size(120, 15);
            this.lblDonorInfo.TabIndex = 9;
            this.lblDonorInfo.Text = "No Donor Selected...";
            // 
            // btnSaveDonation
            // 
            this.btnSaveDonation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveDonation.FlatAppearance.BorderSize = 0;
            this.btnSaveDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDonation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDonation.ForeColor = System.Drawing.Color.White;
            this.btnSaveDonation.Location = new System.Drawing.Point(630, 166);
            this.btnSaveDonation.Name = "btnSaveDonation";
            this.btnSaveDonation.Size = new System.Drawing.Size(131, 35);
            this.btnSaveDonation.TabIndex = 8;
            this.btnSaveDonation.Text = "Save Donation";
            this.btnSaveDonation.UseVisualStyleBackColor = false;
            this.btnSaveDonation.Click += new System.EventHandler(this.btnSaveDonation_Click);
            // 
            // cmbComponent
            // 
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(111, 140);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(200, 23);
            this.cmbComponent.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Component:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Enabled = false;
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(401, 102);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(126, 23);
            this.dtpExpiryDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expiry Date:";
            // 
            // dtpDonationDate
            // 
            this.dtpDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDonationDate.Location = new System.Drawing.Point(111, 102);
            this.dtpDonationDate.Name = "dtpDonationDate";
            this.dtpDonationDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDonationDate.TabIndex = 3;
            this.dtpDonationDate.ValueChanged += new System.EventHandler(this.dtpDonationDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donation Date:";
            // 
            // numVolume
            // 
            this.numVolume.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numVolume.Location = new System.Drawing.Point(111, 64);
            this.numVolume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVolume.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(120, 23);
            this.numVolume.TabIndex = 1;
            this.numVolume.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Volume (ml):";
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.gbDonationDetails);
            this.Controls.Add(this.gbSelectDonor);
            this.Name = "DonationForm";
            this.Text = "Record Donation";
            this.Load += new System.EventHandler(this.DonationForm_Load);
            this.gbSelectDonor.ResumeLayout(false);
            this.gbSelectDonor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.gbDonationDetails.ResumeLayout(false);
            this.gbDonationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectDonor;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.GroupBox gbDonationDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.DateTimePicker dtpDonationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveDonation;
        private System.Windows.Forms.Label lblDonorInfo;
    }
}

