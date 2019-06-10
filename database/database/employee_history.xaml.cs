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
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class employee_history : Window
    {
        OracleConnection con = null;
        public employee_history()
        {
            this.setConnection();
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM employee_history";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            employee_history_DataGrid.ItemsSource = dt.DefaultView;
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

        private void Window_Closed(object sender, EventArgs e)
        {
            con.Close();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "insert into employee_history(employee_id, start_date, end_date, job_id) values (:employee_id, :start_date, :end_date, :job_id)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "update employee_history set start_date=:start_date, end_date=:end_date, job_id=:job_id where employee_id=:employee_id";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "delete from employee_history WHERE employee_id=:employee_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }




        private void resetAll()
        {
            employee_id_txtbx.Text = "";
            start_date_picker.SelectedDate = null;
            end_date_picker.SelectedDate = null;
            job_id_txtbx.Text = "";

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
                    cmd.Parameters.Add("start_date", OracleDbType.Date).Value = start_date_picker.SelectedDate;
                    cmd.Parameters.Add("end_date", OracleDbType.Date).Value = end_date_picker.SelectedDate;
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
                    
                    break;

                case 1:
                    msg = "Row Update Successfully";
                    cmd.Parameters.Add("start_date", OracleDbType.Date).Value = start_date_picker.SelectedDate;
                    cmd.Parameters.Add("end_date", OracleDbType.Date).Value = end_date_picker.SelectedDate;
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;

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
            MainWindow w14 = new MainWindow();
            this.Close();
            w14.Show();
        }

        private void Employee_history_txtbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                employee_id_txtbx.Text = dr["commodity_id"].ToString();
                start_date_picker.SelectedDate = DateTime.Parse(dr["purchase_date"].ToString());
                end_date_picker.SelectedDate = DateTime.Parse(dr["commodity_exp"].ToString());
                job_id_txtbx.Text = dr["manager_id"].ToString();

                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;

            }
        }
    }
}
