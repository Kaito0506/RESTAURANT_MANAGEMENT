namespace RESTAURANT_MANAGEMENT.Views
{
    partial class AdminUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstManager = new System.Windows.Forms.ListBox();
            this.lstChef = new System.Windows.Forms.ListBox();
            this.lstWaiter = new System.Windows.Forms.ListBox();
            this.lstJanitor = new System.Windows.Forms.ListBox();
            this.lstSecurity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chef";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Waiter/Waitress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Janitor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Security";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Branches";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Manager";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lstManager
            // 
            this.lstManager.FormattingEnabled = true;
            this.lstManager.Items.AddRange(new object[] {
            "Nguyen Duy A"});
            this.lstManager.Location = new System.Drawing.Point(12, 143);
            this.lstManager.Name = "lstManager";
            this.lstManager.Size = new System.Drawing.Size(343, 108);
            this.lstManager.TabIndex = 15;
            this.lstManager.SelectedIndexChanged += new System.EventHandler(this.lstManager_SelectedIndexChanged);
            // 
            // lstChef
            // 
            this.lstChef.FormattingEnabled = true;
            this.lstChef.Location = new System.Drawing.Point(12, 287);
            this.lstChef.Name = "lstChef";
            this.lstChef.Size = new System.Drawing.Size(343, 108);
            this.lstChef.TabIndex = 16;
            // 
            // lstWaiter
            // 
            this.lstWaiter.FormattingEnabled = true;
            this.lstWaiter.Location = new System.Drawing.Point(12, 445);
            this.lstWaiter.Name = "lstWaiter";
            this.lstWaiter.Size = new System.Drawing.Size(343, 108);
            this.lstWaiter.TabIndex = 17;
            // 
            // lstJanitor
            // 
            this.lstJanitor.FormattingEnabled = true;
            this.lstJanitor.Location = new System.Drawing.Point(12, 579);
            this.lstJanitor.Name = "lstJanitor";
            this.lstJanitor.Size = new System.Drawing.Size(343, 108);
            this.lstJanitor.TabIndex = 18;
            // 
            // lstSecurity
            // 
            this.lstSecurity.FormattingEnabled = true;
            this.lstSecurity.Location = new System.Drawing.Point(12, 728);
            this.lstSecurity.Name = "lstSecurity";
            this.lstSecurity.Size = new System.Drawing.Size(343, 108);
            this.lstSecurity.TabIndex = 19;
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 848);
            this.Controls.Add(this.lstSecurity);
            this.Controls.Add(this.lstJanitor);
            this.Controls.Add(this.lstWaiter);
            this.Controls.Add(this.lstChef);
            this.Controls.Add(this.lstManager);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstManager;
        private System.Windows.Forms.ListBox lstChef;
        private System.Windows.Forms.ListBox lstWaiter;
        private System.Windows.Forms.ListBox lstJanitor;
        private System.Windows.Forms.ListBox lstSecurity;
    }
}