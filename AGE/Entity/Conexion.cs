using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGE.Entity
{
    internal class Conexion
    {
        public string ConnectionString = ConfigurationManager.AppSettings["Cns"];
    }
}
