using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Entidades.capas.Data
{
    public class ConexionDB
    {
        public static string stringconnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }
}