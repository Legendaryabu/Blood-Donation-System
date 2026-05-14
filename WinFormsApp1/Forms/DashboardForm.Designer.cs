namespace BloodBankApp.Forms
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAvailableUnits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPendingRequests = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLowInventory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvPendingRequests = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBloodInventory = new System.Windows.Forms.Button();
            this.btnManageDonors = new System.Windows.Forms.Button();
            this.btnIssueBlood = new System.Windows.Forms.Button();
            this.btnRecordDonation = new System.Windows.Forms.Button();
            this.lblWatermark = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRequests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAvailableUnits);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblAvailableUnits
            // 
            this.lblAvailableUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableUnits.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblAvailableUnits.Location = new System.Drawing.Point(3, 37);
            this.lblAvailableUnits.Name = "lblAvailableUnits";
            this.lblAvailableUnits.Size = new System.Drawing.Size(214, 45);
            this.lblAvailableUnits.TabIndex = 1;
            this.lblAvailableUnits.Text = "0";
            this.lblAvailableUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Blood Units";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblPendingRequests);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(270, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblPendingRequests
            // 
            this.lblPendingRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingRequests.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lblPendingRequests.Location = new System.Drawing.Point(3, 37);
            this.lblPendingRequests.Name = "lblPendingRequests";
            this.lblPendingRequests.Size = new System.Drawing.Size(214, 45);
            this.lblPendingRequests.TabIndex = 1;
            this.lblPendingRequests.Text = "0";
            this.lblPendingRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pending Requests";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblLowInventory);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(512, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblLowInventory
            // 
            this.lblLowInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLowInventory.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLowInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblLowInventory.Location = new System.Drawing.Point(3, 37);
            this.lblLowInventory.Name = "lblLowInventory";
            this.lblLowInventory.Size = new System.Drawing.Size(214, 45);
            this.lblLowInventory.TabIndex = 1;
            this.lblLowInventory.Text = "0";
            this.lblLowInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Low Inventory Groups";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvPendingRequests);
            this.groupBox1.Location = new System.Drawing.Point(28, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Pending Requests";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnRefresh.Location = new System.Drawing.Point(614, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvPendingRequests
            // 
            this.dgvPendingRequests.AllowUserToAddRows = false;
            this.dgvPendingRequests.AllowUserToDeleteRows = false;
            this.dgvPendingRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPendingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPendingRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendingRequests.ColumnHeadersHeight = 30;
            this.dgvPendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(219)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendingRequests.EnableHeadersVisualStyles = false;
            this.dgvPendingRequests.Location = new System.Drawing.Point(15, 51);
            this.dgvPendingRequests.MultiSelect = false;
            this.dgvPendingRequests.Name = "dgvPendingRequests";
            this.dgvPendingRequests.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPendingRequests.RowHeadersVisible = false;
            this.dgvPendingRequests.RowTemplate.Height = 25;
            this.dgvPendingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingRequests.Size = new System.Drawing.Size(674, 191);
            this.dgvPendingRequests.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBloodInventory);
            this.groupBox2.Controls.Add(this.btnManageDonors);
            this.groupBox2.Controls.Add(this.btnIssueBlood);
            this.groupBox2.Controls.Add(this.btnRecordDonation);
            this.groupBox2.Location = new System.Drawing.Point(28, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quick Actions";
            // 
            // btnBloodInventory
            // 
            this.btnBloodInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnBloodInventory.FlatAppearance.BorderSize = 0;
            this.btnBloodInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBloodInventory.ForeColor = System.Drawing.Color.White;
            this.btnBloodInventory.Location = new System.Drawing.Point(524, 33);
            this.btnBloodInventory.Name = "btnBloodInventory";
            this.btnBloodInventory.Size = new System.Drawing.Size(190, 60);
            this.btnBloodInventory.TabIndex = 3;
            this.btnBloodInventory.Text = "☵ Blood Inventory";
            this.btnBloodInventory.UseVisualStyleBackColor = false;
            this.btnBloodInventory.Click += new System.EventHandler(this.btnBloodInventory_Click);
            // 
            // btnManageDonors
            // 
            this.btnManageDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnManageDonors.FlatAppearance.BorderSize = 0;
            this.btnManageDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDonors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageDonors.ForeColor = System.Drawing.Color.White;
            this.btnManageDonors.Location = new System.Drawing.Point(348, 33);
            this.btnManageDonors.Name = "btnManageDonors";
            this.btnManageDonors.Size = new System.Drawing.Size(190, 60);
            this.btnManageDonors.TabIndex = 2;
            this.btnManageDonors.Text = "☺ Manage Donors";
            this.btnManageDonors.UseVisualStyleBackColor = false;
            this.btnManageDonors.Click += new System.EventHandler(this.btnManageDonors_Click);
            // 
            // btnIssueBlood
            // 
            this.btnIssueBlood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnIssueBlood.FlatAppearance.BorderSize = 0;
            this.btnIssueBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBlood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBlood.ForeColor = System.Drawing.Color.White;
            this.btnIssueBlood.Location = new System.Drawing.Point(172, 33);
            this.btnIssueBlood.Name = "btnIssueBlood";
            this.btnIssueBlood.Size = new System.Drawing.Size(190, 60);
            this.btnIssueBlood.TabIndex = 1;
            this.btnIssueBlood.Text = "→ Issue Blood";
            this.btnIssueBlood.UseVisualStyleBackColor = false;
            this.btnIssueBlood.Click += new System.EventHandler(this.btnIssueBlood_Click);
            // 
            // btnRecordDonation
            // 
            this.btnRecordDonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRecordDonation.FlatAppearance.BorderSize = 0;
            this.btnRecordDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordDonation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecordDonation.ForeColor = System.Drawing.Color.White;
            this.btnRecordDonation.Location = new System.Drawing.Point(0, 33);
            this.btnRecordDonation.Name = "btnRecordDonation";
            this.btnRecordDonation.Size = new System.Drawing.Size(190, 60);
            this.btnRecordDonation.TabIndex = 0;
            this.btnRecordDonation.Text = "✚ Record Donation";
            this.btnRecordDonation.UseVisualStyleBackColor = false;
            this.btnRecordDonation.Click += new System.EventHandler(this.btnRecordDonation_Click);
            // 
            // lblWatermark
            // 
            this.lblWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWatermark.AutoSize = true;
            this.lblWatermark.Font = new System.Drawing.Font("Segoe UI", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWatermark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.lblWatermark.Location = new System.Drawing.Point(395, 172);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(325, 355);
            this.lblWatermark.TabIndex = 5;
            this.lblWatermark.Text = "+";
            this.lblWatermark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(760, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWatermark);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.Resize += new System.EventHandler(this.DashboardForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRequests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailableUnits;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPendingRequests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLowInventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPendingRequests;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIssueBlood;
        private System.Windows.Forms.Button btnRecordDonation;
        private System.Windows.Forms.Label lblWatermark;
        private System.Windows.Forms.Button btnBloodInventory;
        private System.Windows.Forms.Button btnManageDonors;
    }
}

