namespace Medical_information
{
    partial class employee_history_Form
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
            this.employee_history_dataGridView = new System.Windows.Forms.DataGridView();
            this.employee_history_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_history_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_history_dataGridView
            // 
            this.employee_history_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_history_dataGridView.Location = new System.Drawing.Point(147, 96);
            this.employee_history_dataGridView.Name = "employee_history_dataGridView";
            this.employee_history_dataGridView.RowTemplate.Height = 24;
            this.employee_history_dataGridView.Size = new System.Drawing.Size(571, 155);
            this.employee_history_dataGridView.TabIndex = 0;
            // 
            // employee_history_button
            // 
            this.employee_history_button.Location = new System.Drawing.Point(410, 294);
            this.employee_history_button.Name = "employee_history_button";
            this.employee_history_button.Size = new System.Drawing.Size(75, 23);
            this.employee_history_button.TabIndex = 1;
            this.employee_history_button.Text = "Back";
            this.employee_history_button.UseVisualStyleBackColor = true;
            this.employee_history_button.Click += new System.EventHandler(this.employee_history_button_Click);
            // 
            // employee_history_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employee_history_button);
            this.Controls.Add(this.employee_history_dataGridView);
            this.Name = "employee_history_Form";
            this.Text = "employee_history_Form";
            this.Load += new System.EventHandler(this.employee_history_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_history_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_history_dataGridView;
        private System.Windows.Forms.Button employee_history_button;
    }
}