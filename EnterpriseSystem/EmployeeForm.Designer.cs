namespace EnterpriseSystem
{
    partial class EmployeeForm
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
            this.GetProducts_button = new System.Windows.Forms.Button();
            this.CreateProduct_button = new System.Windows.Forms.Button();
            this.EmployeeHeader_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetProducts_button
            // 
            this.GetProducts_button.BackColor = System.Drawing.Color.Purple;
            this.GetProducts_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetProducts_button.ForeColor = System.Drawing.Color.White;
            this.GetProducts_button.Location = new System.Drawing.Point(12, 230);
            this.GetProducts_button.Name = "GetProducts_button";
            this.GetProducts_button.Size = new System.Drawing.Size(458, 100);
            this.GetProducts_button.TabIndex = 7;
            this.GetProducts_button.Text = "Get products list";
            this.GetProducts_button.UseVisualStyleBackColor = false;
            this.GetProducts_button.Click += new System.EventHandler(this.GetProducts_button_Click);
            // 
            // CreateProduct_button
            // 
            this.CreateProduct_button.BackColor = System.Drawing.Color.Purple;
            this.CreateProduct_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProduct_button.ForeColor = System.Drawing.Color.White;
            this.CreateProduct_button.Location = new System.Drawing.Point(12, 124);
            this.CreateProduct_button.Name = "CreateProduct_button";
            this.CreateProduct_button.Size = new System.Drawing.Size(458, 100);
            this.CreateProduct_button.TabIndex = 6;
            this.CreateProduct_button.Text = "Create product";
            this.CreateProduct_button.UseVisualStyleBackColor = false;
            this.CreateProduct_button.Click += new System.EventHandler(this.CreateProduct_button_Click);
            // 
            // EmployeeHeader_label
            // 
            this.EmployeeHeader_label.AutoSize = true;
            this.EmployeeHeader_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeHeader_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeHeader_label.Location = new System.Drawing.Point(12, 32);
            this.EmployeeHeader_label.Name = "EmployeeHeader_label";
            this.EmployeeHeader_label.Size = new System.Drawing.Size(241, 62);
            this.EmployeeHeader_label.TabIndex = 8;
            this.EmployeeHeader_label.Text = "Employee";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.EmployeeHeader_label);
            this.Controls.Add(this.GetProducts_button);
            this.Controls.Add(this.CreateProduct_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetProducts_button;
        private Button CreateProduct_button;
        private Label EmployeeHeader_label;
    }
}