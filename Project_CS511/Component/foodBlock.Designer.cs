﻿namespace Project_CS511.Component
{
    partial class foodBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodBlock));
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_store = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.lb_star = new System.Windows.Forms.Label();
            this.pb_star = new System.Windows.Forms.PictureBox();
            this.lb_distance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(7, 202);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(80, 22);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "27.000₫";
            this.lb_price.Click += new System.EventHandler(this.pb_picture_Click);
            this.lb_price.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.lb_price.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(7, 108);
            this.lb_name.MaximumSize = new System.Drawing.Size(165, 50);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(122, 44);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Original Salt Coffee";
            this.lb_name.Click += new System.EventHandler(this.pb_picture_Click);
            this.lb_name.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.lb_name.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(8, 181);
            this.lb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(127, 17);
            this.lb_store.TabIndex = 8;
            this.lb_store.Text = "Tiệm Cà Phê Muối";
            this.lb_store.Click += new System.EventHandler(this.pb_picture_Click);
            this.lb_store.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.lb_store.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "________________________";
            this.label2.Click += new System.EventHandler(this.pb_picture_Click);
            this.label2.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(11, 3);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(149, 102);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 5;
            this.pb_picture.TabStop = false;
            this.pb_picture.Click += new System.EventHandler(this.pb_picture_Click);
            this.pb_picture.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.pb_picture.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(34, 155);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(28, 19);
            this.lb_star.TabIndex = 11;
            this.lb_star.Text = "4.8";
            // 
            // pb_star
            // 
            this.pb_star.Image = global::Project_CS511.Properties.Resources.star;
            this.pb_star.Location = new System.Drawing.Point(11, 150);
            this.pb_star.Name = "pb_star";
            this.pb_star.Size = new System.Drawing.Size(25, 25);
            this.pb_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star.TabIndex = 10;
            this.pb_star.TabStop = false;
            // 
            // lb_distance
            // 
            this.lb_distance.AutoSize = true;
            this.lb_distance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distance.Location = new System.Drawing.Point(109, 202);
            this.lb_distance.Name = "lb_distance";
            this.lb_distance.Size = new System.Drawing.Size(51, 19);
            this.lb_distance.TabIndex = 12;
            this.lb_distance.Text = "3.2 Km";
            // 
            // foodBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_distance);
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pb_star);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_store);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_picture);
            this.Name = "foodBlock";
            this.Size = new System.Drawing.Size(166, 226);
            this.Click += new System.EventHandler(this.pb_picture_Click);
            this.MouseEnter += new System.EventHandler(this.pb_picture_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pb_picture_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_star;
        private System.Windows.Forms.PictureBox pb_star;
        private System.Windows.Forms.Label lb_distance;
    }
}
