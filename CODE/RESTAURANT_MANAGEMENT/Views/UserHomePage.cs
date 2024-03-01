﻿using RESTAURANT_MANAGEMENT.Models;
using RESTAURANT_MANAGEMENT.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT.Views
{
    public partial class UserHomePage : Form
    {
        LoginController lg = new LoginController();
        UserModel.User user ;
        TableModel.Table table;


        public UserHomePage()
        {
            InitializeComponent();
            Load_tables();
            btnInside.BackColor = Color.Orange;
            panelTables.Enabled = true;
            lbBranchName.Text = loadBranchName();

        }


        private void Load_tables()
        {
            List<TableModel.Table> listTable = TableController.GetTableList();

            foreach (TableModel.Table table in listTable)
            {
                Button btn = new Button() { Width = TableController.width, Height = TableController.heihgt};
                btn.Text = table.display_name;

                btn.Click += Btn_Click;
                btn.Tag = table;

                if (table.status == 0)
                {
                    btn.BackColor = Color.LightBlue;
                }
                else
                {
                    btn.BackColor = Color.Gray;
                }
                btn.TextAlign = ContentAlignment.MiddleCenter;

                flpTables.Controls.Add(btn);

            }
        }



        private void showSelectedTable (String tablename)
        {
            txtSelectedTable.Text = tablename;
            txtSelectedTable.TextAlign = HorizontalAlignment.Center;
        }

        private String loadBranchName()
        {
            String br_name = LoginController.GetUserBranchName(LoginController.GetUser().u_id);
            return br_name;
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInside_Click(object sender, EventArgs e)
        {
            btnInside.BackColor = Color.Orange;
            panelTables.Enabled = true;
            btnAway.BackColor = Color.White;
        }

        private void btnAway_Click(object sender, EventArgs e)
        {
            btnInside.BackColor = Color.White;
            panelTables.Enabled = false;
            btnAway.BackColor = Color.Orange;
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                TableModel.Table table = btn.Tag as TableModel.Table;
                if (table != null)
                {
                    String table_name =  table.display_name;
                    showSelectedTable(table_name);
                }
            }
        }


    }
}
