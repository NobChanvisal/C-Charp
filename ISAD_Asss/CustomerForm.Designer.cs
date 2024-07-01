namespace ISAD_Asss
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_DeleteCus = new System.Windows.Forms.Button();
            this.BTN_UpdateCus = new System.Windows.Forms.Button();
            this.BTN_InsertCus = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusSearch = new System.Windows.Forms.TextBox();
            this.BTN_CusSearch = new System.Windows.Forms.Button();
            this.BTN_backToHome = new System.Windows.Forms.Button();
            this.BTN_clearCus = new System.Windows.Forms.Button();
            this.labelCusCon = new System.Windows.Forms.Label();
            this.txtCusCon = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.AllowUserToAddRows = false;
            this.DGV_Customer.AllowUserToDeleteRows = false;
            this.DGV_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(372, 133);
            this.DGV_Customer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.ReadOnly = true;
            this.DGV_Customer.RowHeadersWidth = 51;
            this.DGV_Customer.RowTemplate.Height = 24;
            this.DGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customer.Size = new System.Drawing.Size(666, 390);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // BTN_DeleteCus
            // 
            this.BTN_DeleteCus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DeleteCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DeleteCus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DeleteCus.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DeleteCus.Image")));
            this.BTN_DeleteCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DeleteCus.Location = new System.Drawing.Point(160, 366);
            this.BTN_DeleteCus.Name = "BTN_DeleteCus";
            this.BTN_DeleteCus.Size = new System.Drawing.Size(104, 34);
            this.BTN_DeleteCus.TabIndex = 3;
            this.BTN_DeleteCus.Text = "Delete";
            this.BTN_DeleteCus.UseVisualStyleBackColor = false;
            this.BTN_DeleteCus.Click += new System.EventHandler(this.BTN_DeleteCus_Click);
            // 
            // BTN_UpdateCus
            // 
            this.BTN_UpdateCus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UpdateCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UpdateCus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpdateCus.Image = ((System.Drawing.Image)(resources.GetObject("BTN_UpdateCus.Image")));
            this.BTN_UpdateCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UpdateCus.Location = new System.Drawing.Point(32, 415);
            this.BTN_UpdateCus.Name = "BTN_UpdateCus";
            this.BTN_UpdateCus.Size = new System.Drawing.Size(104, 34);
            this.BTN_UpdateCus.TabIndex = 3;
            this.BTN_UpdateCus.Text = "Update";
            this.BTN_UpdateCus.UseVisualStyleBackColor = false;
            this.BTN_UpdateCus.Click += new System.EventHandler(this.BTN_UpdateCus_Click);
            // 
            // BTN_InsertCus
            // 
            this.BTN_InsertCus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_InsertCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_InsertCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsertCus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_InsertCus.Image = ((System.Drawing.Image)(resources.GetObject("BTN_InsertCus.Image")));
            this.BTN_InsertCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_InsertCus.Location = new System.Drawing.Point(34, 366);
            this.BTN_InsertCus.Name = "BTN_InsertCus";
            this.BTN_InsertCus.Size = new System.Drawing.Size(104, 34);
            this.BTN_InsertCus.TabIndex = 3;
            this.BTN_InsertCus.Text = "Insert";
            this.BTN_InsertCus.UseVisualStyleBackColor = false;
            this.BTN_InsertCus.Click += new System.EventHandler(this.BTN_InsertCus_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(33, 140);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 22);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(33, 205);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 22);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(36, 165);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(304, 27);
            this.txtCusID.TabIndex = 5;
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(36, 235);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(304, 27);
            this.txtCusName.TabIndex = 5;
            // 
            // txtCusSearch
            // 
            this.txtCusSearch.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusSearch.Location = new System.Drawing.Point(372, 91);
            this.txtCusSearch.Name = "txtCusSearch";
            this.txtCusSearch.Size = new System.Drawing.Size(440, 27);
            this.txtCusSearch.TabIndex = 5;
            // 
            // BTN_CusSearch
            // 
            this.BTN_CusSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CusSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CusSearch.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CusSearch.Location = new System.Drawing.Point(831, 88);
            this.BTN_CusSearch.Name = "BTN_CusSearch";
            this.BTN_CusSearch.Size = new System.Drawing.Size(104, 30);
            this.BTN_CusSearch.TabIndex = 3;
            this.BTN_CusSearch.Text = "Search";
            this.BTN_CusSearch.UseVisualStyleBackColor = false;
            // 
            // BTN_backToHome
            // 
            this.BTN_backToHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_backToHome.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_backToHome.Image = ((System.Drawing.Image)(resources.GetObject("BTN_backToHome.Image")));
            this.BTN_backToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_backToHome.Location = new System.Drawing.Point(160, 415);
            this.BTN_backToHome.Name = "BTN_backToHome";
            this.BTN_backToHome.Size = new System.Drawing.Size(104, 34);
            this.BTN_backToHome.TabIndex = 3;
            this.BTN_backToHome.Text = "Close";
            this.BTN_backToHome.UseVisualStyleBackColor = false;
            this.BTN_backToHome.Click += new System.EventHandler(this.BTN_backToHome_Click);
            // 
            // BTN_clearCus
            // 
            this.BTN_clearCus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_clearCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_clearCus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_clearCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_clearCus.Location = new System.Drawing.Point(32, 468);
            this.BTN_clearCus.Name = "BTN_clearCus";
            this.BTN_clearCus.Size = new System.Drawing.Size(104, 34);
            this.BTN_clearCus.TabIndex = 3;
            this.BTN_clearCus.Text = "Clear";
            this.BTN_clearCus.UseVisualStyleBackColor = false;
            this.BTN_clearCus.Click += new System.EventHandler(this.BTN_clearCus_Click);
            // 
            // labelCusCon
            // 
            this.labelCusCon.AutoSize = true;
            this.labelCusCon.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCusCon.Location = new System.Drawing.Point(34, 287);
            this.labelCusCon.Name = "labelCusCon";
            this.labelCusCon.Size = new System.Drawing.Size(57, 22);
            this.labelCusCon.TabIndex = 4;
            this.labelCusCon.Text = "Contact";
            // 
            // txtCusCon
            // 
            this.txtCusCon.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusCon.Location = new System.Drawing.Point(37, 317);
            this.txtCusCon.Name = "txtCusCon";
            this.txtCusCon.Size = new System.Drawing.Size(304, 27);
            this.txtCusCon.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 82);
            this.panel1.TabIndex = 6;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCusSearch);
            this.Controls.Add(this.txtCusCon);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.labelCusCon);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BTN_CusSearch);
            this.Controls.Add(this.BTN_InsertCus);
            this.Controls.Add(this.BTN_backToHome);
            this.Controls.Add(this.BTN_clearCus);
            this.Controls.Add(this.BTN_UpdateCus);
            this.Controls.Add(this.BTN_DeleteCus);
            this.Controls.Add(this.DGV_Customer);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_DeleteCus;
        private System.Windows.Forms.Button BTN_UpdateCus;
        private System.Windows.Forms.Button BTN_InsertCus;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusSearch;
        private System.Windows.Forms.Button BTN_CusSearch;
        private System.Windows.Forms.Button BTN_backToHome;
        private System.Windows.Forms.Button BTN_clearCus;
        private System.Windows.Forms.Label labelCusCon;
        private System.Windows.Forms.TextBox txtCusCon;
        private System.Windows.Forms.Panel panel1;
    }
}