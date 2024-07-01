namespace ISAD_Asss
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.BTN_logIn = new System.Windows.Forms.Button();
            this.label_userName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_logIn
            // 
            this.BTN_logIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_logIn.ForeColor = System.Drawing.Color.White;
            this.BTN_logIn.Location = new System.Drawing.Point(441, 274);
            this.BTN_logIn.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_logIn.Name = "BTN_logIn";
            this.BTN_logIn.Size = new System.Drawing.Size(188, 44);
            this.BTN_logIn.TabIndex = 0;
            this.BTN_logIn.Text = "Log In";
            this.BTN_logIn.UseVisualStyleBackColor = false;
            this.BTN_logIn.Click += new System.EventHandler(this.BTN_logIn_Click);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(364, 65);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(94, 24);
            this.label_userName.TabIndex = 1;
            this.label_userName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(368, 104);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(322, 30);
            this.txtUserName.TabIndex = 2;
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(364, 156);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(82, 24);
            this.label_PW.TabIndex = 1;
            this.label_PW.Text = "Password";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(368, 195);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(322, 30);
            this.txtPW.TabIndex = 2;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.BTN_logIn);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_logIn;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

