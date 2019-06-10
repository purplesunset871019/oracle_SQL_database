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
    /// product_information.xaml 的互動邏輯
    /// </summary>
    public partial class product_information : Window
    {
        OracleConnection con = null;
        public product_information()
        {
            this.setConnection();
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM product_information";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            product_information_DataGrid.ItemsSource = dt.DefaultView;
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

        private void Window_Closed_1(object sender, EventArgs e)
        {
            con.Close();
        }

        private void Add_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "insert into product_information(commodity_name, commodity_id, commodity_price, commodity_position) values (:commodity_name, :commodity_id, :commodity_price, :commodity_position)";
            this.AUD(sql, 0);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "update product_information set commodity_name = :commodity_name, commodity_price = :commodity_price, commodity_position = :commodity_position where commodity_id = :commodity_id";
            this.AUD(sql, 1);
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }

        private void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            string sql = "delete from product_information WHERE commodity_id = :commodity_id";
            this.AUD(sql, 2);
            this.resetAll();
            Update_btn.IsEnabled = true;
            Delete_btn.IsEnabled = true;
        }




        private void resetAll()
        {
            
      
            commodity_name_txtbx.Text = "";
            commodity_id_txtbx.Text = "";
            commodity_price_txtbx.Text = "";
            commodity_position_txtbx.Text = "";

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
                    cmd.Parameters.Add("commodity_name", OracleDbType.NVarchar2, 10).Value = commodity_name_txtbx.Text;
                    cmd.Parameters.Add("commodity_id", OracleDbType.Varchar2, 3).Value = commodity_id_txtbx.Text;
                    cmd.Parameters.Add("commodity_price", OracleDbType.Int32, 6).Value = Int32.Parse(commodity_price_txtbx.Text);
                    cmd.Parameters.Add("commodity_position", OracleDbType.NVarchar2, 10).Value = commodity_position_txtbx.Text;

                    

                    break;

                case 1:
                    msg = "Row Update Successfully";

                    cmd.Parameters.Add("commodity_name", OracleDbType.NVarchar2, 10).Value = commodity_name_txtbx.Text;
                    cmd.Parameters.Add("commodity_price", OracleDbType.Int32, 6).Value = Int32.Parse(commodity_price_txtbx.Text);
                    cmd.Parameters.Add("commodity_position", OracleDbType.NVarchar2, 10).Value = commodity_position_txtbx.Text;

                    cmd.Parameters.Add("commodity_id", OracleDbType.Varchar2, 3).Value = commodity_id_txtbx.Text;
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




        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w9 = new MainWindow();
            this.Close();
            w9.Show();
        }

        

        


        private void Product_information_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                commodity_name_txtbx.Text = dr["commodity_name"].ToString();
                commodity_id_txtbx.Text = dr["commodity_id"].ToString();
                commodity_price_txtbx.Text = dr["commodity_price"].ToString();
                commodity_position_txtbx.Text = dr["commodity_position"].ToString();
               
                Update_btn.IsEnabled = true;
                Delete_btn.IsEnabled = true;

            }
        }
    }
}

