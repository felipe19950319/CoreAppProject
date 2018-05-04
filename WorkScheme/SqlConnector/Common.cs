using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnector
{
    public class Common
    {
        public Dictionary<string, string> Parameters = new Dictionary<string, string>();
        public string Procedure = string.Empty;

        public void AddProcedure(string Procedure)
        {
            this.Procedure = Procedure;
        }

        public Common AddParameter(string Parameter,string Value)
        {
            Parameters.Add(Parameter, Value);
            return this;
        }
    }


}
