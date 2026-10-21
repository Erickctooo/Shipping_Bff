using MediatR;
using Shipping.Api.Application.Shipment.Mapper;
using Shipping.Domain.Application.Model;
using Shipping.Domain.Application.Repository;

namespace Shipping.Api.Application.Shipment.Query
{
    public class GetShipmentHandler : IRequestHandler<GetShipmentRequest, GetShipment>
    {

        private readonly IShipmentRepository _shipmentRepository;

        public GetShipmentHandler(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        public async Task<GetShipment> Handle(GetShipmentRequest request, CancellationToken cancellationToken)
        {


            ShipmentRequest reque = new ShipmentRequest
            {
                Os = request.Os
            };

            ShipmentModel? envio = await _shipmentRepository.GetAsync(reque);

            if (envio is null)
            {
                throw new KeyNotFoundException(
                    $"No se encontró un envío con la OS {request.Os}");
            }

            GetShipment response = ShipmentMapper.Map(envio);

            return response;
        }
    }
}
