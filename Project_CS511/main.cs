﻿using Project_CS511.Component;
using Project_CS511.Pages;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_CS511
{
    public partial class mainForm : Form
    {
        public home homePage;
        public food foodPage;
        public payment paymentPage;
        public message messagePage;
        public account accountPage;
        public map mapPage;
        public maplocation maplocationPage;
        private menuBar menu;
        public DataSource dataSource = new DataSource();
        public string api_key = "AIzaSyAJRMpBYJh-Rkbr3ozfr_m7LEjCjy--Lzc";
        public string currentUser;
        public string currentId;
        public string tempLocation;
        public double currentLatitude;
        public double currentLongitude;
        public string methodepayment;
        public mainForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            dataSource.SetCollection("user");
            //add menu bar
            menu = new menuBar(this);
            this.Controls.Add(menu);

            //add home page
            homePage = new home(this);
            this.Controls.Add(homePage);

            // add food page
            foodPage = new food(this);
            this.Controls.Add(foodPage);

            // add payment page
            paymentPage = new payment(this);
            this.Controls.Add(paymentPage);

            // add message page
            messagePage = new message(this);
            this.Controls.Add(messagePage);

            //add account
            accountPage = new account(this);
            this.Controls.Add(accountPage);

            //add logSignIn
            logSignIn logSignIn = new logSignIn(this);
            this.Controls.Add(logSignIn);
            logSignIn.BringToFront();

            //add map location
            mapPage = new map(this);
            this.Controls.Add(mapPage);

            maplocationPage = new maplocation(this);
            this.Controls.Add(maplocationPage);
          
        }
        public void HideMenu()
        {
            // Hide the menu
            if (menu != null)
            {
                menu.Visible = false;
            }
        }
        public void ShowMenu()
        {
            // Hide the menu
            if (menu.Visible == false)
            {
                menu.Visible = true;
            }
        }

        #region Các Hàm chức năng
        public void bringControlToFront(Control c)
        {
            c.BringToFront();
        }

        public void hideAllControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
        }
        public Control findControlByName(string name)
        {
            Control foundControl = this.Controls.Find(name, true).FirstOrDefault();

            if (foundControl != null)
            {
                return foundControl;
            }
            return null;
        }

        public void RemoveControlByName(string controlName)
        {
            var controlToRemove = Controls.Find(controlName, true).OfType<Control>().FirstOrDefault();

            if (controlToRemove != null)
            {
                Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }

        public void loginSuccess(bool isNew)
        {
            RemoveControlByName("logSignIn");
            updateTempData();
            accountPage.reloadAvatar(currentId);
            messagePage.init();
            accountPage.addName(currentId);
            if(isNew)
            {
                setLocation f = new setLocation(this);
                f.ModeNew();
                Controls.Add(f);
                bringControlToFront(f);
            }
            if(!isNew)
            {
                getLatAndLong();
                homePage.reloadDistance();
                foodPage.loadDistance();
            }

        }

        public void updateTempData()
        {
            dataSource.SetCollection("user");
            string newLocation = dataSource.findValue("loginName", currentUser, "location");
            dataSource.SetCollection("tempData");
            string oldLocation = dataSource.findValue("id", "1", "location");
            dataSource.findAndReplaceOne("location", oldLocation, "location", newLocation);
            //dataSource.SetCollection("user");
        }

        public void getLatAndLong()
        {
            dataSource.SetCollection("user");
            currentLatitude = double.Parse(dataSource.findValue("userId", currentId, "coordinate").Split('-')[0]);
            currentLongitude = double.Parse(dataSource.findValue("userId", currentId, "coordinate").Split('-')[1]);
        }
       
        #endregion
    }
}
