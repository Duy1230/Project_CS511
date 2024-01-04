﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Pages
{
    public partial class food : UserControl
    {
        mainForm main;
        public food(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void food_Load(object sender, EventArgs e)
        {

        }
        // move to map.cs
        private void lbl_address_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.mapPage.Show();
        }

        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.foodPage != null) { main.foodPage.Hide(); }
            main.HideMenu();
            //if ( != null) { main.foodPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
    }
}