using MediatR;

namespace Shipping.Api.Application.Shipment.Query
{
    public class GetShipmentsRequest : IRequest<GetShipmentResponse> {}
   
}
