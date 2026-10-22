using MediatR;

namespace Shipping.Api.Application.Shipment.Query.Get_Shipment
{
    public class GetShipmentRequest : IRequest<GetShipment>
    {
        public int Os { get; set; }
    }
}
