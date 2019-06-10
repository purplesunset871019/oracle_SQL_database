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
    /// financial_statements.xaml 的互動邏輯
    /// </summary>
    public partial class financial_statements : Window
    {
        OracleConnection con = null;
        public financial_statements()
        {
            this.setConnection();
            InitializeComponent();
        }
        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM financial_statements";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            financial_statements_DataGrid.ItemsSource = dt.DefaultView;
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


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.updateDataGrid();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            con.Close();
        }

        private void Add_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "insert into financial_statements(manager_id, total_salary, utiltties_cost, commodity_cost, commodity_income, miscellaneous_cost) values (:manager_id, :total_salary, :utiltties_cost, :commodity_cost, :commodity_income, :miscellaneous_cost)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "update financial_statements set  total_salary = :total_salary, utiltties_cost = :utiltties_cost, commodity_cost = :commodity_cost commodity_income = :commodity_income, miscellaneous_cost = :miscellaneous_cost where manager_id = :manager_id";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "delete from  financial_statements WHERE manager_id = :manager_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }




        private void resetAll()
        {
             

            manager_id_txtbx.Text = "";
            total_salary_txtbx.Text = "";
            utiltties_cost_txtbx.Text = "";
            commodity_cost_txtbx.Text = "";
            commodity_income_txtbx.Text = "";
            miscellaneous_cost_txtbx.Text = "";

        }
        private void Reset_btn_Click_1(object sender, RoutedEventArgs e)
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
                    
                    cmd.Parameters.Add("manager_id", OracleDbType.Int32, 3).Value = Int32.Parse(manager_id_txtbx.Text);
                    cmd.Parameters.Add("total_salary", OracleDbType.Int32, 7).Value = Int32.Parse(total_salary_txtbx.Text);
                    cmd.Parameters.Add("utiltties_cost", OracleDbType.Int32, 5).Value = Int32.Parse(utiltties_cost_txtbx.Text);
                    cmd.Parameters.Add("commodity_cost", OracleDbType.Int32, 7).Value = Int32.Parse(commodity_cost_txtbx.Text);
                    cmd.Parameters.Add("commodity_income", OracleDbType.Int32, 7).Value = Int32.Parse(commodity_income_txtbx.Text);
                    cmd.Parameters.Add("miscellaneous_cost", OracleDbType.Int32, 5).Value = Int32.Parse(miscellaneous_cost_txtbx.Text);



                    break;

                case 1:
                    msg = "Row Update Successfully";

                    cmd.Parameters.Add("total_salary", OracleDbType.Int32, 7).Value = Int32.Parse(total_salary_txtbx.Text);
                    cmd.Parameters.Add("utiltties_cost", OracleDbType.Int32, 5).Value = Int32.Parse(utiltties_cost_txtbx.Text);
                    cmd.Parameters.Add("commodity_cost", OracleDbType.Int32, 7).Value = Int32.Parse(commodity_cost_txtbx.Text);
                    cmd.Parameters.Add("commodity_income", OracleDbType.Int32, 7).Value = Int32.Parse(commodity_income_txtbx.Text);
                    cmd.Parameters.Add("miscellaneous_cost", OracleDbType.Int32, 5).Value = Int32.Parse(miscellaneous_cost_txtbx.Text);

                    cmd.Parameters.Add("manager_id", OracleDbType.Int32, 3).Value = Int32.Parse(manager_id_txtbx.Text);
                    break;

                case 2:
                    msg = "Row Delete Successfully";
                    cmd.Parameters.Add("manager_id", OracleDbType.Int32, 3).Value = Int32.Parse(manager_id_txtbx.Text);
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
            MainWindow w11 = new MainWindow();
            this.Close();
            w11.Show();
        }






      

        private void Financial_statements_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                manager_id_txtbx.Text = dr["manager_id"].ToString();
                total_salary_txtbx.Text = dr["total_salary"].ToString();
                utiltties_cost_txtbx.Text = dr["utiltties_cost"].ToString();
                commodity_cost_txtbx.Text = dr["commodity_cost"].ToString();
                commodity_income_txtbx.Text = dr["commodity_income"].ToString();
                miscellaneous_cost_txtbx.Text = dr["miscellaneous_cost"].ToString();

                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;

            }
        }

       
    }
}
