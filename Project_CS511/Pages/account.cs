﻿using Project_CS511.Properties;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Pages
{
    public partial class account : UserControl
    {
        mainForm main;
        Color green = Color.FromArgb(16, 83, 53);
        public account(mainForm main=null)
        {
            InitializeComponent();
            this.main = main;
            init();

        }

        public void addName(string userId)
        {
            main.dataSource.SetCollection("user");
            lb_name.Text = main.dataSource.findValue("userId", userId, "username");
        }

        public void init()
        {
            panel1.BackColor = green;
            lb_logOut.BackColor = green;
        }

        #region decoration
        #region mouse Enter
        private void lb_changeUsername_MouseEnter(object sender, EventArgs e)
        {
            pn_changeUsername.BackColor = Color.LightGray;
        }

        private void lb_changePassword_MouseEnter(object sender, EventArgs e)
        {
            pn_changePassword.BackColor = Color.LightGray;
        }

        private void lb_payment_MouseEnter(object sender, EventArgs e)
        {
            pn_payment.BackColor = Color.LightGray;
        }

        private void lb_favourites_MouseEnter(object sender, EventArgs e)
        {
            pn_favourites.BackColor = Color.LightGray;
        }

        private void lb_savedPlaces_MouseEnter(object sender, EventArgs e)
        {
            pn_savedPlaces.BackColor = Color.LightGray;
        }
        #endregion

        #region mouse Leave
        private void pn_changeUsername_MouseLeave(object sender, EventArgs e)
        {
            pn_changeUsername.BackColor = Color.White;
        }

        private void pn_changePassword_MouseLeave(object sender, EventArgs e)
        {
            pn_changePassword.BackColor = Color.White;
        }

        private void pn_payment_MouseLeave(object sender, EventArgs e)
        {
            pn_payment.BackColor = Color.White;
        }

        private void pn_favourites_MouseLeave(object sender, EventArgs e)
        {
            pn_favourites.BackColor = Color.White;
        }

        private void pn_savedPlaces_MouseLeave(object sender, EventArgs e)
        {
            pn_savedPlaces.BackColor = Color.White;
        }


        #endregion

        #endregion

        private void lb_logOut_Click(object sender, EventArgs e)
        {
            main.Close();
        }

        private void lb_updateInfo_Click(object sender, EventArgs e)
        {
            updateInfo f = new updateInfo(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void lb_savedPlaces_Click(object sender, EventArgs e)
        {
            cartSubPage f = new cartSubPage(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void lb_favourites_Click(object sender, EventArgs e)
        {
            likedSubPage f = new likedSubPage(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void lb_store_Click(object sender, EventArgs e)
        {
            yourStore f = new yourStore(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void pn_changeUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_yourLocation_Click(object sender, EventArgs e)
        {
            setLocation f = new setLocation(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pn_changePassword_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pn_savedPlaces_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_edit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string destinationFolder = Path.Combine(getAvatarPath(), main.currentId + ".png");

                try
                {
                    main.homePage.setToAvoidConflict();
                    main.messagePage.setToAvoidConflict();
                    pb_avatar.Image.Dispose();
                    pb_avatar.Image = Resources._default;

                    File.Copy(selectedFilePath, destinationFolder, true);
                    reloadAvatar(main.currentId);
                    main.homePage.reloadRestaurant();
                    main.messagePage.init();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;

        }

        public void reloadAvatar(string id)
        {
            string avatarPath = getAvatarPath() + id + ".png";
            if (File.Exists(avatarPath))
            {
                pb_avatar.Image = Image.FromFile(avatarPath);
            }
            else
            {
                pb_avatar.Image = Resources.customer_active;
            }
        }


        private void pn_favourites_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_payment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_avatar_Click(object sender, EventArgs e)
        {

        }
    }
}
