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
    /// trading_record.xaml 的互動邏輯
    /// </summary>
    public partial class trading_record : Window
    {
        OracleConnection con = null;
        public trading_record()
        {
            this.setConnection();
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TRADING_RECORD";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            trading_record_DataGrid.ItemsSource = dt.DefaultView;
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
            string sql = "insert into TRADING_RECORD(commodity_id, purchase_date, manager_id, compodity_purchases, commodity_sales, commodity_inventory, commodity_exp) values (:commodity_id, :purchase_date, :manager_id, :compodity_purchases, :commodity_sales, :commodity_inventory, :commodity_exp)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "update TRADING_RECORD set  purchase_date=:purchase_date, manager_id=:manager_id, compodity_purchases=:compodity_purchases, commodity_sales=:commodity_sales,commodity_inventory=:commodity_inventory, commodity_exp=:commodity_exp)";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "delete from TRADING_RECORD WHERE commodity_id = :commodity_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }




        private void resetAll()
        {
            commodity_id_txtbx.Text = "";
            purchase_date_picker.SelectedDate = null;
            manager_id_txtbx.Text = "";
            compodity_purchases_txtbx.Text = "";
            commodity_sales_txtbx.Text = "";
            commodity_inventory_txtbx.Text = "";
            commodity_exp_picker.SelectedDate = null;
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
                    cmd.Parameters.Add("commodity_id", OracleDbType.Varchar2, 3).Value = commodity_id_txtbx.Text;
                    cmd.Parameters.Add("purchase_date", OracleDbType.Date).Value = purchase_date_picker.SelectedDate;
                    cmd.Parameters.Add("manager_id", OracleDbType.Int32, 3).Value = Int32.Parse(manager_id_txtbx.Text);
                    cmd.Parameters.Add("compodity_purchases", OracleDbType.Int32, 3).Value = Int32.Parse(compodity_purchases_txtbx.Text);
                    cmd.Parameters.Add("commodity_sales", OracleDbType.Int32, 3).Value = Int32.Parse(compodity_purchases_txtbx.Text);
                    cmd.Parameters.Add("commodity_inventory", OracleDbType.Varchar2, 3).Value = commodity_inventory_txtbx.Text;
                    cmd.Parameters.Add("commodity_exp", OracleDbType.Date).Value = commodity_exp_picker.SelectedDate;

                    break;

                case 1:
                    msg = "Row Update Successfully";

                    cmd.Parameters.Add("purchase_date", OracleDbType.Date).Value = purchase_date_picker.SelectedDate;
                    cmd.Parameters.Add("manager_id", OracleDbType.Int32, 3).Value = Int32.Parse(manager_id_txtbx.Text);
                    cmd.Parameters.Add("compodity_purchases", OracleDbType.Int32, 3).Value = Int32.Parse(compodity_purchases_txtbx.Text);
                    cmd.Parameters.Add("commodity_sales", OracleDbType.Int32, 3).Value = Int32.Parse(compodity_purchases_txtbx.Text);
                    cmd.Parameters.Add("commodity_inventory", OracleDbType.Varchar2, 3).Value = commodity_inventory_txtbx.Text;
                    cmd.Parameters.Add("commodity_exp", OracleDbType.Date).Value = commodity_exp_picker.SelectedDate;

                   // cmd.Parameters.Add("commodity_id", OracleDbType.Varchar2, 3).Value = commodity_id_txtbx.Text;
                    break;

                case 2:
                    msg = "Row Delete Successfully";
                    cmd.Parameters.Add("commodity_id", OracleDbType.Varchar2, 3).Value = commodity_id_txtbx.Text;
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

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                commodity_id_txtbx.Text = dr["commodity_id"].ToString();
                purchase_date_picker.SelectedDate = DateTime.Parse(dr["purchase_date"].ToString());
                manager_id_txtbx.Text = dr["manager_id"].ToString();
                compodity_purchases_txtbx.Text = dr["compodity_purchases"].ToString();
                commodity_sales_txtbx.Text = dr["commodity_sales"].ToString();
                commodity_inventory_txtbx.Text = dr["commodity_inventory"].ToString();
                commodity_exp_picker.SelectedDate = DateTime.Parse(dr["commodity_exp"].ToString());

                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;

            }
        }



        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
