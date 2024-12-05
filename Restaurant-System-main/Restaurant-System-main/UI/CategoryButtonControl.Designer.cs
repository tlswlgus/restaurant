namespace RestaurantSystem.UI
{
    partial class CategoryButtonControl
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.AutoSize = true;
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategory.Location = new System.Drawing.Point(5, 5);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(109, 43);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "HATDOG!";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // CategoryButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCategory);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(80, 10, 80, 10);
            this.Name = "CategoryButtonControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(119, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
    }
}
