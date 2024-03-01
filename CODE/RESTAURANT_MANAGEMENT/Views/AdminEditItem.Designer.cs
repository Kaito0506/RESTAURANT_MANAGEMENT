namespace RESTAURANT_MANAGEMENT.Views
{
    partial class AdminEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.upload = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCateg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filename);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDesc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbCateg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.img);
            this.panel1.Location = new System.Drawing.Point(100, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 567);
            this.panel1.TabIndex = 0;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(113, 514);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(133, 38);
            this.upload.TabIndex = 11;
            this.upload.Text = "Upload Image";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(113, 474);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(225, 20);
            this.tbPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(113, 372);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(225, 77);
            this.tbDesc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 323);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(237, 20);
            this.tbName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // cbbCateg
            // 
            this.cbbCateg.FormattingEnabled = true;
            this.cbbCateg.Location = new System.Drawing.Point(113, 273);
            this.cbbCateg.Name = "cbbCateg";
            this.cbbCateg.Size = new System.Drawing.Size(237, 21);
            this.cbbCateg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(113, 226);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(237, 20);
            this.tbId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDs";
            // 
            // img
            // 
            this.img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img.BackgroundImage")));
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img.Location = new System.Drawing.Point(101, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(170, 170);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(267, 514);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(71, 38);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.Location = new System.Drawing.Point(27, 530);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(63, 17);
            this.filename.TabIndex = 1;
            this.filename.Text = "File name";
            // 
            // AdminEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 668);
            this.Controls.Add(this.panel1);
            this.Name = "AdminEditItem";
            this.Text = "AdminEditItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label filename;
    }
}