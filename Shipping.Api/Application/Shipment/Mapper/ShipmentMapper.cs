using Shipping.Api.Application.Shipment.Query;
using Shipping.Domain.Application.Model;

namespace Shipping.Api.Application.Shipment.Mapper
{
    public static class ShipmentMapper
    {

        public static GetShipmentResponse MapToResponse(IEnumerable<ShipmentModel> data)
        {


            return new GetShipmentResponse
            {
                Shipments = data.Select(item => new GetShipment
                {
                    Id = item.Id,
                    Os = item.Os,
                    SenderName = item.SenderName,
                    RecipientName = item.RecipientName,
                    Origin = item.Origin,
                    Destination = item.Destination,
                    Weight = item.Weight,
                    Status = item.Status,
                }).ToList()
            };
        }

        public static GetShipment Map(ShipmentModel data) {

            return new GetShipment
            {
                Id = data.Id,
                Os = data.Os,
                SenderName = data.SenderName,
                RecipientName = data.RecipientName,
                Origin = data.Origin,
                Destination = data.Destination,
                Weight = data.Weight,
                Status = data.Status,
            };
        }
    }
}
