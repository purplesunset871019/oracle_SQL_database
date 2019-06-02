namespace Medical_information
{
    partial class product_information_Form
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
            this.product_information_dataGridView = new System.Windows.Forms.DataGridView();
            this.product_information_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_information_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_information_dataGridView
            // 
            this.product_information_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_information_dataGridView.Location = new System.Drawing.Point(288, 73);
            this.product_information_dataGridView.Name = "product_information_dataGridView";
            this.product_information_dataGridView.RowTemplate.Height = 24;
            this.product_information_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.product_information_dataGridView.TabIndex = 0;
            // 
            // product_information_button
            // 
            this.product_information_button.Location = new System.Drawing.Point(373, 277);
            this.product_information_button.Name = "product_information_button";
            this.product_information_button.Size = new System.Drawing.Size(75, 23);
            this.product_information_button.TabIndex = 1;
            this.product_information_button.Text = "Back";
            this.product_information_button.UseVisualStyleBackColor = true;
            this.product_information_button.Click += new System.EventHandler(this.product_information_button_Click);
            // 
            // product_information_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.product_information_button);
            this.Controls.Add(this.product_information_dataGridView);
            this.Name = "product_information_Form";
            this.Text = "product_information_form";
            this.Load += new System.EventHandler(this.product_information_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_information_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_information_dataGridView;
        private System.Windows.Forms.Button product_information_button;
    }
}