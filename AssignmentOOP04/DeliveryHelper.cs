using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal static class DeliveryHelper
    {
        public static void PrintShipment(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipmentDetails();
            }
        }
    }
}
