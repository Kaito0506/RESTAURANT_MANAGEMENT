namespace RESTAURANT_MANAGEMENT.Views
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOrderMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOrderWeek = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOrderToday = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lbRevToday = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.lbRevMonth = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.lbRevWeek = new System.Windows.Forms.Label();
            this.revChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 21);
            this.label20.TabIndex = 5;
            this.label20.Text = "Order";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 21);
            this.label21.TabIndex = 6;
            this.label21.Text = "Revenue";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbOrderMonth);
            this.panel3.Location = new System.Drawing.Point(495, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 110);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "This month";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderMonth
            // 
            this.lbOrderMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrderMonth.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbOrderMonth.Location = new System.Drawing.Point(0, 0);
            this.lbOrderMonth.Name = "lbOrderMonth";
            this.lbOrderMonth.Size = new System.Drawing.Size(200, 110);
            this.lbOrderMonth.TabIndex = 3;
            this.lbOrderMonth.Text = "0";
            this.lbOrderMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbOrderWeek);
            this.panel2.Location = new System.Drawing.Point(246, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 110);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "This week";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderWeek
            // 
            this.lbOrderWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderWeek.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderWeek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrderWeek.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbOrderWeek.Location = new System.Drawing.Point(0, 0);
            this.lbOrderWeek.Name = "lbOrderWeek";
            this.lbOrderWeek.Size = new System.Drawing.Size(200, 110);
            this.lbOrderWeek.TabIndex = 3;
            this.lbOrderWeek.Text = "0";
            this.lbOrderWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbOrderToday);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 110);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Today";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderToday
            // 
            this.lbOrderToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderToday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrderToday.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbOrderToday.Location = new System.Drawing.Point(0, 0);
            this.lbOrderToday.Name = "lbOrderToday";
            this.lbOrderToday.Size = new System.Drawing.Size(195, 110);
            this.lbOrderToday.TabIndex = 3;
            this.lbOrderToday.Text = "0";
            this.lbOrderToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Location = new System.Drawing.Point(29, 91);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(698, 116);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(29, 240);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(698, 116);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.lbRevToday);
            this.panel9.Location = new System.Drawing.Point(2, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 110);
            this.panel9.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(195, 23);
            this.label23.TabIndex = 2;
            this.label23.Text = "Today";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRevToday
            // 
            this.lbRevToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRevToday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRevToday.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbRevToday.Location = new System.Drawing.Point(0, 0);
            this.lbRevToday.Name = "lbRevToday";
            this.lbRevToday.Size = new System.Drawing.Size(195, 110);
            this.lbRevToday.TabIndex = 3;
            this.lbRevToday.Text = "0";
            this.lbRevToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.lbRevMonth);
            this.panel10.Location = new System.Drawing.Point(495, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 110);
            this.panel10.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Top;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(200, 23);
            this.label26.TabIndex = 2;
            this.label26.Text = "This month";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRevMonth
            // 
            this.lbRevMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRevMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRevMonth.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbRevMonth.Location = new System.Drawing.Point(0, 0);
            this.lbRevMonth.Name = "lbRevMonth";
            this.lbRevMonth.Size = new System.Drawing.Size(200, 110);
            this.lbRevMonth.TabIndex = 3;
            this.lbRevMonth.Text = "0";
            this.lbRevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel11.Controls.Add(this.label29);
            this.panel11.Controls.Add(this.lbRevWeek);
            this.panel11.Location = new System.Drawing.Point(246, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 110);
            this.panel11.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(200, 23);
            this.label29.TabIndex = 2;
            this.label29.Text = "This week";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRevWeek
            // 
            this.lbRevWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRevWeek.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevWeek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRevWeek.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbRevWeek.Location = new System.Drawing.Point(0, 0);
            this.lbRevWeek.Name = "lbRevWeek";
            this.lbRevWeek.Size = new System.Drawing.Size(200, 110);
            this.lbRevWeek.TabIndex = 3;
            this.lbRevWeek.Text = "0";
            this.lbRevWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revChart
            // 
            this.revChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.revChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.revChart.Legends.Add(legend1);
            this.revChart.Location = new System.Drawing.Point(29, 400);
            this.revChart.Name = "revChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            series1.YValuesPerPoint = 4;
            this.revChart.Series.Add(series1);
            this.revChart.Size = new System.Drawing.Size(695, 312);
            this.revChart.TabIndex = 9;
            this.revChart.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Revenue Chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trending Items";
            // 
            // cbbBranch
            // 
            this.cbbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBranch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(603, 30);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(121, 25);
            this.cbbBranch.TabIndex = 13;
            this.cbbBranch.SelectionChangeCommitted += new System.EventHandler(this.cbbBranch_SelectionChangeCommitted);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.Location = new System.Drawing.Point(31, 757);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowTemplate.Height = 30;
            this.dgvItem.Size = new System.Drawing.Size(693, 172);
            this.dgvItem.TabIndex = 14;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(765, 932);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.revChart);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.revChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbOrderMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOrderWeek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOrderToday;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbRevToday;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbRevMonth;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbRevWeek;
        private System.Windows.Forms.DataVisualization.Charting.Chart revChart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}