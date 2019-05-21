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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Please replace the connection string attribute settings
                string constr = "user id=store;password=store;data source=shop";

                OracleConnection con = new OracleConnection(constr);
                con.Open();

                // SQL Statement
                string sql = "select * from employees ";

                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
            }
        }
    }
}
