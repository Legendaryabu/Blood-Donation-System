namespace BloodBankApp.Forms
{
    partial class ScreeningForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPendingUnits = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSyphilis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHCV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHBsAg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHIV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numHB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedUnit = new System.Windows.Forms.Label();
            this.btnPassUnit = new System.Windows.Forms.Button();
            this.btnFailUnit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingUnits)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvPendingUnits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Select a Unit Pending Screening (Status: \"InInventory\")";
            // 
            // dgvPendingUnits
            // 
            this.dgvPendingUnits.AllowUserToAddRows = false;
            this.dgvPendingUnits.AllowUserToDeleteRows = false;
            this.dgvPendingUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPendingUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingUnits.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendingUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendingUnits.ColumnHeadersHeight = 30;
            this.dgvPendingUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(219)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendingUnits.EnableHeadersVisualStyles = false;
            this.dgvPendingUnits.Location = new System.Drawing.Point(15, 29);
            this.dgvPendingUnits.MultiSelect = false;
            this.dgvPendingUnits.Name = "dgvPendingUnits";
            this.dgvPendingUnits.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPendingUnits.RowHeadersVisible = false;
            this.dgvPendingUnits.RowTemplate.Height = 25;
            this.dgvPendingUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingUnits.Size = new System.Drawing.Size(746, 224);
            this.dgvPendingUnits.TabIndex = 0;
            this.dgvPendingUnits.SelectionChanged += new System.EventHandler(this.dgvPendingUnits_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbSyphilis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbHCV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbHBsAg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbHIV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numHB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblSelectedUnit);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Enter Test Results";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(401, 84);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(360, 104);
            this.txtNotes.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Notes:";
            // 
            // cmbSyphilis
            // 
            this.cmbSyphilis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyphilis.FormattingEnabled = true;
            this.cmbSyphilis.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.cmbSyphilis.Location = new System.Drawing.Point(401, 51);
            this.cmbSyphilis.Name = "cmbSyphilis";
            this.cmbSyphilis.Size = new System.Drawing.Size(121, 23);
            this.cmbSyphilis.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Syphilis:";
            // 
            // cmbHCV
            // 
            this.cmbHCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHCV.FormattingEnabled = true;
            this.cmbHCV.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.cmbHCV.Location = new System.Drawing.Point(211, 126);
            this.cmbHCV.Name = "cmbHCV";
            this.cmbHCV.Size = new System.Drawing.Size(121, 23);
            this.cmbHCV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "HCV:";
            // 
            // cmbHBsAg
            // 
            this.cmbHBsAg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHBsAg.FormattingEnabled = true;
            this.cmbHBsAg.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.cmbHBsAg.Location = new System.Drawing.Point(211, 89);
            this.cmbHBsAg.Name = "cmbHBsAg";
            this.cmbHBsAg.Size = new System.Drawing.Size(121, 23);
            this.cmbHBsAg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "HBsAg:";
            // 
            // cmbHIV
            // 
            this.cmbHIV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHIV.FormattingEnabled = true;
            this.cmbHIV.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.cmbHIV.Location = new System.Drawing.Point(211, 51);
            this.cmbHIV.Name = "cmbHIV";
            this.cmbHIV.Size = new System.Drawing.Size(121, 23);
            this.cmbHIV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "HIV:";
            // 
            // numHB
            // 
            this.numHB.DecimalPlaces = 1;
            this.numHB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHB.Location = new System.Drawing.Point(52, 52);
            this.numHB.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numHB.Name = "numHB";
            this.numHB.Size = new System.Drawing.Size(84, 23);
            this.numHB.TabIndex = 2;
            this.numHB.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "HB:";
            // 
            // lblSelectedUnit
            // 
            this.lblSelectedUnit.AutoSize = true;
            this.lblSelectedUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.lblSelectedUnit.Location = new System.Drawing.Point(15, 28);
            this.lblSelectedUnit.Name = "lblSelectedUnit";
            this.lblSelectedUnit.Size = new System.Drawing.Size(109, 15);
            this.lblSelectedUnit.TabIndex = 0;
            this.lblSelectedUnit.Text = "No Unit Selected...";
            // 
            // btnPassUnit
            // 
            this.btnPassUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPassUnit.Enabled = false;
            this.btnPassUnit.FlatAppearance.BorderSize = 0;
            this.btnPassUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPassUnit.ForeColor = System.Drawing.Color.White;
            this.btnPassUnit.Location = new System.Drawing.Point(678, 501);
            this.btnPassUnit.Name = "btnPassUnit";
            this.btnPassUnit.Size = new System.Drawing.Size(110, 35);
            this.btnPassUnit.TabIndex = 2;
            this.btnPassUnit.Text = "Pass Unit";
            this.btnPassUnit.UseVisualStyleBackColor = false;
            this.btnPassUnit.Click += new System.EventHandler(this.btnPassUnit_Click);
            // 
            // btnFailUnit
            // 
            this.btnFailUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFailUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnFailUnit.Enabled = false;
            this.btnFailUnit.FlatAppearance.BorderSize = 0;
            this.btnFailUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFailUnit.ForeColor = System.Drawing.Color.White;
            this.btnFailUnit.Location = new System.Drawing.Point(562, 501);
            this.btnFailUnit.Name = "btnFailUnit";
            this.btnFailUnit.Size = new System.Drawing.Size(110, 35);
            this.btnFailUnit.TabIndex = 3;
            this.btnFailUnit.Text = "Fail Unit";
            this.btnFailUnit.UseVisualStyleBackColor = false;
            this.btnFailUnit.Click += new System.EventHandler(this.btnFailUnit_Click);
            // 
            // ScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnFailUnit);
            this.Controls.Add(this.btnPassUnit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScreeningForm";
            this.Text = "Screening & Test Results";
            this.Load += new System.EventHandler(this.ScreeningForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingUnits)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPendingUnits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelectedUnit;
        private System.Windows.Forms.NumericUpDown numHB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHBsAg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSyphilis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPassUnit;
        private System.Windows.Forms.Button btnFailUnit;
    }
}

