namespace RestaurantSystem.UI
{
    partial class DiscountForm
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lbldesc = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkPWD = new System.Windows.Forms.CheckBox();
            this.chkSenior = new System.Windows.Forms.CheckBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picDis = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSenior = new System.Windows.Forms.PictureBox();
            this.picPWD = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPWD)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.txtCode.Location = new System.Drawing.Point(10, 51);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(388, 29);
            this.txtCode.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.btnApply.Location = new System.Drawing.Point(411, 51);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 29);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnEnter.FlatAppearance.BorderSize = 2;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.btnEnter.Location = new System.Drawing.Point(368, 109);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(118, 30);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.lbldesc.Location = new System.Drawing.Point(10, 83);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(317, 23);
            this.lbldesc.TabIndex = 5;
            this.lbldesc.Text = "The code you have entered is Invalid";
            this.lbldesc.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnClose.Location = new System.Drawing.Point(444, -11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 63);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkPWD
            // 
            this.chkPWD.AutoSize = true;
            this.chkPWD.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.chkPWD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.chkPWD.Location = new System.Drawing.Point(110, 161);
            this.chkPWD.Name = "chkPWD";
            this.chkPWD.Size = new System.Drawing.Size(74, 27);
            this.chkPWD.TabIndex = 8;
            this.chkPWD.Text = "PWD";
            this.chkPWD.UseVisualStyleBackColor = true;
            this.chkPWD.CheckStateChanged += new System.EventHandler(this.chkPWD_CheckStateChanged);
            // 
            // chkSenior
            // 
            this.chkSenior.AutoSize = true;
            this.chkSenior.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.chkSenior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.chkSenior.Location = new System.Drawing.Point(317, 161);
            this.chkSenior.Name = "chkSenior";
            this.chkSenior.Size = new System.Drawing.Size(84, 27);
            this.chkSenior.TabIndex = 9;
            this.chkSenior.Text = "Senior";
            this.chkSenior.UseVisualStyleBackColor = true;
            this.chkSenior.CheckStateChanged += new System.EventHandler(this.chkSenior_CheckStateChanged);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.lbldiscount.Location = new System.Drawing.Point(51, 16);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(133, 23);
            this.lbldiscount.TabIndex = 10;
            this.lbldiscount.Text = "Discount Code";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Location = new System.Drawing.Point(2, 2);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(496, 100);
            this.pnlTop.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.picSenior);
            this.panel2.Controls.Add(this.picPWD);
            this.panel2.Controls.Add(this.chkSenior);
            this.panel2.Controls.Add(this.chkPWD);
            this.panel2.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.panel2.Location = new System.Drawing.Point(2, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 194);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.picDis);
            this.panel1.Controls.Add(this.lbldesc);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.lbldiscount);
            this.panel1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.panel1.Location = new System.Drawing.Point(2, 300);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 150);
            this.panel1.TabIndex = 13;
            // 
            // picDis
            // 
            this.picDis.Image = global::RestaurantSystem.Properties.Resources._3;
            this.picDis.Location = new System.Drawing.Point(10, 10);
            this.picDis.Name = "picDis";
            this.picDis.Size = new System.Drawing.Size(35, 35);
            this.picDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDis.TabIndex = 11;
            this.picDis.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystem.Properties.Resources.restaurant_logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picSenior
            // 
            this.picSenior.Image = global::RestaurantSystem.Properties.Resources._2;
            this.picSenior.Location = new System.Drawing.Point(285, 5);
            this.picSenior.Name = "picSenior";
            this.picSenior.Size = new System.Drawing.Size(150, 150);
            this.picSenior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSenior.TabIndex = 11;
            this.picSenior.TabStop = false;
            this.picSenior.Click += new System.EventHandler(this.picSenior_Click);
            // 
            // picPWD
            // 
            this.picPWD.Image = global::RestaurantSystem.Properties.Resources._1__1_;
            this.picPWD.Location = new System.Drawing.Point(72, 5);
            this.picPWD.Name = "picPWD";
            this.picPWD.Size = new System.Drawing.Size(150, 150);
            this.picPWD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPWD.TabIndex = 10;
            this.picPWD.TabStop = false;
            this.picPWD.Click += new System.EventHandler(this.picPWD_Click);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(500, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiscountForm";
            this.Load += new System.EventHandler(this.DiscountForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPWD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkPWD;
        private System.Windows.Forms.CheckBox chkSenior;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picDis;
        private System.Windows.Forms.PictureBox picSenior;
        private System.Windows.Forms.PictureBox picPWD;
    }
}