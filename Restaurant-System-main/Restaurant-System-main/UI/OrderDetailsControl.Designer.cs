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
            this.picOrder = new System.Windows.Forms.PictureBox();
            this.orderPrice = new System.Windows.Forms.Label();
            this.orderTotalPrice = new System.Windows.Forms.Label();
            this.orderName = new System.Windows.Forms.Label();
            this.btnDelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrder
            // 
            this.picOrder.Location = new System.Drawing.Point(5, 5);
            this.picOrder.Margin = new System.Windows.Forms.Padding(5);
            this.picOrder.Name = "picOrder";
            this.picOrder.Size = new System.Drawing.Size(80, 80);
            this.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrder.TabIndex = 0;
            this.picOrder.TabStop = false;
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSize = true;
            this.orderPrice.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderPrice.Location = new System.Drawing.Point(95, 56);
            this.orderPrice.Margin = new System.Windows.Forms.Padding(5);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(98, 16);
            this.orderPrice.TabIndex = 2;
            this.orderPrice.Text = "₱ 000.00 x 99";
            this.orderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderPrice.Click += new System.EventHandler(this.orderPrice_Click);
            // 
            // orderTotalPrice
            // 
            this.orderTotalPrice.AutoSize = true;
            this.orderTotalPrice.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderTotalPrice.Location = new System.Drawing.Point(192, 54);
            this.orderTotalPrice.Margin = new System.Windows.Forms.Padding(5);
            this.orderTotalPrice.Name = "orderTotalPrice";
            this.orderTotalPrice.Size = new System.Drawing.Size(98, 18);
            this.orderTotalPrice.TabIndex = 4;
            this.orderTotalPrice.Text = "₱ 00000.00";
            this.orderTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderName
            // 
            this.orderName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderName.Location = new System.Drawing.Point(95, 5);
            this.orderName.Margin = new System.Windows.Forms.Padding(5);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(145, 39);
            this.orderName.TabIndex = 1;
            this.orderName.Text = "Name";
            this.orderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderName.Click += new System.EventHandler(this.orderName_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnDelOrder.FlatAppearance.BorderSize = 2;
            this.btnDelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelOrder.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDelOrder.Location = new System.Drawing.Point(255, 5);
            this.btnDelOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(30, 30);
            this.btnDelOrder.TabIndex = 5;
            this.btnDelOrder.Text = "X";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.orderTotalPrice);
            this.Controls.Add(this.orderPrice);
            this.Controls.Add(this.orderName);
            this.Controls.Add(this.picOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(290, 95);
            this.Load += new System.EventHandler(this.OrderDetailsControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderDetailsControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrder;
        private System.Windows.Forms.Label orderPrice;
        private System.Windows.Forms.Label orderTotalPrice;
        private System.Windows.Forms.Label orderName;
        private System.Windows.Forms.Button btnDelOrder;
    }
}
