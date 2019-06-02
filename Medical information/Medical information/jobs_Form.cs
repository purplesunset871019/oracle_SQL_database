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
    public partial class jobs_Form : Form
    {
        public jobs_Form()
        {
            InitializeComponent();
        }

        private void jobs_form_Load(object sender, EventArgs e)
        {
            try
            {
                // Please replace the connection string attribute settings
                string constr = "user id=store;password=store;data source=orcl";

                OracleConnection con = new OracleConnection(constr);
                con.Open();

                // SQL Statement
                string sql = "select * from jobs ";

                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(ds);
                jobs_dataGridView.DataSource = ds.Tables[0];
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
            }
        }

        private void jobs_button_Click(object sender, System.EventArgs e)
        {
            main_page_Form mf = new main_page_Form();
            this.Close();
            mf.Visible = true;
        }
    }
}
