using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Utils
{
    class Conexao
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["Farmacia.Properties.Settings.farmaciaConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}