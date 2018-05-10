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

            MySqlConnector m = new MySqlConnector();
            m.ConnectionString =m.getCnString();
            //llamada al procedimiento 
            m.AddProcedure("new_procedure");
            //asignaion de los parametros del procedimiento 
            m.
                AddParameter("CON", "0").
                AddParameter("CON1", "1");

            //resultado....
            //datatable 
            DataTable dt = new DataTable();      
            dt = m.ExecQuery().ToDataTable();
            // o xml 
            XDocument x = new XDocument();
            x = m.ExecQuery().ToXml();
            // o json 
            string s = string.Empty;
            s= m.ExecQuery().ToJson();
            Console.ReadKey();
        }

    }
}
