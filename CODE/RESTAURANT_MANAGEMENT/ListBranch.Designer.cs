namespace RESTAURANT_MANAGEMENT
{
    partial class ListBranch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBranch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditBranch = new System.Windows.Forms.Button();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditBranch);
            this.panel1.Controls.Add(this.btnDeleteBranch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(-52, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 163);
            this.panel1.TabIndex = 14;
            // 
            // btnEditBranch
            // 
            this.btnEditBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBranch.Image")));
            this.btnEditBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBranch.Location = new System.Drawing.Point(779, 43);
            this.btnEditBranch.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(80, 39);
            this.btnEditBranch.TabIndex = 19;
            this.btnEditBranch.Text = "Edit";
            this.btnEditBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBranch.UseVisualStyleBackColor = true;
            this.btnEditBranch.Click += new System.EventHandler(this.btnEditBranch_Click_1);
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBranch.Image")));
            this.btnDeleteBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBranch.Location = new System.Drawing.Point(867, 43);
            this.btnDeleteBranch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(89, 39);
            this.btnDeleteBranch.TabIndex = 18;
            this.btnDeleteBranch.Text = "Delete";
            this.btnDeleteBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBranch.UseVisualStyleBackColor = true;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPhone);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbAdress);
            this.panel3.Location = new System.Drawing.Point(348, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 78);
            this.panel3.TabIndex = 15;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(184, 51);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(62, 20);
            this.lbPhone.TabIndex = 18;
            this.lbPhone.Text = "Hotline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hotline:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Address:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(184, 13);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(71, 20);
            this.lbAdress.TabIndex = 17;
            this.lbAdress.Text = "Address";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(363, 11);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(196, 38);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "NHÀ HÀNG A";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(52, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(289, 164);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 13;
            // 
            // ListBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "ListBranch";
            this.Size = new System.Drawing.Size(925, 177);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditBranch;
        private System.Windows.Forms.Button btnDeleteBranch;
    }
}
