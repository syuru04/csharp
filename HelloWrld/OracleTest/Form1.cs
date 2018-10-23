using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                ds = new DataSet("emp");

                string conStr = @"Data Source=(DESCRIPTION =
             (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
             (CONNECT_DATA =
             (SERVER = DEDICATED)
             (SERVICE_NAME = topcredu)
             )
             ) ;User Id=scott;Password=tiger;Provider=OraOleDB.Oracle";
                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename) values(8989, 'OJC')", conn);
                 command.ExecuteNonQuery();
                adapter = new OleDbDataAdapter("select * from emp", conn);
                adapter.Fill(ds,"EMP");
                dataGridView1.DataSource = ds.Tables["EMP"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
