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
                Os,
                SenderName,
                RecipientName,
                Origin,
                Destination,
                Weight,
                Status
             FROM dbo.Shipments;";

        internal static string QueryGet = @"

            SELECT
                Id,
                Os,
                SenderName,
                RecipientName,
                Origin,
                Destination,
                Weight,
                Status
             FROM dbo.Shipments
             Where Os = @os;";

    }
}
