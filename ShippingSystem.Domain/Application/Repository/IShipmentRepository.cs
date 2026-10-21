using Shipping.Domain.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Domain.Application.Repository
{
    public interface IShipmentRepository
    {

        Task<IEnumerable<ShipmentModel>> GetAllAsync();

    }
}
