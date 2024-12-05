namespace RestaurantSystem.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrderDetail = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Logo_Holder = new System.Windows.Forms.PictureBox();
            this.Center_Panel = new System.Windows.Forms.Panel();
            this.pnlbtn = new System.Windows.Forms.Panel();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.btnMainCourse = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.Beverages = new System.Windows.Forms.Button();
            this.flpMenuItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDuscount = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlOrder.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Holder)).BeginInit();
            this.Center_Panel.SuspendLayout();
            this.pnlbtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDuscount.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.pnlOrder.Controls.Add(this.panel1);
            this.pnlOrder.Controls.Add(this.lblOrderDetail);
            this.pnlOrder.Location = new System.Drawing.Point(1013, 2);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(1);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(319, 816);
            this.pnlOrder.TabIndex = 0;
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderDetail.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.lblOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblOrderDetail.Size = new System.Drawing.Size(319, 65);
            this.lblOrderDetail.TabIndex = 2;
            this.lblOrderDetail.Text = "Order Details";
            this.lblOrderDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblRestaurantName);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.Logo_Holder);
            this.pnlHeader.Location = new System.Drawing.Point(2, 2);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1009, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurantName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.lblRestaurantName.Location = new System.Drawing.Point(78, 11);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(146, 68);
            this.lblRestaurantName.TabIndex = 2;
            this.lblRestaurantName.Text = "Leanne De Fontaine";
            this.lblRestaurantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(229, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(763, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Logo_Holder
            // 
            this.Logo_Holder.Image = global::RestaurantSystem.Properties.Resources.restaurant_logo_transparent;
            this.Logo_Holder.Location = new System.Drawing.Point(9, 9);
            this.Logo_Holder.Margin = new System.Windows.Forms.Padding(2);
            this.Logo_Holder.Name = "Logo_Holder";
            this.Logo_Holder.Size = new System.Drawing.Size(73, 71);
            this.Logo_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Holder.TabIndex = 0;
            this.Logo_Holder.TabStop = false;
            // 
            // Center_Panel
            // 
            this.Center_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Center_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.Center_Panel.Controls.Add(this.pnlbtn);
            this.Center_Panel.Controls.Add(this.flpMenuItem);
            this.Center_Panel.Location = new System.Drawing.Point(2, 98);
            this.Center_Panel.Margin = new System.Windows.Forms.Padding(1);
            this.Center_Panel.Name = "Center_Panel";
            this.Center_Panel.Size = new System.Drawing.Size(1009, 721);
            this.Center_Panel.TabIndex = 0;
            // 
            // pnlbtn
            // 
            this.pnlbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlbtn.Controls.Add(this.btnDesserts);
            this.pnlbtn.Controls.Add(this.btnAppetizer);
            this.pnlbtn.Controls.Add(this.btnMainCourse);
            this.pnlbtn.Controls.Add(this.btnAll);
            this.pnlbtn.Controls.Add(this.Beverages);
            this.pnlbtn.Location = new System.Drawing.Point(3, 3);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(1003, 78);
            this.pnlbtn.TabIndex = 2;
            // 
            // btnDesserts
            // 
            this.btnDesserts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesserts.FlatAppearance.BorderSize = 2;
            this.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesserts.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesserts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnDesserts.Image = global::RestaurantSystem.Properties.Resources.btnDessert_Image;
            this.btnDesserts.Location = new System.Drawing.Point(597, 10);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.btnDesserts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDesserts.Size = new System.Drawing.Size(190, 60);
            this.btnDesserts.TabIndex = 0;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnAppetizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppetizer.FlatAppearance.BorderSize = 2;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnAppetizer.Image = ((System.Drawing.Image)(resources.GetObject("btnAppetizer.Image")));
            this.btnAppetizer.Location = new System.Drawing.Point(16, 10);
            this.btnAppetizer.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.btnAppetizer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAppetizer.Size = new System.Drawing.Size(190, 60);
            this.btnAppetizer.TabIndex = 0;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppetizer.UseVisualStyleBackColor = false;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnMainCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCourse.FlatAppearance.BorderSize = 2;
            this.btnMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCourse.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnMainCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCourse.Image")));
            this.btnMainCourse.Location = new System.Drawing.Point(216, 10);
            this.btnMainCourse.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.btnMainCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMainCourse.Size = new System.Drawing.Size(190, 60);
            this.btnMainCourse.TabIndex = 0;
            this.btnMainCourse.Text = "Main Course";
            this.btnMainCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCourse.UseVisualStyleBackColor = false;
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.FlatAppearance.BorderSize = 2;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.Location = new System.Drawing.Point(416, 10);
            this.btnAll.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(1);
            this.btnAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAll.Size = new System.Drawing.Size(171, 60);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Beverages
            // 
            this.Beverages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Beverages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.Beverages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beverages.FlatAppearance.BorderSize = 2;
            this.Beverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beverages.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beverages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.Beverages.Image = ((System.Drawing.Image)(resources.GetObject("Beverages.Image")));
            this.Beverages.Location = new System.Drawing.Point(797, 10);
            this.Beverages.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Beverages.Name = "Beverages";
            this.Beverages.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.Beverages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beverages.Size = new System.Drawing.Size(190, 60);
            this.Beverages.TabIndex = 0;
            this.Beverages.Text = "Beverages";
            this.Beverages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beverages.UseVisualStyleBackColor = false;
            this.Beverages.Click += new System.EventHandler(this.Beverages_Click);
            // 
            // flpMenuItem
            // 
            this.flpMenuItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenuItem.AutoScroll = true;
            this.flpMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.flpMenuItem.Location = new System.Drawing.Point(19, 85);
            this.flpMenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.flpMenuItem.Name = "flpMenuItem";
            this.flpMenuItem.Size = new System.Drawing.Size(990, 635);
            this.flpMenuItem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlAmount);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pnlDuscount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 183);
            this.panel1.TabIndex = 3;
            // 
            // pnlDuscount
            // 
            this.pnlDuscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.pnlDuscount.Controls.Add(this.label3);
            this.pnlDuscount.Controls.Add(this.button1);
            this.pnlDuscount.Location = new System.Drawing.Point(14, 4);
            this.pnlDuscount.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.pnlDuscount.Name = "pnlDuscount";
            this.pnlDuscount.Size = new System.Drawing.Size(290, 47);
            this.pnlDuscount.TabIndex = 0;
            this.pnlDuscount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDuscount_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAmount
            // 
            this.pnlAmount.Controls.Add(this.label2);
            this.pnlAmount.Controls.Add(this.label1);
            this.pnlAmount.Location = new System.Drawing.Point(14, 65);
            this.pnlAmount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(290, 40);
            this.pnlAmount.TabIndex = 3;
            this.pnlAmount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAmount_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(136, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "₱ 00.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 17F);
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Promo Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(152)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1335, 820);
            this.Controls.Add(this.Center_Panel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Restaurant System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Holder)).EndInit();
            this.Center_Panel.ResumeLayout(false);
            this.pnlbtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDuscount.ResumeLayout(false);
            this.pnlDuscount.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel Center_Panel;
        private System.Windows.Forms.PictureBox Logo_Holder;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnMainCourse;
        private System.Windows.Forms.Button Beverages;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Label lblOrderDetail;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItem;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDuscount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

    