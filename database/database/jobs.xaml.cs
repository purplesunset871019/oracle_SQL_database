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
    /// jobs.xaml 的互動邏輯
    /// </summary>
    public partial class jobs : Window
    {
        OracleConnection con = null;
        public jobs()
        {
            this.setConnection();
            InitializeComponent();
        }
        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM jobs";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            jobs_DataGrid.ItemsSource = dt.DefaultView;
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
            string sql = "insert into jobs(job_id, job_title, min_salary, max_salary) values (:job_id, :job_title, :min_salary, :max_salary)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "update jobs set  job_title = :job_title, min_salary = :min_salary, max_salary = :max_salary where job_id = :job_id";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "delete from jobs WHERE job_id = :job_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }




        private void resetAll()
        {


            job_id_txtbx.Text = "";
            job_title_txtbx.Text = "";
            min_salary_txtbx.Text = "";
            max_salary_txtbx.Text = "";

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
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
                    cmd.Parameters.Add("jon_name", OracleDbType.Varchar2, 10).Value = job_title_txtbx.Text;
                    cmd.Parameters.Add("min_salary", OracleDbType.Int32, 6).Value = Int32.Parse(min_salary_txtbx.Text);
                    cmd.Parameters.Add("max_salary", OracleDbType.Int32, 6).Value = Int32.Parse(max_salary_txtbx.Text);



                    break;

                case 1:
                    msg = "Row Update Successfully";

                    cmd.Parameters.Add("jon_name", OracleDbType.Varchar2, 10).Value = job_title_txtbx.Text;
                    cmd.Parameters.Add("min_salary", OracleDbType.Int32, 6).Value = Int32.Parse(min_salary_txtbx.Text);
                    cmd.Parameters.Add("max_salary", OracleDbType.Int32, 6).Value = Int32.Parse(max_salary_txtbx.Text);

                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
                    break;

                case 2:
                    msg = "Row Delete Successfully";
                    cmd.Parameters.Add("job_id", OracleDbType.Varchar2, 3).Value = job_id_txtbx.Text;
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
            MainWindow w10 = new MainWindow();
            this.Close();
            w10.Show();
        }






        private void Jobs_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                job_id_txtbx.Text = dr["job_id"].ToString();
                job_title_txtbx.Text = dr["job_title"].ToString();
                min_salary_txtbx.Text = dr["min_salary"].ToString();
                max_salary_txtbx.Text = dr["max_salary"].ToString();

                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;

            }
        }
    }
}
