namespace EnterpriseSystem
{
    partial class GetProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetProductsForm));
            this.GetProducts_label = new System.Windows.Forms.Label();
            this.Products_listBox = new System.Windows.Forms.ListBox();
            this.DeleteProduct_button = new System.Windows.Forms.Button();
            this.EditProduct_button = new System.Windows.Forms.Button();
            this.SearchProduct_TextBox = new System.Windows.Forms.TextBox();
            this.SearchProduct_Button = new System.Windows.Forms.Button();
            this.SearchKey_comboBox = new System.Windows.Forms.ComboBox();
            this.SortProducts_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetProducts_label
            // 
            this.GetProducts_label.AutoSize = true;
            this.GetProducts_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetProducts_label.ForeColor = System.Drawing.Color.White;
            this.GetProducts_label.Location = new System.Drawing.Point(12, 12);
            this.GetProducts_label.Name = "GetProducts_label";
            this.GetProducts_label.Size = new System.Drawing.Size(312, 62);
            this.GetProducts_label.TabIndex = 20;
            this.GetProducts_label.Text = "Get products";
            // 
            // Products_listBox
            // 
            this.Products_listBox.FormattingEnabled = true;
            this.Products_listBox.HorizontalScrollbar = true;
            this.Products_listBox.ItemHeight = 20;
            this.Products_listBox.Location = new System.Drawing.Point(12, 121);
            this.Products_listBox.Name = "Products_listBox";
            this.Products_listBox.Size = new System.Drawing.Size(584, 344);
            this.Products_listBox.TabIndex = 19;
            this.Products_listBox.SelectedIndexChanged += new System.EventHandler(this.Products_listBox_SelectedIndexChanged);
            this.Products_listBox.DoubleClick += new System.EventHandler(this.Products_listBox_DoubleClick);
            // 
            // DeleteProduct_button
            // 
            this.DeleteProduct_button.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteProduct_button.ForeColor = System.Drawing.Color.White;
            this.DeleteProduct_button.Location = new System.Drawing.Point(336, 471);
            this.DeleteProduct_button.Name = "DeleteProduct_button";
            this.DeleteProduct_button.Size = new System.Drawing.Size(260, 65);
            this.DeleteProduct_button.TabIndex = 18;
            this.DeleteProduct_button.Text = "Delete";
            this.DeleteProduct_button.UseVisualStyleBackColor = false;
            this.DeleteProduct_button.Click += new System.EventHandler(this.DeleteProduct_button_Click);
            // 
            // EditProduct_button
            // 
            this.EditProduct_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditProduct_button.ForeColor = System.Drawing.Color.White;
            this.EditProduct_button.Location = new System.Drawing.Point(12, 471);
            this.EditProduct_button.Name = "EditProduct_button";
            this.EditProduct_button.Size = new System.Drawing.Size(260, 65);
            this.EditProduct_button.TabIndex = 17;
            this.EditProduct_button.Text = "Edit";
            this.EditProduct_button.UseVisualStyleBackColor = false;
            this.EditProduct_button.Click += new System.EventHandler(this.EditProduct_button_Click);
            // 
            // SearchProduct_TextBox
            // 
            this.SearchProduct_TextBox.Location = new System.Drawing.Point(131, 88);
            this.SearchProduct_TextBox.Name = "SearchProduct_TextBox";
            this.SearchProduct_TextBox.Size = new System.Drawing.Size(216, 27);
            this.SearchProduct_TextBox.TabIndex = 21;
            // 
            // SearchProduct_Button
            // 
            this.SearchProduct_Button.Location = new System.Drawing.Point(353, 88);
            this.SearchProduct_Button.Name = "SearchProduct_Button";
            this.SearchProduct_Button.Size = new System.Drawing.Size(117, 27);
            this.SearchProduct_Button.TabIndex = 22;
            this.SearchProduct_Button.Text = "Search";
            this.SearchProduct_Button.UseVisualStyleBackColor = true;
            this.SearchProduct_Button.Click += new System.EventHandler(this.SearchProduct_Button_Click);
            // 
            // SearchKey_comboBox
            // 
            this.SearchKey_comboBox.FormattingEnabled = true;
            this.SearchKey_comboBox.Location = new System.Drawing.Point(12, 87);
            this.SearchKey_comboBox.Name = "SearchKey_comboBox";
            this.SearchKey_comboBox.Size = new System.Drawing.Size(113, 28);
            this.SearchKey_comboBox.TabIndex = 23;
            // 
            // SortProducts_button
            // 
            this.SortProducts_button.Location = new System.Drawing.Point(476, 88);
            this.SortProducts_button.Name = "SortProducts_button";
            this.SortProducts_button.Size = new System.Drawing.Size(117, 27);
            this.SortProducts_button.TabIndex = 24;
            this.SortProducts_button.Text = "Sort";
            this.SortProducts_button.UseVisualStyleBackColor = true;
            this.SortProducts_button.Click += new System.EventHandler(this.SortProducts_button_Click);
            // 
            // GetProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.SortProducts_button);
            this.Controls.Add(this.SearchKey_comboBox);
            this.Controls.Add(this.SearchProduct_Button);
            this.Controls.Add(this.SearchProduct_TextBox);
            this.Controls.Add(this.GetProducts_label);
            this.Controls.Add(this.Products_listBox);
            this.Controls.Add(this.DeleteProduct_button);
            this.Controls.Add(this.EditProduct_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 595);
            this.MinimumSize = new System.Drawing.Size(627, 595);
            this.Name = "GetProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.GetProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GetProducts_label;
        private ListBox Products_listBox;
        private Button DeleteProduct_button;
        private Button EditProduct_button;
        private TextBox SearchProduct_TextBox;
        private Button SearchProduct_Button;
        private ComboBox SearchKey_comboBox;
        private Button SortProducts_button;
    }
}