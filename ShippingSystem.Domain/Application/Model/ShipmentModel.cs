using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Domain.Application.Model
{
    public class ShipmentModel
    {
        public int Id { get; set; }

        public int Os {  get; set; }

        public string SenderName { get; set; } = string.Empty;

        public string RecipientName { get; set; } = string.Empty;

        public string Origin { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;

        public decimal Weight { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
