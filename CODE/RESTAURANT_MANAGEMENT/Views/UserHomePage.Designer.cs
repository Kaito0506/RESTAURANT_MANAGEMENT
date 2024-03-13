﻿namespace RESTAURANT_MANAGEMENT.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBranch = new System.Windows.Forms.Panel();
            this.lbBranchName = new System.Windows.Forms.Label();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.btnInside = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.panelBillItems = new System.Windows.Forms.Panel();
            this.panelSelectedTbale = new System.Windows.Forms.Panel();
            this.txtSelectedTable = new System.Windows.Forms.TextBox();
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
            this.btnPay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntPrint = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lstItems = new System.Windows.Forms.DataGridView();
            this.panelBranch.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.panelBillItems.SuspendLayout();
            this.panelSelectedTbale.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.panelBillIfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBranch
            // 
            this.panelBranch.Controls.Add(this.lbBranchName);
            this.panelBranch.Location = new System.Drawing.Point(15, 12);
            this.panelBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBranch.Name = "panelBranch";
            this.panelBranch.Size = new System.Drawing.Size(473, 57);
            this.panelBranch.TabIndex = 0;
            // 
            // lbBranchName
            // 
            this.lbBranchName.AutoSize = true;
            this.lbBranchName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranchName.Location = new System.Drawing.Point(151, 12);
            this.lbBranchName.Name = "lbBranchName";
            this.lbBranchName.Size = new System.Drawing.Size(159, 26);
            this.lbBranchName.TabIndex = 0;
            this.lbBranchName.Text = "Branch_name";
            // 
            // panelMethod
            // 
            this.panelMethod.Controls.Add(this.btnInside);
            this.panelMethod.Controls.Add(this.btnAway);
            this.panelMethod.Location = new System.Drawing.Point(15, 74);
            this.panelMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Size = new System.Drawing.Size(473, 47);
            this.panelMethod.TabIndex = 1;
            // 
            // btnInside
            // 
            this.btnInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInside.Location = new System.Drawing.Point(248, 2);
            this.btnInside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInside.Name = "btnInside";
            this.btnInside.Size = new System.Drawing.Size(149, 39);
            this.btnInside.TabIndex = 1;
            this.btnInside.Text = "Inside";
            this.btnInside.UseVisualStyleBackColor = true;
            this.btnInside.Click += new System.EventHandler(this.btnInside_Click);
            // 
            // btnAway
            // 
            this.btnAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.Location = new System.Drawing.Point(55, 2);
            this.btnAway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(149, 39);
            this.btnAway.TabIndex = 0;
            this.btnAway.Text = "Take away";
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // panelBillItems
            // 
            this.panelBillItems.Controls.Add(this.lstItems);
            this.panelBillItems.Location = new System.Drawing.Point(16, 60);
            this.panelBillItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBillItems.Name = "panelBillItems";
            this.panelBillItems.Size = new System.Drawing.Size(622, 378);
            this.panelBillItems.TabIndex = 3;
            // 
            // panelSelectedTbale
            // 
            this.panelSelectedTbale.Controls.Add(this.txtSelectedTable);
            this.panelSelectedTbale.Controls.Add(this.label2);
            this.panelSelectedTbale.Location = new System.Drawing.Point(16, 17);
            this.panelSelectedTbale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSelectedTbale.Name = "panelSelectedTbale";
            this.panelSelectedTbale.Size = new System.Drawing.Size(622, 41);
            this.panelSelectedTbale.TabIndex = 2;
            // 
            // txtSelectedTable
            // 
            this.txtSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedTable.Location = new System.Drawing.Point(191, 4);
            this.txtSelectedTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectedTable.Name = "txtSelectedTable";
            this.txtSelectedTable.ReadOnly = true;
            this.txtSelectedTable.Size = new System.Drawing.Size(323, 32);
            this.txtSelectedTable.TabIndex = 2;
            this.txtSelectedTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected table";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.cbTables);
            this.panelOperations.Controls.Add(this.btnMerge);
            this.panelOperations.Location = new System.Drawing.Point(13, 632);
            this.panelOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(622, 90);
            this.panelOperations.TabIndex = 1;
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(191, 18);
            this.cbTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(177, 37);
            this.cbTables.TabIndex = 2;
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(32, 18);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(128, 37);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Change";
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
            this.panelBillIfor.Location = new System.Drawing.Point(16, 442);
            this.panelBillIfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBillIfor.Name = "panelBillIfor";
            this.panelBillIfor.Size = new System.Drawing.Size(381, 186);
            this.panelBillIfor.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(191, 113);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtDiscount.Location = new System.Drawing.Point(191, 63);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(168, 32);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.ValueChanged += new System.EventHandler(this.txtDiscount_ValueChanged);
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(191, 10);
            this.txtSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sub Total";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(53, 45);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(149, 94);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bntPrint);
            this.panel3.Controls.Add(this.btnOrder);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Location = new System.Drawing.Point(403, 442);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 187);
            this.panel3.TabIndex = 6;
            // 
            // bntPrint
            // 
            this.bntPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPrint.Location = new System.Drawing.Point(53, 146);
            this.bntPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Size = new System.Drawing.Size(149, 39);
            this.bntPrint.TabIndex = 12;
            this.bntPrint.Text = "Bill";
            this.bntPrint.UseVisualStyleBackColor = true;
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(53, 2);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(149, 39);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelOperations);
            this.panel1.Controls.Add(this.panelSelectedTbale);
            this.panel1.Controls.Add(this.panelBillIfor);
            this.panel1.Controls.Add(this.panelBillItems);
            this.panel1.Location = new System.Drawing.Point(516, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 735);
            this.panel1.TabIndex = 7;
            // 
            // flpTables
            // 
            this.flpTables.Location = new System.Drawing.Point(15, 128);
            this.flpTables.Margin = new System.Windows.Forms.Padding(4);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(472, 619);
            this.flpTables.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.txtFindName);
            this.panel2.Location = new System.Drawing.Point(1157, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 97);
            this.panel2.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(0, 2);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(258, 34);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // txtFindName
            // 
            this.txtFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindName.Location = new System.Drawing.Point(3, 54);
            this.txtFindName.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(255, 32);
            this.txtFindName.TabIndex = 3;
            this.txtFindName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.Location = new System.Drawing.Point(1157, 114);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(270, 633);
            this.flpItems.TabIndex = 7;
            // 
            // lstItems
            // 
            this.lstItems.AllowUserToAddRows = false;
            this.lstItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.lstItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lstItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lstItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lstItems.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstItems.Location = new System.Drawing.Point(0, 0);
            this.lstItems.Margin = new System.Windows.Forms.Padding(8);
            this.lstItems.Name = "lstItems";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lstItems.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            this.lstItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lstItems.RowTemplate.Height = 60;
            this.lstItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lstItems.Size = new System.Drawing.Size(622, 378);
            this.lstItems.TabIndex = 0;
            // 
            // UserHomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1455, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.flpTables);
            this.Controls.Add(this.panelMethod);
            this.Controls.Add(this.panelBranch);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserHomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBranch.ResumeLayout(false);
            this.panelBranch.PerformLayout();
            this.panelMethod.ResumeLayout(false);
            this.panelBillItems.ResumeLayout(false);
            this.panelSelectedTbale.ResumeLayout(false);
            this.panelSelectedTbale.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.panelBillIfor.ResumeLayout(false);
            this.panelBillIfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBranch;
        private System.Windows.Forms.Panel panelMethod;
        private System.Windows.Forms.Panel panelBillItems;
        private System.Windows.Forms.Panel panelSelectedTbale;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Panel panelBillIfor;
        private System.Windows.Forms.Label lbBranchName;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Button btnInside;
        private System.Windows.Forms.TextBox txtSelectedTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Button bntPrint;
        private System.Windows.Forms.DataGridView lstItems;
    }
}