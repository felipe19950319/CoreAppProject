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

            /************************************my sql*******************************************/
            MySqlConnector mySql = new MySqlConnector();
            mySql.ConnectionString = mySql.getCnString();
 
            mySql.AddProcedure("new_procedure");

            mySql.
                 AddParameter("CON", "0").
                 AddParameter("CON1", "1");
  
             DataTable dt = new DataTable();      
             dt = mySql.ExecQuery().ToDataTable();

             XDocument x = new XDocument();
             x = mySql.ExecQuery().ToXml();

             string s = string.Empty;
             s= mySql.ExecQuery().ToJson();
            /************************************my sql*******************************************/
            /************************************sql server*******************************************/

            SqlServerConnector sqlServer = new SqlServerConnector();
            sqlServer.ConnectionString = "Data Source=192.168.16.41;Integrated Security=False;Initial Catalog=Biz_Credit;User ID=usr_consulta;Password=usr_consulta";

            sqlServer.AddProcedure("GetDataEjemplo");
            sqlServer.
                AddParameter("ParametroA", "1")
               .AddParameter("ParametroB", "2").AddParameter("","").AddParameter("","");

            DataTable dt_ = new DataTable();
            dt_= sqlServer.ExecQuery().ToDataTable();

            XDocument x_ = new XDocument();
            x_ = sqlServer.ExecQuery().ToXml();

            string s_ = string.Empty;
            s_ = sqlServer.ExecQuery().ToJson();
            /************************************sql server*******************************************/


            Console.ReadKey();
        }

    }
}
