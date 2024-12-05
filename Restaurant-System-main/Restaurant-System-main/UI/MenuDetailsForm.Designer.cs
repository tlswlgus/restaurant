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
            this.customerOrderDetails = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.orderSides = new System.Windows.Forms.Button();
            this.orderToppings = new System.Windows.Forms.Button();
            this.orderPreferences = new System.Windows.Forms.Button();
            this.orderReset = new System.Windows.Forms.Button();
            this.pnlDetailRight = new System.Windows.Forms.Panel();
            this.itemIngredients = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlDetailRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
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
            this.itemName.Location = new System.Drawing.Point(59, 0);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(283, 41);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Name of the food";
            // 
            // itemDescription
            // 
            this.itemDescription.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.itemDescription.Location = new System.Drawing.Point(14, 50);
            this.itemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemDescription.Size = new System.Drawing.Size(368, 230);
            this.itemDescription.TabIndex = 3;
            this.itemDescription.Text = resources.GetString("itemDescription.Text");
            this.itemDescription.Click += new System.EventHandler(this.itemDescription_Click);
            // 
            // listIngredients
            // 
            this.listIngredients.Font = new System.Drawing.Font("Georgia", 12F);
            this.listIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.listIngredients.Location = new System.Drawing.Point(14, 347);
            this.listIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listIngredients.Size = new System.Drawing.Size(368, 76);
            this.listIngredients.TabIndex = 3;
            this.listIngredients.Text = "More in-depth description about the food. \r\nMore in-depth description about the f" +
    "ood. \r\nMore in-depth description about the food. ";
            // 
            // itemPriceDetails
            // 
            this.itemPriceDetails.AutoSize = true;
            this.itemPriceDetails.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.itemPriceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.itemPriceDetails.Location = new System.Drawing.Point(7, 385);
            this.itemPriceDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemPriceDetails.Name = "itemPriceDetails";
            this.itemPriceDetails.Size = new System.Drawing.Size(54, 23);
            this.itemPriceDetails.TabIndex = 2;
            this.itemPriceDetails.Text = "Price";
            // 
            // customerOrderDetails
            // 
            this.customerOrderDetails.AutoSize = true;
            this.customerOrderDetails.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.customerOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customerOrderDetails.Location = new System.Drawing.Point(7, 430);
            this.customerOrderDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerOrderDetails.Name = "customerOrderDetails";
            this.customerOrderDetails.Size = new System.Drawing.Size(159, 23);
            this.customerOrderDetails.TabIndex = 4;
            this.customerOrderDetails.Text = "Customize Order:";
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnOrder.Location = new System.Drawing.Point(320, 408);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(70, 33);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // orderSides
            // 
            this.orderSides.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.orderSides.FlatAppearance.BorderSize = 2;
            this.orderSides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderSides.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSides.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderSides.Location = new System.Drawing.Point(11, 468);
            this.orderSides.Margin = new System.Windows.Forms.Padding(2);
            this.orderSides.Name = "orderSides";
            this.orderSides.Size = new System.Drawing.Size(110, 30);
            this.orderSides.TabIndex = 1;
            this.orderSides.Text = "Sides";
            this.orderSides.UseVisualStyleBackColor = true;
            this.orderSides.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderToppings
            // 
            this.orderToppings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.orderToppings.FlatAppearance.BorderSize = 2;
            this.orderToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderToppings.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderToppings.Location = new System.Drawing.Point(131, 468);
            this.orderToppings.Margin = new System.Windows.Forms.Padding(2);
            this.orderToppings.Name = "orderToppings";
            this.orderToppings.Size = new System.Drawing.Size(110, 30);
            this.orderToppings.TabIndex = 1;
            this.orderToppings.Text = "Toppings";
            this.orderToppings.UseVisualStyleBackColor = true;
            this.orderToppings.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderPreferences
            // 
            this.orderPreferences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.orderPreferences.FlatAppearance.BorderSize = 2;
            this.orderPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderPreferences.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPreferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderPreferences.Location = new System.Drawing.Point(251, 468);
            this.orderPreferences.Margin = new System.Windows.Forms.Padding(2);
            this.orderPreferences.Name = "orderPreferences";
            this.orderPreferences.Size = new System.Drawing.Size(110, 30);
            this.orderPreferences.TabIndex = 1;
            this.orderPreferences.Text = "Preferences";
            this.orderPreferences.UseVisualStyleBackColor = true;
            this.orderPreferences.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderReset
            // 
            this.orderReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.orderReset.FlatAppearance.BorderSize = 2;
            this.orderReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderReset.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderReset.Location = new System.Drawing.Point(291, 428);
            this.orderReset.Margin = new System.Windows.Forms.Padding(2);
            this.orderReset.Name = "orderReset";
            this.orderReset.Size = new System.Drawing.Size(70, 30);
            this.orderReset.TabIndex = 1;
            this.orderReset.Text = "Reset";
            this.orderReset.UseVisualStyleBackColor = true;
            this.orderReset.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlDetailRight
            // 
            this.pnlDetailRight.Controls.Add(this.pictureBox1);
            this.pnlDetailRight.Controls.Add(this.btnOrder);
            this.pnlDetailRight.Controls.Add(this.itemName);
            this.pnlDetailRight.Controls.Add(this.listIngredients);
            this.pnlDetailRight.Controls.Add(this.itemIngredients);
            this.pnlDetailRight.Controls.Add(this.itemDescription);
            this.pnlDetailRight.Location = new System.Drawing.Point(373, 56);
            this.pnlDetailRight.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnlDetailRight.Name = "pnlDetailRight";
            this.pnlDetailRight.Size = new System.Drawing.Size(395, 446);
            this.pnlDetailRight.TabIndex = 5;
            this.pnlDetailRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetailRight_Paint);
            // 
            // itemIngredients
            // 
            this.itemIngredients.AutoSize = true;
            this.itemIngredients.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.itemIngredients.Location = new System.Drawing.Point(67, 311);
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
            this.btnPlus.Location = new System.Drawing.Point(326, 379);
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
            this.btnMinus.Location = new System.Drawing.Point(248, 379);
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
            this.label1.Location = new System.Drawing.Point(178, 385);
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
            this.lblQuantity.Location = new System.Drawing.Point(287, 379);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 35);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "0";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystem.Properties.Resources.lblIngredients_Image;
            this.pictureBox1.Location = new System.Drawing.Point(17, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBack.Image = global::RestaurantSystem.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(685, 11);
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
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetails.Image")));
            this.pictureBoxDetails.Location = new System.Drawing.Point(11, 17);
            this.pictureBoxDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetails.TabIndex = 0;
            this.pictureBoxDetails.TabStop = false;
            // 
            // MenuDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 511);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.pnlDetailRight);
            this.Controls.Add(this.customerOrderDetails);
            this.Controls.Add(this.itemPriceDetails);
            this.Controls.Add(this.orderReset);
            this.Controls.Add(this.orderPreferences);
            this.Controls.Add(this.orderToppings);
            this.Controls.Add(this.orderSides);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBoxDetails);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label customerOrderDetails;
        private System.Windows.Forms.Label listIngredients;
        private System.Windows.Forms.Label itemPriceDetails;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button orderReset;
        private System.Windows.Forms.Button orderPreferences;
        private System.Windows.Forms.Button orderToppings;
        private System.Windows.Forms.Button orderSides;
        private System.Windows.Forms.Panel pnlDetailRight;
        private System.Windows.Forms.Label itemIngredients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblQuantity;
    }
}