using SqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString="";
            connectionString = 
                "SERVER=" + "localhost" + ";"
                +"PORT=" +"3309"+";"
                + "DATABASE=" +"test" + ";"
                + "UID=" + "root" + ";"
                + "PASSWORD=" + "19047321k" + ";" +
                "SslMode=none;";





            MySqlConnector m = new MySqlConnector();
            m.ConnectionString = connectionString;
            m.AddProcedure("new_procedure");
              m.
                  AddParameter("", "").
                  AddParameter("", "").
                  AddParameter("", "").
                  AddParameter("", "");
            DataTable dt = new DataTable();
            /*resultado a datatable*/
            dt = m.ExecQuery().toDataTable();
            /*XDocument xdoc = new XDocument();
            xdoc = m.ExecQuery().toXml();*/


            Console.ReadKey();
        }
    }
}
