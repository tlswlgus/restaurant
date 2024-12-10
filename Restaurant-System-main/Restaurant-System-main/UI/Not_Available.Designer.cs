namespace RestaurantSystem.UI
{
    partial class Not_Available
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSorry = new System.Windows.Forms.Label();
            this.picSorry = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblNotAvail = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSorry)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.pnlTop.Controls.Add(this.picSorry);
            this.pnlTop.Controls.Add(this.lblSorry);
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Location = new System.Drawing.Point(2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(796, 446);
            this.pnlTop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.lblNotAvail);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 223);
            this.panel2.TabIndex = 0;
            // 
            // lblSorry
            // 
            this.lblSorry.AutoSize = true;
            this.lblSorry.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.lblSorry.Location = new System.Drawing.Point(308, 175);
            this.lblSorry.Margin = new System.Windows.Forms.Padding(5);
            this.lblSorry.Name = "lblSorry";
            this.lblSorry.Size = new System.Drawing.Size(152, 41);
            this.lblSorry.TabIndex = 2;
            this.lblSorry.Text = "Sorry.. :(";
            // 
            // picSorry
            // 
            this.picSorry.Image = global::RestaurantSystem.Properties.Resources.Test;
            this.picSorry.Location = new System.Drawing.Point(303, 5);
            this.picSorry.Name = "picSorry";
            this.picSorry.Size = new System.Drawing.Size(162, 162);
            this.picSorry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSorry.TabIndex = 3;
            this.picSorry.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(288, 116);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(194, 59);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // lblNotAvail
            // 
            this.lblNotAvail.AutoSize = true;
            this.lblNotAvail.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAvail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.lblNotAvail.Location = new System.Drawing.Point(160, 39);
            this.lblNotAvail.Margin = new System.Windows.Forms.Padding(5);
            this.lblNotAvail.Name = "lblNotAvail";
            this.lblNotAvail.Size = new System.Drawing.Size(454, 41);
            this.lblNotAvail.TabIndex = 4;
            this.lblNotAvail.Text = "This Service is Not Available";
            // 
            // Not_Available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Not_Available";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Not_Available";
            this.Load += new System.EventHandler(this.Not_Available_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSorry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSorry;
        private System.Windows.Forms.PictureBox picSorry;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblNotAvail;
    }
}