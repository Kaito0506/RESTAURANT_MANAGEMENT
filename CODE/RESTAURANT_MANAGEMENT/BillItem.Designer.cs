namespace RESTAURANT_MANAGEMENT
{
    partial class BillItem
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.InitialImage = global::RESTAURANT_MANAGEMENT.Properties.Resources.food1;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(87, 87);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.Location = new System.Drawing.Point(3, 0);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(56, 21);
            this.lbItemName.TabIndex = 1;
            this.lbItemName.Text = "Name";
            this.lbItemName.Click += new System.EventHandler(this.lbItemName_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(3, 58);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 21);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "30.000";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbItemName);
            this.panel1.Location = new System.Drawing.Point(96, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 87);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImage);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(306, 93);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panel1;
    }
}
