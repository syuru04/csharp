using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace ConsoleApp106
{
    class CommandExam
    {
        static OleDbConnection cn;
        public static void Main()
        {
            OleCn(); Openning();

            Console.WriteLine("The Oraginal Tabel");
            Output();

            Console.WriteLine("Added table"); Adding(); Output();
            Console.WriteLine("Modifed table"); Modifying(); Output();
            Console.WriteLine("Deleted table"); Deleting(); Output();

            Closing();
               
        }

        public static void OleCn()
        {
            string str = @"Data Source=(DESCRIPTION =
             (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
             (CONNECT_DATA =
             (SERVER = DEDICATED)
             (SERVICE_NAME = topcredu)
             )
             ) ;User Id=scott;Password=tiger;   Provider=OraOleDB.Oracle";
            cn = new OleDbConnection(str);
        }
        public static void Openning() { cn.Open(); }
        public static void Output()
        {
            string sql = "SELECT empno id , ename name FROM emp";
            OleDbCommand cmd; OleDbDataReader dr;
            cmd = new OleDbCommand(sql,cn);
            dr = cmd.ExecuteReader();

            Console.WriteLine("\n");
            while (dr.Read())
            {
                Console.WriteLine("{0,-10}\t{1,-10}", dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }
            Console.WriteLine("\n");
            dr.Close();
        }
        public static void Adding()
        {
            try
            {
                string sqladd = "INSERT INTO emp (empno,ename) VALUES (1717,'OJC')";
                OleDbCommand cmdAdd = new OleDbCommand(sqladd, cn);

                int rowsadded = cmdAdd.ExecuteNonQuery();
                Console.WriteLine("Number of rows added: " + rowsadded);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());               
            }
        
        }
        public static void Modifying()
        {
            try
            {
                string sqlmodify = "UPDATE emp SET ename = '오닷넷' WHERE empno = 1717";
                OleDbCommand cmdupdate = new OleDbCommand(sqlmodify, cn);
                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine("Number of rows modified: " + rows);

            }catch( Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public static void Deleting()
        {
            try
            {
                string sqldelete = "DELETE FROM emp WHERE empno = 1717";
                OleDbCommand cmddelete = new OleDbCommand(sqldelete, cn);
                int rows = cmddelete.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + rows);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Closing() { cn.Close(); }
    }
}
