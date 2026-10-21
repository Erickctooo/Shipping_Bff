using Dapper;
using Shipping.Domain.Application.Model;
using Shipping.Domain.Application.Repository;
using Shipping.Infrastructure.Application.Querys;
using Shipping.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Infrastructure.Application.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {


        private readonly ISqlConnectionFactory _connectionFactory;

        public ShipmentRepository(ISqlConnectionFactory connectionFactory) 
        { 
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<ShipmentModel>> GetAllAsync()
        {

            using var connection = 
                _connectionFactory.CreateConnection();

            string sql = ShipmentQuery.QueryGetAll;
                     
            IEnumerable<ShipmentModel> shipments = 
                await connection.QueryAsync<ShipmentModel>(sql);

            return shipments;

        }


    }
}
