﻿namespace Project_CS511.SubPage
{
    partial class foodSubPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodSubPage));
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_store = new System.Windows.Forms.Label();
            this.lb_star = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_addToCart = new System.Windows.Forms.PictureBox();
            this.pb_star = new System.Windows.Forms.PictureBox();
            this.pb_food = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(1, 223);
            this.lb_name.MaximumSize = new System.Drawing.Size(350, 66);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(240, 33);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "Original Salt Coffee";
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_store.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(0, 202);
            this.lb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(137, 17);
            this.lb_store.TabIndex = 9;
            this.lb_store.Text = "Tiệm Cà Phê Muối";
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_star.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(342, 297);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(37, 26);
            this.lb_star.TabIndex = 12;
            this.lb_star.Text = "4.8";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_price.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_price.Location = new System.Drawing.Point(0, 297);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(111, 32);
            this.lb_price.TabIndex = 13;
            this.lb_price.Text = "27.000₫";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(-2, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "________________________________________________________________";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 446);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 184);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Project_CS511.Properties.Resources.back;
            this.pb_back.Location = new System.Drawing.Point(3, 155);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(40, 36);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 17;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_addToCart
            // 
            this.pb_addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addToCart.Image = global::Project_CS511.Properties.Resources.add;
            this.pb_addToCart.Location = new System.Drawing.Point(131, 294);
            this.pb_addToCart.Name = "pb_addToCart";
            this.pb_addToCart.Size = new System.Drawing.Size(40, 36);
            this.pb_addToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_addToCart.TabIndex = 14;
            this.pb_addToCart.TabStop = false;
            // 
            // pb_star
            // 
            this.pb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_star.Image = global::Project_CS511.Properties.Resources.star;
            this.pb_star.Location = new System.Drawing.Point(301, 291);
            this.pb_star.Name = "pb_star";
            this.pb_star.Size = new System.Drawing.Size(40, 36);
            this.pb_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star.TabIndex = 11;
            this.pb_star.TabStop = false;
            // 
            // pb_food
            // 
            this.pb_food.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pb_food.Image = ((System.Drawing.Image)(resources.GetObject("pb_food.Image")));
            this.pb_food.Location = new System.Drawing.Point(0, 0);
            this.pb_food.Name = "pb_food";
            this.pb_food.Size = new System.Drawing.Size(400, 149);
            this.pb_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_food.TabIndex = 0;
            this.pb_food.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Comment";
            // 
            // tb_comment
            // 
            this.tb_comment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comment.Location = new System.Drawing.Point(3, 410);
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(386, 26);
            this.tb_comment.TabIndex = 18;
            // 
            // foodSubPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_addToCart);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pb_star);
            this.Controls.Add(this.lb_store);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_food);
            this.Name = "foodSubPage";
            this.Size = new System.Drawing.Size(400, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_food;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.Label lb_star;
        private System.Windows.Forms.PictureBox pb_star;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.PictureBox pb_addToCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_comment;
    }
}