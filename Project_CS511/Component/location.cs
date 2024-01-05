﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component
{
    public partial class location : UserControl
    {
        mainForm main;
        public location(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.mapPage != null) { main.mapPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        private void btn_choose_Click(object sender, EventArgs e)
        {
            main.foodPage.SetLabelAddress(richtxtbox_address.Text.Split(',')[0].Trim());
            hideAllControls();
            main.ShowMenu();
            main.foodPage.Show();
        }
    }
}
