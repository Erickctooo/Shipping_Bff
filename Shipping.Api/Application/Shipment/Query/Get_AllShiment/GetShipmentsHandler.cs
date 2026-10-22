using MediatR;
using Shipping.Api.Application.Shipment.Mapper;
using Shipping.Domain.Application.Model;
using Shipping.Domain.Application.Repository;

namespace Shipping.Api.Application.Shipment.Query.Get_AllShiment
{
    public class GetShipmentsHandler : IRequestHandler<GetShipmentsRequest, GetShipmentResponse>
    {

        private readonly IShipmentRepository _shipmentRepository;

        public GetShipmentsHandler(IShipmentRepository shipmentRepository) 
        {
            _shipmentRepository = shipmentRepository;
        }

        public async Task<GetShipmentResponse> Handle(GetShipmentsRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ShipmentModel> envios = await _shipmentRepository.GetAllAsync();

            GetShipmentResponse response = ShipmentMapper.MapToResponse(envios);

            return response;

        }

        
    }
}
