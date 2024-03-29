﻿using MongoDB.Bson;
using Project_CS511.Properties;
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

namespace Project_CS511.Component
{
    public partial class foodCommentBubble : UserControl
    {
        mainForm main;
        public foodCommentBubble(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void addData(BsonDocument data)
        {
            //add star
            loadStart(data["rating"].AsString);

            //add name
            lb_name.Text = data["loginName"].AsString;

            //add comment
            lb_comment.Text = data["comment"].AsString;

            main.dataSource.SetCollection("user");
            string userId = main.dataSource.findValue("loginName", lb_name.Text, "userId");
            string avatarPath = getAvatarPath() + userId + ".png";

            if(File.Exists(avatarPath))
            {
                pb_avatar.Image = Image.FromFile(avatarPath);
            }
            else
            {
                pb_avatar.Image = Resources.customer_active;
            }

        }

        private void loadStart(string start)
        {
            if(start == "1")
            {
                pictureBox1.Image = Resources.star_on;
                pictureBox2.Image = Resources.star_off;
                pictureBox3.Image = Resources.star_off;
                pictureBox4.Image = Resources.star_off;
                pictureBox5.Image = Resources.star_off;
            }
            if (start == "2")
            {
                pictureBox1.Image = Resources.star_on;
                pictureBox2.Image = Resources.star_on;
                pictureBox3.Image = Resources.star_off;
                pictureBox4.Image = Resources.star_off;
                pictureBox5.Image = Resources.star_off;
            }
            if (start == "3")
            {
                pictureBox1.Image = Resources.star_on;
                pictureBox2.Image = Resources.star_on;
                pictureBox3.Image = Resources.star_on;
                pictureBox4.Image = Resources.star_off;
                pictureBox5.Image = Resources.star_off;
            }
            if (start == "4")
            {
                pictureBox1.Image = Resources.star_on;
                pictureBox2.Image = Resources.star_on;
                pictureBox3.Image = Resources.star_on;
                pictureBox4.Image = Resources.star_on;
                pictureBox5.Image = Resources.star_off;
            }
            if (start == "5")
            {
                pictureBox1.Image = Resources.star_on;
                pictureBox2.Image = Resources.star_on;
                pictureBox3.Image = Resources.star_on;
                pictureBox4.Image = Resources.star_on;
                pictureBox5.Image = Resources.star_on;
            }
        }

        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;

        }
    }
}
