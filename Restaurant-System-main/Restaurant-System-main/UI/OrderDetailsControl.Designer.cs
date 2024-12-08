namespace RestaurantSystem.UI
{
    partial class OrderDetailsControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderName = new System.Windows.Forms.Label();
            this.orderPrice = new System.Windows.Forms.Label();
            this.orderQuantity = new System.Windows.Forms.Label();
            this.orderTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // orderName
            // 
            this.orderName.AutoSize = true;
            this.orderName.Location = new System.Drawing.Point(150, 23);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(44, 16);
            this.orderName.TabIndex = 1;
            this.orderName.Text = "label1";
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSize = true;
            this.orderPrice.Location = new System.Drawing.Point(150, 62);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(44, 16);
            this.orderPrice.TabIndex = 2;
            this.orderPrice.Text = "label1";
            // 
            // orderQuantity
            // 
            this.orderQuantity.AutoSize = true;
            this.orderQuantity.Location = new System.Drawing.Point(226, 62);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(44, 16);
            this.orderQuantity.TabIndex = 3;
            this.orderQuantity.Text = "label1";
            // 
            // orderTotalPrice
            // 
            this.orderTotalPrice.AutoSize = true;
            this.orderTotalPrice.Location = new System.Drawing.Point(323, 62);
            this.orderTotalPrice.Name = "orderTotalPrice";
            this.orderTotalPrice.Size = new System.Drawing.Size(44, 16);
            this.orderTotalPrice.TabIndex = 4;
            this.orderTotalPrice.Text = "label1";
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderTotalPrice);
            this.Controls.Add(this.orderQuantity);
            this.Controls.Add(this.orderPrice);
            this.Controls.Add(this.orderName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(383, 118);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label orderName;
        private System.Windows.Forms.Label orderPrice;
        private System.Windows.Forms.Label orderQuantity;
        private System.Windows.Forms.Label orderTotalPrice;
    }
}
