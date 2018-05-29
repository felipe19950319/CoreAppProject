using System.Collections.Generic;
using System.Data;

namespace SqlConnector
{
    public class Common
    {
        public Dictionary<string, string> Parameters = new Dictionary<string, string>();
        public string Procedure = string.Empty;
        public string ConnectionString = string.Empty;
        public DataSet ds = new DataSet();

        public void AddProcedure(string Procedure)
        {
            this.Procedure = Procedure;
        }

        public Common AddParameter(string Parameter,string Value)
        {
            Parameters.Add(Parameter, Value);
            return this;
        }

        public string getCnString()
        {
            return
           "SERVER=" + "localhost" + ";"
           + "PORT=" + "3309" + ";"
           + "DATABASE=" + "test" + ";"
           + "UID=" + "root" + ";"
           + "PASSWORD=" + "19047321k" + ";" +
           "SslMode=none;";
        }
    }




}
