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
            this.GetProducts_label = new System.Windows.Forms.Label();
            this.Products_listBox = new System.Windows.Forms.ListBox();
            this.DeleteProduct_button = new System.Windows.Forms.Button();
            this.EditProduct_button = new System.Windows.Forms.Button();
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
            this.Products_listBox.Location = new System.Drawing.Point(12, 81);
            this.Products_listBox.Name = "Products_listBox";
            this.Products_listBox.Size = new System.Drawing.Size(458, 384);
            this.Products_listBox.TabIndex = 19;
            // 
            // DeleteProduct_button
            // 
            this.DeleteProduct_button.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteProduct_button.ForeColor = System.Drawing.Color.White;
            this.DeleteProduct_button.Location = new System.Drawing.Point(254, 471);
            this.DeleteProduct_button.Name = "DeleteProduct_button";
            this.DeleteProduct_button.Size = new System.Drawing.Size(216, 65);
            this.DeleteProduct_button.TabIndex = 18;
            this.DeleteProduct_button.Text = "Delete";
            this.DeleteProduct_button.UseVisualStyleBackColor = false;
            this.DeleteProduct_button.Click += new System.EventHandler(this.DeleteProduct_button_Click);
            // 
            // EditProduct_button
            // 
            this.EditProduct_button.BackColor = System.Drawing.Color.Purple;
            this.EditProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditProduct_button.ForeColor = System.Drawing.Color.White;
            this.EditProduct_button.Location = new System.Drawing.Point(12, 471);
            this.EditProduct_button.Name = "EditProduct_button";
            this.EditProduct_button.Size = new System.Drawing.Size(216, 65);
            this.EditProduct_button.TabIndex = 17;
            this.EditProduct_button.Text = "Edit";
            this.EditProduct_button.UseVisualStyleBackColor = false;
            this.EditProduct_button.Click += new System.EventHandler(this.EditProduct_button_Click);
            // 
            // GetProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(482, 548);
            this.Controls.Add(this.GetProducts_label);
            this.Controls.Add(this.Products_listBox);
            this.Controls.Add(this.DeleteProduct_button);
            this.Controls.Add(this.EditProduct_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 595);
            this.MinimumSize = new System.Drawing.Size(500, 595);
            this.Name = "GetProductsForm";
            this.Text = "GetProductsForm";
            this.Load += new System.EventHandler(this.GetProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GetProducts_label;
        private ListBox Products_listBox;
        private Button DeleteProduct_button;
        private Button EditProduct_button;
    }
}