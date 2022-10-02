namespace EnterpriseSystem
{
    partial class UpdateProductForm
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
            this.ClearFields_button = new System.Windows.Forms.Button();
            this.EditProduct_button = new System.Windows.Forms.Button();
            this.EditProduct_label = new System.Windows.Forms.Label();
            this.ProductSellingPrice_textBox = new System.Windows.Forms.TextBox();
            this.ProductType_textBox = new System.Windows.Forms.TextBox();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClearFields_button
            // 
            this.ClearFields_button.BackColor = System.Drawing.Color.DarkRed;
            this.ClearFields_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFields_button.ForeColor = System.Drawing.Color.White;
            this.ClearFields_button.Location = new System.Drawing.Point(124, 279);
            this.ClearFields_button.Name = "ClearFields_button";
            this.ClearFields_button.Size = new System.Drawing.Size(216, 65);
            this.ClearFields_button.TabIndex = 21;
            this.ClearFields_button.Text = "Clear fields";
            this.ClearFields_button.UseVisualStyleBackColor = false;
            this.ClearFields_button.Click += new System.EventHandler(this.ClearFields_button_Click);
            // 
            // EditProduct_button
            // 
            this.EditProduct_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditProduct_button.ForeColor = System.Drawing.Color.White;
            this.EditProduct_button.Location = new System.Drawing.Point(124, 208);
            this.EditProduct_button.Name = "EditProduct_button";
            this.EditProduct_button.Size = new System.Drawing.Size(216, 65);
            this.EditProduct_button.TabIndex = 20;
            this.EditProduct_button.Text = "Edit";
            this.EditProduct_button.UseVisualStyleBackColor = false;
            this.EditProduct_button.Click += new System.EventHandler(this.EditProduct_button_Click);
            // 
            // EditProduct_label
            // 
            this.EditProduct_label.AutoSize = true;
            this.EditProduct_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditProduct_label.ForeColor = System.Drawing.Color.White;
            this.EditProduct_label.Location = new System.Drawing.Point(18, 19);
            this.EditProduct_label.Name = "EditProduct_label";
            this.EditProduct_label.Size = new System.Drawing.Size(300, 62);
            this.EditProduct_label.TabIndex = 19;
            this.EditProduct_label.Text = "Edit Product";
            // 
            // ProductSellingPrice_textBox
            // 
            this.ProductSellingPrice_textBox.Location = new System.Drawing.Point(124, 169);
            this.ProductSellingPrice_textBox.Name = "ProductSellingPrice_textBox";
            this.ProductSellingPrice_textBox.PlaceholderText = "Selling price";
            this.ProductSellingPrice_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductSellingPrice_textBox.TabIndex = 18;
            this.ProductSellingPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductSellingPrice_textBox_KeyPress);
            // 
            // ProductType_textBox
            // 
            this.ProductType_textBox.Location = new System.Drawing.Point(124, 136);
            this.ProductType_textBox.Name = "ProductType_textBox";
            this.ProductType_textBox.PlaceholderText = "Type";
            this.ProductType_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductType_textBox.TabIndex = 17;
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(124, 103);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.PlaceholderText = "Name";
            this.ProductName_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductName_textBox.TabIndex = 16;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 363);
            this.Controls.Add(this.ClearFields_button);
            this.Controls.Add(this.EditProduct_button);
            this.Controls.Add(this.EditProduct_label);
            this.Controls.Add(this.ProductSellingPrice_textBox);
            this.Controls.Add(this.ProductType_textBox);
            this.Controls.Add(this.ProductName_textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 410);
            this.MinimumSize = new System.Drawing.Size(500, 410);
            this.Name = "UpdateProductForm";
            this.Text = "Edit product";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClearFields_button;
        private Button EditProduct_button;
        private Label EditProduct_label;
        private TextBox ProductSellingPrice_textBox;
        private TextBox ProductType_textBox;
        private TextBox ProductName_textBox;
    }
}