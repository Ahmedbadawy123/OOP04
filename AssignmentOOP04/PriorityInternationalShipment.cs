using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationcountry, decimal customsfee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationcountry, customsfee)
        {

        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating Priorty Sealed For Customer Reports.");
        }
    }
}
