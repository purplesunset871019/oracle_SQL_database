using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Medical_information
{
    public partial class main_page_Form : Form
    {
        public main_page_Form()
        {
            InitializeComponent();
            main_page_lable.Text = "商店管理系統";
            trading_record_main_page_lable.Text = "進出貨紀錄";
            employees_main_page_lable.Text = "員工紀錄";
            product_information_main_page_lable.Text = "商品資訊";
            employee_salary_main_page_lable.Text = "員工薪資";
            jobs_main_page_lable.Text = "職位資訊";
            employee_history_main_page_lable.Text = "員工歷史";
            financial_statements_main_page_lable.Text = "每日結餘";
        }

        //當按鈕被按下時
        private void trading_record_read_button_Click(object sender, System.EventArgs e)
        {
            trading_record_Form tf = new trading_record_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            tf.Visible = true;//顯示第二個視窗
        }


        //當按鈕被按下時
        private void employees_read_button_Click (object sender, System.EventArgs e)
        {
            employees_Form erf = new employees_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            erf.Visible = true;//顯示第二個視窗
        }

        //當按鈕被按下時
        private void product_information_read_button_Click(object sender, System.EventArgs e)
        {
            product_information_Form pf = new product_information_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            pf.Visible = true;//顯示第二個視窗
        }

        //當按鈕被按下時
        private void employee_salary_read_button_Click(object sender, System.EventArgs e)
        {
            employee_salary_Form esf = new employee_salary_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            esf.Visible = true;//顯示第二個視窗
        }

        //當按鈕被按下時
        private void jobs_read_button_Click(object sender, System.EventArgs e)
        {
            jobs_Form jf = new jobs_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            jf.Visible = true;//顯示第二個視窗
        }

        //當按鈕被按下時
        private void employee_history_read_button_Click(object sender, System.EventArgs e)
        {
            employee_history_Form ehf = new employee_history_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            ehf.Visible = true;//顯示第二個視窗
        }

        //當按鈕被按下時
        private void financial_statements_read_button_Click(object sender, System.EventArgs e)
        {
            financial_statements_Form ff = new financial_statements_Form();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            ff.Visible = true;//顯示第二個視窗
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Main_page_lable_Click(object sender, EventArgs e)
        {

        }
    }
}
