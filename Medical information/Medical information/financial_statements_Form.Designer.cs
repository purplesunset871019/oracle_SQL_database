namespace Medical_information
{
    partial class financial_statements_Form
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
            this.financial_statements_dataGridView = new System.Windows.Forms.DataGridView();
            this.financial_statements_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financial_statements_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // financial_statements_dataGridView
            // 
            this.financial_statements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financial_statements_dataGridView.Location = new System.Drawing.Point(296, 112);
            this.financial_statements_dataGridView.Name = "financial_statements_dataGridView";
            this.financial_statements_dataGridView.RowTemplate.Height = 24;
            this.financial_statements_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.financial_statements_dataGridView.TabIndex = 0;
            // 
            // financial_statements_button
            // 
            this.financial_statements_button.Location = new System.Drawing.Point(388, 299);
            this.financial_statements_button.Name = "financial_statements_button";
            this.financial_statements_button.Size = new System.Drawing.Size(75, 23);
            this.financial_statements_button.TabIndex = 1;
            this.financial_statements_button.Text = "Back";
            this.financial_statements_button.UseVisualStyleBackColor = true;
            this.financial_statements_button.Click += new System.EventHandler(this.financial_statements_button_Click);
            // 
            // financial_statements_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.financial_statements_button);
            this.Controls.Add(this.financial_statements_dataGridView);
            this.Name = "financial_statements_Form";
            this.Text = "financial_statements_Form";
            this.Load += new System.EventHandler(this.financial_statements_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financial_statements_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView financial_statements_dataGridView;
        private System.Windows.Forms.Button financial_statements_button;
    }
}