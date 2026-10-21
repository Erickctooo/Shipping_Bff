namespace Shipping.Api.Application.Shipment.Query
{

    public class GetShipmentResponse
    {
        public IList<GetShipment> Shipments { get; set; } = new List<GetShipment>();
    }

    public class GetShipment
    {
        public int Id { get; set; }

        public int Os {  get; set; }

        public string SenderName { get; set; } = string.Empty;

        public string RecipientName { get; set; } = string.Empty;

        public string Origin { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;

        public decimal Weight { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
