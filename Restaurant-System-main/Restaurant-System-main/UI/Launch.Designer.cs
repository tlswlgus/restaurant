namespace RestaurantSystem.UI
{
    partial class Launch
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
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.btnDine = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.pnlLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.label1);
            this.pnlLabel.Controls.Add(this.pictureBox1);
            this.pnlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.pnlLabel.Location = new System.Drawing.Point(12, 45);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(703, 184);
            this.pnlLabel.TabIndex = 1;
            this.pnlLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLabel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leannè de Fontaine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystem.Properties.Resources.restaurant_logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlClick
            // 
            this.pnlClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.pnlClick.Controls.Add(this.btnTake);
            this.pnlClick.Controls.Add(this.btnDine);
            this.pnlClick.Controls.Add(this.lblStart);
            this.pnlClick.Controls.Add(this.picStart);
            this.pnlClick.Location = new System.Drawing.Point(137, 274);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(324, 452);
            this.pnlClick.TabIndex = 2;
            this.pnlClick.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClick_Paint);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Georgia", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Black;
            this.lblStart.Location = new System.Drawing.Point(10, 145);
            this.lblStart.Margin = new System.Windows.Forms.Padding(10);
            this.lblStart.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(382, 98);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Where will you be eating today?";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.picStart.Image = global::RestaurantSystem.Properties.Resources.picSpoon_Image;
            this.picStart.Location = new System.Drawing.Point(0, 20);
            this.picStart.Margin = new System.Windows.Forms.Padding(10);
            this.picStart.Name = "picStart";
            this.picStart.Padding = new System.Windows.Forms.Padding(10);
            this.picStart.Size = new System.Drawing.Size(97, 100);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 0;
            this.picStart.TabStop = false;
            // 
            // btnDine
            // 
            this.btnDine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnDine.FlatAppearance.BorderSize = 3;
            this.btnDine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDine.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnDine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnDine.Location = new System.Drawing.Point(0, 288);
            this.btnDine.Margin = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.btnDine.Name = "btnDine";
            this.btnDine.Size = new System.Drawing.Size(215, 70);
            this.btnDine.TabIndex = 2;
            this.btnDine.Text = "Dine-In";
            this.btnDine.UseVisualStyleBackColor = false;
            this.btnDine.Click += new System.EventHandler(this.btnDine_Click);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnTake.FlatAppearance.BorderSize = 3;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTake.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnTake.Location = new System.Drawing.Point(0, 377);
            this.btnTake.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(215, 70);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "Take-Out";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(936, 817);
            this.Controls.Add(this.pnlClick);
            this.Controls.Add(this.pnlLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launch";
            this.Text = "Launch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Launch_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Launch_Paint);
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlClick.ResumeLayout(false);
            this.pnlClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlClick;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnDine;
        private System.Windows.Forms.Button btnTake;
    }
}