using Shipping.Api.Application.Shipment.Query;
using Shipping.Domain.Application.Model;

namespace Shipping.Api.Application.Shipment.Mapper
{
    public static class ShipmentMapper
    {

        public static GetShipmentResponse MapToResponse(IEnumerable<Domain.Application.Model.ShipmentModel> data)
        {


            return new GetShipmentResponse
            {
                Shipments = data.Select(item => new GetShipment
                {
                    Id = item.Id,
                    SenderName = item.SenderName,
                    RecipientName = item.RecipientName,
                    Origin = item.Origin,
                    Destination = item.Destination,
                    Weight = item.Weight,
                    Status = item.Status,
                }).ToList()
            };
        }

    }
}
