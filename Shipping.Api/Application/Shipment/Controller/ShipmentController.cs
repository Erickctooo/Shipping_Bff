using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shipping.Api.Application.Shipment.Query;
using System.Net;

namespace Shipping.Api.Application.Shipment.Controller
{

    [ApiController]
    [Route("api/shipments/")]
    public class ShipmentController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        [ProducesResponseType(typeof(GetShipmentResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<GetShipmentResponse>> GetShipments()
        {
            GetShipmentResponse result =
                await _mediator.Send(new GetShipmentsRequest());

            return Ok(result);
        }


        [HttpGet("{Os}")]
        [ProducesResponseType(typeof(GetShipment), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<GetShipment>> GetShipment([FromRoute]  GetShipmentRequest request)
        {
            GetShipment result =
                await _mediator.Send(request);

            return Ok(result);
        }
    }
}
