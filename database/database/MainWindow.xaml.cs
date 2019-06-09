using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace database
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Employee_history_btn_Click(object sender, RoutedEventArgs e)
        {
            employee_history w1 = new employee_history();
            this.Close();
            w1.Show();
        }

        private void Employee_salary_btn_Click(object sender, RoutedEventArgs e)
        {
            employee_salary w2 = new employee_salary();
            this.Close();
            w2.Show();
        }

        private void Employees_btn_Click(object sender, RoutedEventArgs e)
        {
            employees w3 = new employees();
            this.Close();
            w3.Show();
        }

        private void Financial_statements_btn_Click(object sender, RoutedEventArgs e)
        {
            financial_statements w4 = new financial_statements();
            this.Close();
            w4.Show();
        }

        private void Jobs_btn_Click(object sender, RoutedEventArgs e)
        {
            jobs w5 = new jobs();
            this.Close();
            w5.Show();
        }

        private void Product_information_btn_Click(object sender, RoutedEventArgs e)
        {
            product_information w6 = new product_information();
            this.Close();
            w6.Show();
        }

        private void Trading_record_btn_Click(object sender, RoutedEventArgs e)
        {
            trading_record w7 = new trading_record();
            this.Close();
            w7.Show();
        }
    }
}