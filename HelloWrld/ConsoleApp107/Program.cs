using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp107
{
    class CommandExam
    {
        static void Main(string[] args)
        {
            string str = @"Data Source=(DESCRIPTION =
             (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
             (CONNECT_DATA =
             (SERVER = DEDICATED)
             (SERVICE_NAME = topcredu)
             )
             ) ;User Id=scott;Password=tiger;";
            //string str = "data source=topcredu;UserID = scott; Password = tiger";
            OracleConnection Conn = new OracleConnection(str);
            Conn.Open();

            OracleDataAdapter adapter = new OracleDataAdapter("select * from emp", Conn);
            DataSet ds = new DataSet("myemp");
            adapter.Fill(ds, "사원");

            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"], r["sal"]);
            }

            ds.Tables["사원"].Rows[0]["ename"] = "홍길동";

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(adapter);

            adapter.Update(ds, "사원");

            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows) 
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"], r["sal"]);
            }

            DataRow row = ds.Tables["사원"].NewRow();
            row["empno"] = 9766; row["ename"] = "89길동";row["sal"] = 1717;
            ds.Tables["사원"].Rows.Add(row);

            adapter.Update(ds, "사원");
            adapter = new OracleDataAdapter("select * from emp", Conn);
            adapter.Fill(ds, "사원");

            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"], r["sal"]);
            }
            Console.WriteLine("총 {0}건입니다. ", ds.Tables["사원"].Rows.Count);
        }
    }
}
