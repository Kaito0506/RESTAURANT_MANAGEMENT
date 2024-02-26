using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    partial class AdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.branch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbName.Location = new System.Drawing.Point(97, 23);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "admin";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(236, 554);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 69);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.branch);
            this.panel1.Location = new System.Drawing.Point(4, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 76);
            this.panel1.TabIndex = 4;
            // 
            // branch
            // 
            this.branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.branch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.branch.FlatAppearance.BorderSize = 0;
            this.branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.branch.Image = ((System.Drawing.Image)(resources.GetObject("branch.Image")));
            this.branch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.branch.Location = new System.Drawing.Point(4, 4);
            this.branch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(224, 69);
            this.branch.TabIndex = 5;
            this.branch.Text = "Branches";
            this.branch.UseVisualStyleBackColor = false;
            this.branch.Click += new System.EventHandler(this.branch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user);
            this.panel2.Location = new System.Drawing.Point(4, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 76);
            this.panel2.TabIndex = 6;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user.Location = new System.Drawing.Point(4, 4);
            this.user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(224, 69);
            this.user.TabIndex = 5;
            this.user.Text = "Users";
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customer);
            this.panel3.Location = new System.Drawing.Point(4, 249);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 76);
            this.panel3.TabIndex = 6;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.customer.Image = ((System.Drawing.Image)(resources.GetObject("customer.Image")));
            this.customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer.Location = new System.Drawing.Point(4, 4);
            this.customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(224, 69);
            this.customer.TabIndex = 5;
            this.customer.Text = "Customers";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminHomePage";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Button branch;
        private Panel panel2;
        private Button user;
        private Panel panel3;
        private Button customer;
        private Panel panel4;
    }
}