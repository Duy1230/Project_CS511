﻿namespace Project_CS511.Component
{
    partial class restaurantBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restaurantBlock));
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_distance = new System.Windows.Forms.Label();
            this.pb_star = new System.Windows.Forms.PictureBox();
            this.lb_star = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_picture
            // 
            this.pb_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(8, 3);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(149, 97);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            this.pb_picture.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.pb_picture.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(4, 103);
            this.lb_name.MaximumSize = new System.Drawing.Size(170, 38);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(140, 38);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Tiệm cà phê muối biển";
            this.lb_name.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.lb_name.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // lb_distance
            // 
            this.lb_distance.AutoSize = true;
            this.lb_distance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_distance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distance.Location = new System.Drawing.Point(7, 152);
            this.lb_distance.Name = "lb_distance";
            this.lb_distance.Size = new System.Drawing.Size(52, 18);
            this.lb_distance.TabIndex = 4;
            this.lb_distance.Text = "2.3 km";
            this.lb_distance.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.lb_distance.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // pb_star
            // 
            this.pb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_star.Image = global::Project_CS511.Properties.Resources.star;
            this.pb_star.Location = new System.Drawing.Point(104, 147);
            this.pb_star.Name = "pb_star";
            this.pb_star.Size = new System.Drawing.Size(25, 25);
            this.pb_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star.TabIndex = 5;
            this.pb_star.TabStop = false;
            this.pb_star.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_star.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(130, 151);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(28, 19);
            this.lb_star.TabIndex = 6;
            this.lb_star.Text = "4.8";
            this.lb_star.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            // 
            // restaurantBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pb_star);
            this.Controls.Add(this.lb_distance);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_picture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "restaurantBlock";
            this.Size = new System.Drawing.Size(166, 182);
            this.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_distance;
        private System.Windows.Forms.PictureBox pb_star;
        private System.Windows.Forms.Label lb_star;
    }
}
