namespace RESTAURANT_MANAGEMENT.Views
{
    partial class AdminItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminItem));
            this.add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbCateg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(53, 24);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(36, 33);
            this.add.TabIndex = 10;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh.Location = new System.Drawing.Point(12, 30);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(26, 27);
            this.refresh.TabIndex = 9;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(95, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(428, 29);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 69);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(754, 453);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // cbbCateg
            // 
            this.cbbCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCateg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCateg.FormattingEnabled = true;
            this.cbbCateg.Location = new System.Drawing.Point(529, 28);
            this.cbbCateg.Name = "cbbCateg";
            this.cbbCateg.Size = new System.Drawing.Size(237, 29);
            this.cbbCateg.TabIndex = 3;
            this.cbbCateg.SelectedIndexChanged += new System.EventHandler(this.cbbCateg_SelectedIndexChanged);
            // 
            // AdminItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(791, 534);
            this.Controls.Add(this.add);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.cbbCateg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminItem";
            this.Text = "AdminItem";
            this.Load += new System.EventHandler(this.AdminItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox cbbCateg;
    }
}