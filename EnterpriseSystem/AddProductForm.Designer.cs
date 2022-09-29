namespace EnterpriseSystem
{
    partial class AddProductForm
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
            this.ProductSellingPrice_textBox = new System.Windows.Forms.TextBox();
            this.ProductType_textBox = new System.Windows.Forms.TextBox();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.AddProduct_label = new System.Windows.Forms.Label();
            this.ClearFields_button = new System.Windows.Forms.Button();
            this.CreateProduct_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductSellingPrice_textBox
            // 
            this.ProductSellingPrice_textBox.Location = new System.Drawing.Point(118, 169);
            this.ProductSellingPrice_textBox.Name = "ProductSellingPrice_textBox";
            this.ProductSellingPrice_textBox.PlaceholderText = "Selling price";
            this.ProductSellingPrice_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductSellingPrice_textBox.TabIndex = 10;
            this.ProductSellingPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductSellingPrice_textBox_KeyPress);
            // 
            // ProductType_textBox
            // 
            this.ProductType_textBox.Location = new System.Drawing.Point(118, 136);
            this.ProductType_textBox.Name = "ProductType_textBox";
            this.ProductType_textBox.PlaceholderText = "Type";
            this.ProductType_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductType_textBox.TabIndex = 9;
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(118, 103);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.PlaceholderText = "Name";
            this.ProductName_textBox.Size = new System.Drawing.Size(216, 27);
            this.ProductName_textBox.TabIndex = 8;
            // 
            // AddProduct_label
            // 
            this.AddProduct_label.AutoSize = true;
            this.AddProduct_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProduct_label.ForeColor = System.Drawing.Color.White;
            this.AddProduct_label.Location = new System.Drawing.Point(12, 19);
            this.AddProduct_label.Name = "AddProduct_label";
            this.AddProduct_label.Size = new System.Drawing.Size(447, 62);
            this.AddProduct_label.TabIndex = 12;
            this.AddProduct_label.Text = "Add a new product";
            // 
            // ClearFields_button
            // 
            this.ClearFields_button.BackColor = System.Drawing.Color.DarkRed;
            this.ClearFields_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFields_button.ForeColor = System.Drawing.Color.White;
            this.ClearFields_button.Location = new System.Drawing.Point(118, 279);
            this.ClearFields_button.Name = "ClearFields_button";
            this.ClearFields_button.Size = new System.Drawing.Size(216, 65);
            this.ClearFields_button.TabIndex = 15;
            this.ClearFields_button.Text = "Clear fields";
            this.ClearFields_button.UseVisualStyleBackColor = false;
            this.ClearFields_button.Click += new System.EventHandler(this.ClearFields_button_Click);
            // 
            // CreateProduct_button
            // 
            this.CreateProduct_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProduct_button.ForeColor = System.Drawing.Color.White;
            this.CreateProduct_button.Location = new System.Drawing.Point(118, 208);
            this.CreateProduct_button.Name = "CreateProduct_button";
            this.CreateProduct_button.Size = new System.Drawing.Size(216, 65);
            this.CreateProduct_button.TabIndex = 14;
            this.CreateProduct_button.Text = "Add";
            this.CreateProduct_button.UseVisualStyleBackColor = false;
            this.CreateProduct_button.Click += new System.EventHandler(this.CreateProduct_button_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 363);
            this.Controls.Add(this.ClearFields_button);
            this.Controls.Add(this.CreateProduct_button);
            this.Controls.Add(this.AddProduct_label);
            this.Controls.Add(this.ProductSellingPrice_textBox);
            this.Controls.Add(this.ProductType_textBox);
            this.Controls.Add(this.ProductName_textBox);
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox ProductSellingPrice_textBox;
        private TextBox ProductType_textBox;
        private TextBox ProductName_textBox;
        private Label AddProduct_label;
        private Button ClearFields_button;
        private Button CreateProduct_button;
    }
}