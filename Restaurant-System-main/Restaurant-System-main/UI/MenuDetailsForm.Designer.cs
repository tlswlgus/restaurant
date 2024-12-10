namespace RestaurantSystem.UI
{
    partial class MenuDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDetailsForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.itemName = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.Label();
            this.listIngredients = new System.Windows.Forms.Label();
            this.itemPriceDetails = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlDetailRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemIngredients = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.itemImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlDetailRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.itemName.Location = new System.Drawing.Point(95, 0);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(283, 41);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Name of the food";
            this.itemName.Click += new System.EventHandler(this.itemName_Click);
            // 
            // itemDescription
            // 
            this.itemDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.itemDescription.Location = new System.Drawing.Point(10, 50);
            this.itemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemDescription.Size = new System.Drawing.Size(454, 205);
            this.itemDescription.TabIndex = 3;
            this.itemDescription.Text = "More in-depth description about the food. ";
            this.itemDescription.Click += new System.EventHandler(this.itemDescription_Click);
            // 
            // listIngredients
            // 
            this.listIngredients.Font = new System.Drawing.Font("Georgia", 12F);
            this.listIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.listIngredients.Location = new System.Drawing.Point(10, 315);
            this.listIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listIngredients.Size = new System.Drawing.Size(454, 62);
            this.listIngredients.TabIndex = 3;
            this.listIngredients.Text = "More in-depth description about the food. \r\nMore in-depth description about the f" +
    "ood. \r\nMore in-depth description about the food. ";
            this.listIngredients.Click += new System.EventHandler(this.listIngredients_Click);
            // 
            // itemPriceDetails
            // 
            this.itemPriceDetails.AutoSize = true;
            this.itemPriceDetails.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.itemPriceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.itemPriceDetails.Location = new System.Drawing.Point(11, 373);
            this.itemPriceDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemPriceDetails.Name = "itemPriceDetails";
            this.itemPriceDetails.Size = new System.Drawing.Size(54, 23);
            this.itemPriceDetails.TabIndex = 2;
            this.itemPriceDetails.Text = "Price";
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnOrder.Location = new System.Drawing.Point(400, 351);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(70, 33);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnlDetailRight
            // 
            this.pnlDetailRight.Controls.Add(this.pictureBox1);
            this.pnlDetailRight.Controls.Add(this.btnOrder);
            this.pnlDetailRight.Controls.Add(this.itemName);
            this.pnlDetailRight.Controls.Add(this.listIngredients);
            this.pnlDetailRight.Controls.Add(this.itemIngredients);
            this.pnlDetailRight.Controls.Add(this.itemDescription);
            this.pnlDetailRight.Location = new System.Drawing.Point(373, 24);
            this.pnlDetailRight.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnlDetailRight.Name = "pnlDetailRight";
            this.pnlDetailRight.Size = new System.Drawing.Size(477, 390);
            this.pnlDetailRight.TabIndex = 5;
            this.pnlDetailRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetailRight_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystem.Properties.Resources.lblIngredients_Image;
            this.pictureBox1.Location = new System.Drawing.Point(13, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // itemIngredients
            // 
            this.itemIngredients.AutoSize = true;
            this.itemIngredients.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.itemIngredients.Location = new System.Drawing.Point(63, 287);
            this.itemIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemIngredients.Name = "itemIngredients";
            this.itemIngredients.Size = new System.Drawing.Size(146, 25);
            this.itemIngredients.TabIndex = 2;
            this.itemIngredients.Text = "Ingredients:";
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnPlus.FlatAppearance.BorderSize = 2;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPlus.Location = new System.Drawing.Point(326, 367);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnMinus.FlatAppearance.BorderSize = 2;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnMinus.Location = new System.Drawing.Point(248, 367);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 35);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(178, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblQuantity.Location = new System.Drawing.Point(287, 367);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 35);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "0";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBack.Image = global::RestaurantSystem.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(760, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // itemImage
            // 
            this.itemImage.Image = ((System.Drawing.Image)(resources.GetObject("itemImage.Image")));
            this.itemImage.Location = new System.Drawing.Point(11, 24);
            this.itemImage.Margin = new System.Windows.Forms.Padding(2);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(350, 330);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // MenuDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(863, 423);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.pnlDetailRight);
            this.Controls.Add(this.itemPriceDetails);
            this.Controls.Add(this.itemImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuDetailsForm";
            this.Load += new System.EventHandler(this.MenuDetailsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuDetailsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlDetailRight.ResumeLayout(false);
            this.pnlDetailRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label listIngredients;
        private System.Windows.Forms.Label itemPriceDetails;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlDetailRight;
        private System.Windows.Forms.Label itemIngredients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblQuantity;
    }
}