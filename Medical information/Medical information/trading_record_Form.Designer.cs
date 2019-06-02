namespace Medical_information
{
    partial class trading_record_Form
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
            this.trading_record_dataGridView = new System.Windows.Forms.DataGridView();
            this.trading_record_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trading_record_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trading_record_dataGridView
            // 
            this.trading_record_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trading_record_dataGridView.Location = new System.Drawing.Point(270, 92);
            this.trading_record_dataGridView.Name = "trading_record_dataGridView";
            this.trading_record_dataGridView.RowTemplate.Height = 24;
            this.trading_record_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.trading_record_dataGridView.TabIndex = 0;
            // 
            // trading_record_button
            // 
            this.trading_record_button.Location = new System.Drawing.Point(372, 274);
            this.trading_record_button.Name = "trading_record_button";
            this.trading_record_button.Size = new System.Drawing.Size(75, 23);
            this.trading_record_button.TabIndex = 1;
            this.trading_record_button.Text = "Back";
            this.trading_record_button.UseVisualStyleBackColor = true;
            this.trading_record_button.Click += new System.EventHandler(this.trading_record_button_Click);
            // 
            // trading_record_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trading_record_button);
            this.Controls.Add(this.trading_record_dataGridView);
            this.Name = "trading_record_Form";
            this.Text = "trading_record_Form";
            this.Load += new System.EventHandler(this.trading_record_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trading_record_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trading_record_dataGridView;
        private System.Windows.Forms.Button trading_record_button;
    }
}