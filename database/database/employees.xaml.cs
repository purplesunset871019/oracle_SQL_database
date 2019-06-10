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
using System.Windows.Shapes;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace database
{
    /// <summary>
    /// employees.xaml 的互動邏輯
    /// </summary>
    public partial class employees : Window
    {
        OracleConnection con = null;
        public employees()
        {
            this.setConnection();
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM employees";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            employees_DataGrid.ItemsSource = dt.DefaultView;
            dr.Close();
        }

        private void setConnection()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myconnectionString"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp) { }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.updateDataGrid();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            con.Close();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "insert into employees(employee_id, employee_name, working_hour, email, phone_number, hire_date, job_id, manager_id) values (:employee_id, :employee_name, :working_hour, :email, :phone_number, :hire_date, :job_id, :manager_id)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "update employees set employee_name = :employee_name, working_hour = :working_hour, email = :email, phone_number = :phone_number, hire_date = :hire_date, job_id = :job_id, manager_id = :manager_id where employee_id = :employee_id";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "delete from  employees WHERE employee_id = :employee_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }
                     
        private void resetAll()
        {
            employee_id_txtbx.Text = "";
            employee_name_txtbx.Text = "";
            working_hour_txtbx.Text = "";
            email_txtbx.Text = "";
            phone_number_txtbx.Text = "";
            hire_date_picker.SelectedDate = null;
            job_id_txtbx.Text = "";
            manager_id_txtbx.Text = "";

        }
        private void Reset_btn_Click(object sender, RoutedEventArgs e)
        {
            this.resetAll();
        }

        private void AUD(String sql_stmt, int state)
        {
            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Row Inserted Successfully";

                    cmd.Parameters.Add("employee_id", OracleDbType.Varchar2, 3).Value = employee_id_txtbx.Text;
                    cmd.Parameters.Add("employee_name", OracleDbType.Varchar2, 20).Value = employee_name_txtbx.Text;
                    cmd.Parameters.Add("working_hour", OracleDbType.NVarchar2, 11).Value = working_hour_txtbx.Text;
                    cmd.Parameters.Add("email", OracleDbType.NVarchar2, 20).Value = email_txtbx.Text;
                    cmd.Parameters.Add("phone_number", OracleDbType.Varchar2, 15).Value = phone_number_txtbx.Text;
                    cmd.Parameters.Add("hire_date", OracleDbType.Date).Value = hire_date_picker.SelectedDate;
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
                    cmd.Parameters.Add("manager_id", OracleDbType.Varchar2, 3).Value = manager_id_txtbx.Text;
                    
                    break;

                case 1:
                    msg = "Row Update Successfully";
                    cmd.Parameters.Add("employee_name", OracleDbType.Varchar2, 20).Value = employee_name_txtbx.Text;
                    cmd.Parameters.Add("working_hour", OracleDbType.NVarchar2, 11).Value = working_hour_txtbx.Text;
                    cmd.Parameters.Add("email", OracleDbType.NVarchar2, 20).Value = email_txtbx.Text;
                    cmd.Parameters.Add("phone_number", OracleDbType.Varchar2, 15).Value = phone_number_txtbx.Text;
                    cmd.Parameters.Add("hire_date", OracleDbType.Date).Value = hire_date_picker.SelectedDate;
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
                    cmd.Parameters.Add("manager_id", OracleDbType.Varchar2, 3).Value = manager_id_txtbx.Text;

                    cmd.Parameters.Add("employee_id", OracleDbType.Varchar2, 3).Value = employee_id_txtbx.Text;
                    break;

                case 2:
                    msg = "Row Delete Successfully";
                    cmd.Parameters.Add("employee_id", OracleDbType.Varchar2, 3).Value = employee_id_txtbx.Text;
                    break;
            }
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    this.updateDataGrid();
                }
            }
            catch (Exception expe) { }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w12 = new MainWindow();
            this.Close();
            w12.Show();
        }

        private void Employees_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                employee_id_txtbx.Text = dr["employee_id"].ToString();
                employee_name_txtbx.Text = dr["employee_name"].ToString();
                working_hour_txtbx.Text = dr["working_hour"].ToString();
                email_txtbx.Text = dr["email"].ToString();
                phone_number_txtbx.Text = dr["phone_number"].ToString();
                hire_date_picker.SelectedDate = DateTime.Parse(dr["hire_date"].ToString());
                job_id_txtbx.Text = dr["job_id"].ToString();
                manager_id_txtbx.Text = dr["manager_id"].ToString();

                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;
            }
        }
    }
}
