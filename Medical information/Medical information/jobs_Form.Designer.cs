namespace Medical_information
{
    partial class jobs_Form
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
            this.jobs_dataGridView = new System.Windows.Forms.DataGridView();
            this.jobs_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobs_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobs_dataGridView
            // 
            this.jobs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobs_dataGridView.Location = new System.Drawing.Point(297, 122);
            this.jobs_dataGridView.Name = "jobs_dataGridView";
            this.jobs_dataGridView.RowTemplate.Height = 24;
            this.jobs_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.jobs_dataGridView.TabIndex = 0;
            // 
            // jobs_button
            // 
            this.jobs_button.Location = new System.Drawing.Point(384, 297);
            this.jobs_button.Name = "jobs_button";
            this.jobs_button.Size = new System.Drawing.Size(75, 23);
            this.jobs_button.TabIndex = 1;
            this.jobs_button.Text = "Back";
            this.jobs_button.UseVisualStyleBackColor = true;
            this.jobs_button.Click += new System.EventHandler(this.jobs_button_Click);
            // 
            // jobs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobs_button);
            this.Controls.Add(this.jobs_dataGridView);
            this.Name = "jobs_Form";
            this.Text = "jobs_Form";
            this.Load += new System.EventHandler(this.jobs_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobs_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView jobs_dataGridView;
        private System.Windows.Forms.Button jobs_button;
    }
}