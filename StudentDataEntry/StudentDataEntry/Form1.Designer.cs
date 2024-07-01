namespace StudentDataEntry
{
    partial class stuForm
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
            this.grpBoxEntry = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBttnMale = new System.Windows.Forms.RadioButton();
            this.cbBoxShift = new System.Windows.Forms.ComboBox();
            this.labelShift = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.labelAddr = new System.Windows.Forms.Label();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttInsert = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.cbBoxCourse = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.grpBoxView = new System.Windows.Forms.GroupBox();
            this.grboxFilter = new System.Windows.Forms.GroupBox();
            this.cbBoxCourseFilter = new System.Windows.Forms.ComboBox();
            this.cbBoxShiftFilter = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.grpBoxEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxView.SuspendLayout();
            this.grboxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxEntry
            // 
            this.grpBoxEntry.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxEntry.Controls.Add(this.pictureBox1);
            this.grpBoxEntry.Controls.Add(this.radioBtnFemale);
            this.grpBoxEntry.Controls.Add(this.radioBttnMale);
            this.grpBoxEntry.Controls.Add(this.cbBoxShift);
            this.grpBoxEntry.Controls.Add(this.labelShift);
            this.grpBoxEntry.Controls.Add(this.txtAddres);
            this.grpBoxEntry.Controls.Add(this.bttDelete);
            this.grpBoxEntry.Controls.Add(this.bttUpdate);
            this.grpBoxEntry.Controls.Add(this.labelAddr);
            this.grpBoxEntry.Controls.Add(this.bttClear);
            this.grpBoxEntry.Controls.Add(this.bttInsert);
            this.grpBoxEntry.Controls.Add(this.txtPhone);
            this.grpBoxEntry.Controls.Add(this.labelPhone);
            this.grpBoxEntry.Controls.Add(this.labelCourse);
            this.grpBoxEntry.Controls.Add(this.txtName);
            this.grpBoxEntry.Controls.Add(this.txtID);
            this.grpBoxEntry.Controls.Add(this.labelGender);
            this.grpBoxEntry.Controls.Add(this.labelName);
            this.grpBoxEntry.Controls.Add(this.labelID);
            this.grpBoxEntry.Controls.Add(this.cbBoxCourse);
            this.grpBoxEntry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBoxEntry.Location = new System.Drawing.Point(62, 50);
            this.grpBoxEntry.Name = "grpBoxEntry";
            this.grpBoxEntry.Size = new System.Drawing.Size(1079, 301);
            this.grpBoxEntry.TabIndex = 0;
            this.grpBoxEntry.TabStop = false;
            this.grpBoxEntry.Text = "Data Entry";
            this.grpBoxEntry.Enter += new System.EventHandler(this.grpBoxEntry_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(898, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(537, 161);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(74, 20);
            this.radioBtnFemale.TabIndex = 20;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            this.radioBtnFemale.CheckedChanged += new System.EventHandler(this.radioBtnFemale_CheckedChanged);
            // 
            // radioBttnMale
            // 
            this.radioBttnMale.AutoSize = true;
            this.radioBttnMale.Location = new System.Drawing.Point(422, 163);
            this.radioBttnMale.Name = "radioBttnMale";
            this.radioBttnMale.Size = new System.Drawing.Size(58, 20);
            this.radioBttnMale.TabIndex = 19;
            this.radioBttnMale.TabStop = true;
            this.radioBttnMale.Text = "Male";
            this.radioBttnMale.UseVisualStyleBackColor = true;
            this.radioBttnMale.CheckedChanged += new System.EventHandler(this.radioBttnMale_CheckedChanged);
            // 
            // cbBoxShift
            // 
            this.cbBoxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxShift.FormattingEnabled = true;
            this.cbBoxShift.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Night"});
            this.cbBoxShift.Location = new System.Drawing.Point(675, 156);
            this.cbBoxShift.Name = "cbBoxShift";
            this.cbBoxShift.Size = new System.Drawing.Size(195, 28);
            this.cbBoxShift.TabIndex = 18;
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShift.Location = new System.Drawing.Point(676, 123);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(43, 20);
            this.labelShift.TabIndex = 17;
            this.labelShift.Text = "Shift";
            // 
            // txtAddres
            // 
            this.txtAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddres.Location = new System.Drawing.Point(422, 81);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(218, 27);
            this.txtAddres.TabIndex = 16;
            // 
            // bttDelete
            // 
            this.bttDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.ForeColor = System.Drawing.Color.Black;
            this.bttDelete.Location = new System.Drawing.Point(234, 224);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(93, 41);
            this.bttDelete.TabIndex = 14;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            this.bttDelete.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttDelete.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUpdate.ForeColor = System.Drawing.Color.Black;
            this.bttUpdate.Location = new System.Drawing.Point(404, 225);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(93, 41);
            this.bttUpdate.TabIndex = 13;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            this.bttUpdate.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttUpdate.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddr.Location = new System.Drawing.Point(419, 51);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(155, 20);
            this.labelAddr.TabIndex = 15;
            this.labelAddr.Text = "Address(Short text)";
            // 
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.Red;
            this.bttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear.Location = new System.Drawing.Point(586, 225);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(98, 42);
            this.bttClear.TabIndex = 12;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // bttInsert
            // 
            this.bttInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInsert.Location = new System.Drawing.Point(62, 224);
            this.bttInsert.Name = "bttInsert";
            this.bttInsert.Size = new System.Drawing.Size(98, 42);
            this.bttInsert.TabIndex = 11;
            this.bttInsert.Text = "Insert";
            this.bttInsert.UseVisualStyleBackColor = false;
            this.bttInsert.Click += new System.EventHandler(this.bttInsert_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(126, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(251, 27);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(45, 160);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 20);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(671, 48);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(63, 20);
            this.labelCourse.TabIndex = 6;
            this.labelCourse.Text = "Course";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 27);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(126, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(251, 27);
            this.txtID.TabIndex = 4;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(419, 128);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 20);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(44, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(44, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // cbBoxCourse
            // 
            this.cbBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxCourse.FormattingEnabled = true;
            this.cbBoxCourse.Items.AddRange(new object[] {
            "C/C++",
            "C#",
            "Java",
            "Network",
            "Python",
            "HTML",
            "PHP"});
            this.cbBoxCourse.Location = new System.Drawing.Point(675, 81);
            this.cbBoxCourse.Name = "cbBoxCourse";
            this.cbBoxCourse.Size = new System.Drawing.Size(195, 28);
            this.cbBoxCourse.TabIndex = 0;
            this.cbBoxCourse.SelectedIndexChanged += new System.EventHandler(this.cbBoxCourse_Selete);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(460, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(388, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // bttSearch
            // 
            this.bttSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSearch.ForeColor = System.Drawing.Color.Black;
            this.bttSearch.Location = new System.Drawing.Point(854, 60);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(90, 26);
            this.bttSearch.TabIndex = 15;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // grpBoxView
            // 
            this.grpBoxView.Controls.Add(this.grboxFilter);
            this.grpBoxView.Controls.Add(this.txtSearch);
            this.grpBoxView.Controls.Add(this.dgvStudent);
            this.grpBoxView.Controls.Add(this.bttSearch);
            this.grpBoxView.Location = new System.Drawing.Point(62, 357);
            this.grpBoxView.Name = "grpBoxView";
            this.grpBoxView.Size = new System.Drawing.Size(1079, 402);
            this.grpBoxView.TabIndex = 1;
            this.grpBoxView.TabStop = false;
            this.grpBoxView.Text = "View Data";
            // 
            // grboxFilter
            // 
            this.grboxFilter.Controls.Add(this.cbBoxCourseFilter);
            this.grboxFilter.Controls.Add(this.cbBoxShiftFilter);
            this.grboxFilter.Location = new System.Drawing.Point(19, 36);
            this.grboxFilter.Name = "grboxFilter";
            this.grboxFilter.Size = new System.Drawing.Size(291, 63);
            this.grboxFilter.TabIndex = 18;
            this.grboxFilter.TabStop = false;
            this.grboxFilter.Text = "Filter by Course and Shift";
            // 
            // cbBoxCourseFilter
            // 
            this.cbBoxCourseFilter.FormattingEnabled = true;
            this.cbBoxCourseFilter.Items.AddRange(new object[] {
            "All",
            "C/C++",
            "C#",
            "Java",
            "Network",
            "Python",
            "HTML",
            "PHP"});
            this.cbBoxCourseFilter.Location = new System.Drawing.Point(134, 26);
            this.cbBoxCourseFilter.Name = "cbBoxCourseFilter";
            this.cbBoxCourseFilter.Size = new System.Drawing.Size(151, 24);
            this.cbBoxCourseFilter.TabIndex = 18;
            this.cbBoxCourseFilter.Text = "All";
            this.cbBoxCourseFilter.SelectedIndexChanged += new System.EventHandler(this.cbBoxCourseFilter_SelectedIndexChanged);
            // 
            // cbBoxShiftFilter
            // 
            this.cbBoxShiftFilter.FormattingEnabled = true;
            this.cbBoxShiftFilter.Items.AddRange(new object[] {
            "All",
            "Morning",
            "Evening",
            "Night"});
            this.cbBoxShiftFilter.Location = new System.Drawing.Point(6, 26);
            this.cbBoxShiftFilter.Name = "cbBoxShiftFilter";
            this.cbBoxShiftFilter.Size = new System.Drawing.Size(113, 24);
            this.cbBoxShiftFilter.TabIndex = 17;
            this.cbBoxShiftFilter.Text = "All";
            this.cbBoxShiftFilter.SelectedIndexChanged += new System.EventHandler(this.cbBoxShiftFilter_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(25, 117);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1021, 279);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellEnter);
            // 
            // stuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 814);
            this.Controls.Add(this.grpBoxView);
            this.Controls.Add(this.grpBoxEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "stuForm";
            this.Text = "Student Data Entry";
            this.Load += new System.EventHandler(this.stuForm_Load);
            this.grpBoxEntry.ResumeLayout(false);
            this.grpBoxEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxView.ResumeLayout(false);
            this.grpBoxView.PerformLayout();
            this.grboxFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEntry;
        private System.Windows.Forms.ComboBox cbBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttInsert;
        private System.Windows.Forms.GroupBox grpBoxView;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.ComboBox cbBoxShift;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBttnMale;
        private System.Windows.Forms.ComboBox cbBoxShiftFilter;
        private System.Windows.Forms.GroupBox grboxFilter;
        private System.Windows.Forms.ComboBox cbBoxCourseFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

