namespace Medical_information
{
    partial class employee_salary_Form
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
            this.employee_salary_dataGridView = new System.Windows.Forms.DataGridView();
            this.employee_salary_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_salary_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_salary_dataGridView
            // 
            this.employee_salary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_salary_dataGridView.Location = new System.Drawing.Point(194, 72);
            this.employee_salary_dataGridView.Name = "employee_salary_dataGridView";
            this.employee_salary_dataGridView.RowTemplate.Height = 24;
            this.employee_salary_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.employee_salary_dataGridView.TabIndex = 0;
            // 
            // employee_salary_button
            // 
            this.employee_salary_button.Location = new System.Drawing.Point(277, 280);
            this.employee_salary_button.Name = "employee_salary_button";
            this.employee_salary_button.Size = new System.Drawing.Size(75, 23);
            this.employee_salary_button.TabIndex = 1;
            this.employee_salary_button.Text = "Back";
            this.employee_salary_button.UseVisualStyleBackColor = true;
            this.employee_salary_button.Click += new System.EventHandler(this.employee_salary_button_Click);
            // 
            // employee_salary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employee_salary_button);
            this.Controls.Add(this.employee_salary_dataGridView);
            this.Name = "employee_salary_Form";
            this.Text = "employee_salary_Form";
            this.Load += new System.EventHandler(this.employee_salary_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_salary_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_salary_dataGridView;
        private System.Windows.Forms.Button employee_salary_button;
    }
}