using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Infrastructure.DataBase
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ShippingDb")
                ?? throw new InvalidOperationException(
                    "No se encontro la cadena de conexion ShippingDb.");
        }

        public IDbConnection CreateConnection() {
            
            return new SqlConnection(_connectionString);
        
        }


    }
}
