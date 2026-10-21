using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Infrastructure.Application.Querys
{
    public static class ShipmentQuery
    {
        internal static string QueryGetAll = @"

            SELECT
                Id,
                SenderName,
                RecipientName,
                Origin,
                Destination,
                Weight,
                Status
             FROM dbo.Shipments;";

    }
}
