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

namespace TransactionExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter = null;
        DataSet ds = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");

            string str = @"Data Source=(DESCRIPTION =
             (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
             (CONNECT_DATA =
             (SERVER = DEDICATED)
             (SERVICE_NAME = topcredu)
             )
             ) ;User Id=scott;Password=tiger;   Provider=OraOleDB.Oracle";

            using (OleDbConnection connection = new OleDbConnection(str))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;


                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = tr;

                    command.CommandText = "insert into emp(empno,ename)" + " values (3456,'3000길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");

                    command.CommandText = "insert into emp(empno,ename)" + " values (7890,'3000길동')";
                    i = command.ExecuteNonQuery();

                    tr.Commit();

                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];

                    adapter.Fill(ds, "EMP");                    
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
