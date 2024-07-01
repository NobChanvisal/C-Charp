namespace DataEntryProject
{
    partial class formDataEntry
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
            this.components = new System.ComponentModel.Container();
            this.grBoxDataEntry = new System.Windows.Forms.GroupBox();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttAccept = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grBoxTimer = new System.Windows.Forms.GroupBox();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttPause = new System.Windows.Forms.Button();
            this.bttStart = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grBoxDataEntry.SuspendLayout();
            this.grBoxTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxDataEntry
            // 
            this.grBoxDataEntry.Controls.Add(this.bttClear);
            this.grBoxDataEntry.Controls.Add(this.bttAccept);
            this.grBoxDataEntry.Controls.Add(this.txtZip);
            this.grBoxDataEntry.Controls.Add(this.txtState);
            this.grBoxDataEntry.Controls.Add(this.txtCity);
            this.grBoxDataEntry.Controls.Add(this.txtAddr);
            this.grBoxDataEntry.Controls.Add(this.txtName);
            this.grBoxDataEntry.Controls.Add(this.labelZip);
            this.grBoxDataEntry.Controls.Add(this.labelState);
            this.grBoxDataEntry.Controls.Add(this.labelCity);
            this.grBoxDataEntry.Controls.Add(this.labelAddr);
            this.grBoxDataEntry.Controls.Add(this.labelName);
            this.grBoxDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDataEntry.Location = new System.Drawing.Point(62, 91);
            this.grBoxDataEntry.Name = "grBoxDataEntry";
            this.grBoxDataEntry.Size = new System.Drawing.Size(384, 446);
            this.grBoxDataEntry.TabIndex = 0;
            this.grBoxDataEntry.TabStop = false;
            this.grBoxDataEntry.Text = "Data Entry";
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(237, 337);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(105, 43);
            this.bttClear.TabIndex = 11;
            this.bttClear.Text = "&Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            this.bttClear.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttClear.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // bttAccept
            // 
            this.bttAccept.Location = new System.Drawing.Point(49, 337);
            this.bttAccept.Name = "bttAccept";
            this.bttAccept.Size = new System.Drawing.Size(105, 43);
            this.bttAccept.TabIndex = 10;
            this.bttAccept.Text = "&Accept";
            this.bttAccept.UseVisualStyleBackColor = true;
            this.bttAccept.Click += new System.EventHandler(this.bttAccept_Click);
            this.bttAccept.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttAccept.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(149, 278);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(193, 27);
            this.txtZip.TabIndex = 9;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputKeyPress);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(149, 222);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(193, 27);
            this.txtState.TabIndex = 8;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputKeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(149, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(193, 27);
            this.txtCity.TabIndex = 7;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputKeyPress);
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(149, 113);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(193, 27);
            this.txtAddr.TabIndex = 6;
            this.txtAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputKeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 27);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputKeyPress);
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(35, 281);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(31, 20);
            this.labelZip.TabIndex = 4;
            this.labelZip.Text = "Zip";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(35, 225);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(48, 20);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(35, 171);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 20);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Location = new System.Drawing.Point(35, 116);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(71, 20);
            this.labelAddr.TabIndex = 1;
            this.labelAddr.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(62, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Entry";
            // 
            // grBoxTimer
            // 
            this.grBoxTimer.Controls.Add(this.bttExit);
            this.grBoxTimer.Controls.Add(this.bttPause);
            this.grBoxTimer.Controls.Add(this.bttStart);
            this.grBoxTimer.Controls.Add(this.txtTimer);
            this.grBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTimer.Location = new System.Drawing.Point(540, 91);
            this.grBoxTimer.Name = "grBoxTimer";
            this.grBoxTimer.Size = new System.Drawing.Size(270, 391);
            this.grBoxTimer.TabIndex = 1;
            this.grBoxTimer.TabStop = false;
            this.grBoxTimer.Text = "Timer";
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(97, 267);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(75, 34);
            this.bttExit.TabIndex = 14;
            this.bttExit.Text = "E&xit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            this.bttExit.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttExit.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // bttPause
            // 
            this.bttPause.Location = new System.Drawing.Point(97, 171);
            this.bttPause.Name = "bttPause";
            this.bttPause.Size = new System.Drawing.Size(75, 34);
            this.bttPause.TabIndex = 13;
            this.bttPause.Text = "&Pause";
            this.bttPause.UseVisualStyleBackColor = true;
            this.bttPause.Click += new System.EventHandler(this.bttPause_Click);
            this.bttPause.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttPause.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // bttStart
            // 
            this.bttStart.Location = new System.Drawing.Point(97, 116);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(75, 34);
            this.bttStart.TabIndex = 12;
            this.bttStart.Text = "&Start";
            this.bttStart.UseVisualStyleBackColor = true;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            this.bttStart.MouseLeave += new System.EventHandler(this.bttButton_Leave);
            this.bttStart.MouseHover += new System.EventHandler(this.bttButton_Hover);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(69, 64);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(139, 27);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(886, 601);
            this.Controls.Add(this.grBoxTimer);
            this.Controls.Add(this.grBoxDataEntry);
            this.Name = "formDataEntry";
            this.Text = "Data Entry";
            this.grBoxDataEntry.ResumeLayout(false);
            this.grBoxDataEntry.PerformLayout();
            this.grBoxTimer.ResumeLayout(false);
            this.grBoxTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxDataEntry;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grBoxTimer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button bttAccept;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button bttStart;
        private System.Windows.Forms.Button bttPause;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Timer timer1;
    }
}

