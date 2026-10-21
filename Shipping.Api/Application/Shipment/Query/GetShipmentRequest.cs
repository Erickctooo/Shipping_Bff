using MediatR;

namespace Shipping.Api.Application.Shipment.Query
{
    public class GetShipmentRequest : IRequest<GetShipment>
    {
        public int Os { get; set; }
    }
}
