namespace ISAD_Asss
{
    partial class StaffForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_backToHome = new System.Windows.Forms.Button();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmBoxPosition = new System.Windows.Forms.ComboBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtStaffSalary = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelStaffSalary = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.DGV_Staff = new System.Windows.Forms.DataGridView();
            this.BTN_InsertStaff = new System.Windows.Forms.Button();
            this.BTN_UpdateStaff = new System.Windows.Forms.Button();
            this.BTN_DeleteStaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff List";
            // 
            // BTN_backToHome
            // 
            this.BTN_backToHome.BackColor = System.Drawing.Color.Orange;
            this.BTN_backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_backToHome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_backToHome.Location = new System.Drawing.Point(1045, 384);
            this.BTN_backToHome.Name = "BTN_backToHome";
            this.BTN_backToHome.Size = new System.Drawing.Size(122, 42);
            this.BTN_backToHome.TabIndex = 7;
            this.BTN_backToHome.Text = "Close";
            this.BTN_backToHome.UseVisualStyleBackColor = false;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.Location = new System.Drawing.Point(6, 26);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(397, 30);
            this.txtSearchStaff.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchStaff);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmBoxPosition);
            this.groupBox3.Controls.Add(this.dtDOB);
            this.groupBox3.Controls.Add(this.gbGender);
            this.groupBox3.Controls.Add(this.txtStaffSalary);
            this.groupBox3.Controls.Add(this.labelDOB);
            this.groupBox3.Controls.Add(this.labelStaffSalary);
            this.groupBox3.Controls.Add(this.txtStaffName);
            this.groupBox3.Controls.Add(this.labelStaffName);
            this.groupBox3.Controls.Add(this.txtStaffID);
            this.groupBox3.Controls.Add(this.labelPosition);
            this.groupBox3.Controls.Add(this.labelStaffID);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(175, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 264);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staff information";
            // 
            // cmBoxPosition
            // 
            this.cmBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxPosition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxPosition.FormattingEnabled = true;
            this.cmBoxPosition.Items.AddRange(new object[] {
            "Manager",
            "Assistant Manager",
            "Cashier",
            "Supervisor",
            "Seller",
            "Stock Controller"});
            this.cmBoxPosition.Location = new System.Drawing.Point(497, 53);
            this.cmBoxPosition.Name = "cmBoxPosition";
            this.cmBoxPosition.Size = new System.Drawing.Size(215, 32);
            this.cmBoxPosition.TabIndex = 16;
            // 
            // dtDOB
            // 
            this.dtDOB.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB.CustomFormat = "dd-MM-yyyy";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(496, 211);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(216, 27);
            this.dtDOB.TabIndex = 15;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdbFemale);
            this.gbGender.Controls.Add(this.rdbMale);
            this.gbGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(497, 100);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(215, 76);
            this.gbGender.TabIndex = 14;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(115, 32);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(86, 28);
            this.rdbFemale.TabIndex = 0;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(6, 32);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(67, 28);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // txtStaffSalary
            // 
            this.txtStaffSalary.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSalary.Location = new System.Drawing.Point(137, 211);
            this.txtStaffSalary.Name = "txtStaffSalary";
            this.txtStaffSalary.Size = new System.Drawing.Size(286, 30);
            this.txtStaffSalary.TabIndex = 11;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(493, 181);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(102, 24);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelStaffSalary
            // 
            this.labelStaffSalary.AutoSize = true;
            this.labelStaffSalary.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffSalary.Location = new System.Drawing.Point(134, 181);
            this.labelStaffSalary.Name = "labelStaffSalary";
            this.labelStaffSalary.Size = new System.Drawing.Size(56, 24);
            this.labelStaffSalary.TabIndex = 7;
            this.labelStaffSalary.Text = "Salary";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(137, 130);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(286, 30);
            this.txtStaffName.TabIndex = 12;
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.Location = new System.Drawing.Point(134, 100);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(85, 24);
            this.labelStaffName.TabIndex = 8;
            this.labelStaffName.Text = "Full Name";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(137, 55);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(286, 30);
            this.txtStaffID.TabIndex = 13;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(498, 25);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(67, 24);
            this.labelPosition.TabIndex = 9;
            this.labelPosition.Text = "Position";
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffID.Location = new System.Drawing.Point(134, 25);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(27, 24);
            this.labelStaffID.TabIndex = 10;
            this.labelStaffID.Text = "ID";
            // 
            // DGV_Staff
            // 
            this.DGV_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Staff.Location = new System.Drawing.Point(2, 443);
            this.DGV_Staff.Name = "DGV_Staff";
            this.DGV_Staff.RowHeadersWidth = 51;
            this.DGV_Staff.RowTemplate.Height = 24;
            this.DGV_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Staff.Size = new System.Drawing.Size(1198, 305);
            this.DGV_Staff.TabIndex = 6;
            // 
            // BTN_InsertStaff
            // 
            this.BTN_InsertStaff.BackColor = System.Drawing.Color.Orange;
            this.BTN_InsertStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsertStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_InsertStaff.Location = new System.Drawing.Point(628, 384);
            this.BTN_InsertStaff.Name = "BTN_InsertStaff";
            this.BTN_InsertStaff.Size = new System.Drawing.Size(122, 42);
            this.BTN_InsertStaff.TabIndex = 7;
            this.BTN_InsertStaff.Text = "Insert";
            this.BTN_InsertStaff.UseVisualStyleBackColor = false;
            this.BTN_InsertStaff.Click += new System.EventHandler(this.BTN_InsertStaff_Click);
            // 
            // BTN_UpdateStaff
            // 
            this.BTN_UpdateStaff.BackColor = System.Drawing.Color.Orange;
            this.BTN_UpdateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UpdateStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpdateStaff.Location = new System.Drawing.Point(765, 384);
            this.BTN_UpdateStaff.Name = "BTN_UpdateStaff";
            this.BTN_UpdateStaff.Size = new System.Drawing.Size(122, 42);
            this.BTN_UpdateStaff.TabIndex = 7;
            this.BTN_UpdateStaff.Text = "Update";
            this.BTN_UpdateStaff.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteStaff
            // 
            this.BTN_DeleteStaff.BackColor = System.Drawing.Color.Orange;
            this.BTN_DeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DeleteStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DeleteStaff.Location = new System.Drawing.Point(909, 384);
            this.BTN_DeleteStaff.Name = "BTN_DeleteStaff";
            this.BTN_DeleteStaff.Size = new System.Drawing.Size(122, 42);
            this.BTN_DeleteStaff.TabIndex = 7;
            this.BTN_DeleteStaff.Text = "Delete";
            this.BTN_DeleteStaff.UseVisualStyleBackColor = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 747);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_backToHome);
            this.Controls.Add(this.BTN_DeleteStaff);
            this.Controls.Add(this.BTN_UpdateStaff);
            this.Controls.Add(this.BTN_InsertStaff);
            this.Controls.Add(this.DGV_Staff);
            this.Controls.Add(this.panel1);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_backToHome;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmBoxPosition;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtStaffSalary;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelStaffSalary;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.DataGridView DGV_Staff;
        private System.Windows.Forms.Button BTN_InsertStaff;
        private System.Windows.Forms.Button BTN_UpdateStaff;
        private System.Windows.Forms.Button BTN_DeleteStaff;
    }
}