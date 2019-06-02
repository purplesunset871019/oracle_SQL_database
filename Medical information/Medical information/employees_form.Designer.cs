namespace Medical_information
{
    partial class employees_Form
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
            this.employees_dataGridView = new System.Windows.Forms.DataGridView();
            this.employees_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employees_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employees_dataGridView
            // 
            this.employees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees_dataGridView.Location = new System.Drawing.Point(140, 30);
            this.employees_dataGridView.Name = "employees_dataGridView";
            this.employees_dataGridView.Size = new System.Drawing.Size(530, 195);
            this.employees_dataGridView.TabIndex = 0;
            // 
            // employees_button
            // 
            this.employees_button.AutoSize = true;
            this.employees_button.Location = new System.Drawing.Point(364, 304);
            this.employees_button.Name = "employees_button";
            this.employees_button.Size = new System.Drawing.Size(100, 23);
            this.employees_button.TabIndex = 1;
            this.employees_button.Text = "Back";
            this.employees_button.UseVisualStyleBackColor = true;
            this.employees_button.Click += new System.EventHandler(this.employees_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // employees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employees_button);
            this.Controls.Add(this.employees_dataGridView);
            this.Name = "employees_Form";
            this.Text = "employees_form";
            this.Load += new System.EventHandler(this.employees_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employees_dataGridView;
        private System.Windows.Forms.Button employees_button;
        private System.Windows.Forms.Button button1;
    }
}