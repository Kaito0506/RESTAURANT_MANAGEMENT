namespace RESTAURANT_MANAGEMENT.Views
{
    partial class UserHomePage
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
            this.panelBranch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.btnInside = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.panelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBillItems = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewItems = new System.Windows.Forms.DataGridView();
            this.panelSelectedTbale = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.panelBillIfor = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBranch.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.panelTables.SuspendLayout();
            this.panelBillItems.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewItems)).BeginInit();
            this.panelSelectedTbale.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.panelBillIfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBranch
            // 
            this.panelBranch.Controls.Add(this.label1);
            this.panelBranch.Location = new System.Drawing.Point(15, 12);
            this.panelBranch.Name = "panelBranch";
            this.panelBranch.Size = new System.Drawing.Size(340, 56);
            this.panelBranch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch_name";
            // 
            // panelMethod
            // 
            this.panelMethod.Controls.Add(this.btnInside);
            this.panelMethod.Controls.Add(this.btnAway);
            this.panelMethod.Location = new System.Drawing.Point(15, 74);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Size = new System.Drawing.Size(340, 47);
            this.panelMethod.TabIndex = 1;
            // 
            // btnInside
            // 
            this.btnInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInside.Location = new System.Drawing.Point(176, 2);
            this.btnInside.Name = "btnInside";
            this.btnInside.Size = new System.Drawing.Size(150, 40);
            this.btnInside.TabIndex = 1;
            this.btnInside.Text = "Inside";
            this.btnInside.UseVisualStyleBackColor = true;
            this.btnInside.Click += new System.EventHandler(this.btnInside_Click);
            // 
            // btnAway
            // 
            this.btnAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.Location = new System.Drawing.Point(3, 3);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(150, 40);
            this.btnAway.TabIndex = 0;
            this.btnAway.Text = "Take away";
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // panelTables
            // 
            this.panelTables.AutoScroll = true;
            this.panelTables.Controls.Add(this.flpTables);
            this.panelTables.Location = new System.Drawing.Point(12, 127);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(343, 628);
            this.panelTables.TabIndex = 2;
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.Location = new System.Drawing.Point(3, 3);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(340, 596);
            this.flpTables.TabIndex = 0;
            // 
            // panelBillItems
            // 
            this.panelBillItems.Controls.Add(this.listView1);
            this.panelBillItems.Location = new System.Drawing.Point(361, 63);
            this.panelBillItems.Name = "panelBillItems";
            this.panelBillItems.Size = new System.Drawing.Size(577, 408);
            this.panelBillItems.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.viewItems);
            this.panel4.Location = new System.Drawing.Point(938, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 628);
            this.panel4.TabIndex = 4;
            // 
            // viewItems
            // 
            this.viewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewItems.Location = new System.Drawing.Point(3, 3);
            this.viewItems.Name = "viewItems";
            this.viewItems.RowHeadersWidth = 51;
            this.viewItems.RowTemplate.Height = 24;
            this.viewItems.Size = new System.Drawing.Size(363, 622);
            this.viewItems.TabIndex = 0;
            // 
            // panelSelectedTbale
            // 
            this.panelSelectedTbale.Controls.Add(this.textBox1);
            this.panelSelectedTbale.Controls.Add(this.label2);
            this.panelSelectedTbale.Location = new System.Drawing.Point(361, 16);
            this.panelSelectedTbale.Name = "panelSelectedTbale";
            this.panelSelectedTbale.Size = new System.Drawing.Size(577, 41);
            this.panelSelectedTbale.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected table";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.cbTables);
            this.panelOperations.Controls.Add(this.btnMerge);
            this.panelOperations.Location = new System.Drawing.Point(361, 660);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(574, 90);
            this.panelOperations.TabIndex = 1;
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(191, 18);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(303, 37);
            this.cbTables.TabIndex = 2;
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(32, 18);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(128, 37);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // panelBillIfor
            // 
            this.panelBillIfor.Controls.Add(this.txtTotal);
            this.panelBillIfor.Controls.Add(this.txtDiscount);
            this.panelBillIfor.Controls.Add(this.txtSum);
            this.panelBillIfor.Controls.Add(this.label6);
            this.panelBillIfor.Controls.Add(this.label5);
            this.panelBillIfor.Controls.Add(this.label4);
            this.panelBillIfor.Location = new System.Drawing.Point(361, 471);
            this.panelBillIfor.Name = "panelBillIfor";
            this.panelBillIfor.Size = new System.Drawing.Size(574, 185);
            this.panelBillIfor.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(194, 130);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(168, 32);
            this.txtTotal.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtDiscount.Location = new System.Drawing.Point(194, 77);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(168, 32);
            this.txtDiscount.TabIndex = 8;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(194, 16);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(168, 32);
            this.txtSum.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(27, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sub Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(941, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 52);
            this.panel1.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 14);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(363, 34);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.txtFindName);
            this.panel2.Location = new System.Drawing.Point(941, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 47);
            this.panel2.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::RESTAURANT_MANAGEMENT.Properties.Resources.find;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Location = new System.Drawing.Point(322, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 35);
            this.btnFind.TabIndex = 0;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFindName
            // 
            this.txtFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindName.Location = new System.Drawing.Point(3, 3);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(313, 32);
            this.txtFindName.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(21, 16);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 100);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(21, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(728, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 182);
            this.panel3.TabIndex = 6;
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 843);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBillIfor);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelSelectedTbale);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelBillItems);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.panelMethod);
            this.Controls.Add(this.panelBranch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserHomePage";
            this.Text = "UserHomePage";
            this.panelBranch.ResumeLayout(false);
            this.panelBranch.PerformLayout();
            this.panelMethod.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelBillItems.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewItems)).EndInit();
            this.panelSelectedTbale.ResumeLayout(false);
            this.panelSelectedTbale.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.panelBillIfor.ResumeLayout(false);
            this.panelBillIfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBranch;
        private System.Windows.Forms.Panel panelMethod;
        private System.Windows.Forms.FlowLayoutPanel panelTables;
        private System.Windows.Forms.Panel panelBillItems;
        private System.Windows.Forms.Panel panelSelectedTbale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Panel panelBillIfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInside;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.DataGridView viewItems;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
    }
}