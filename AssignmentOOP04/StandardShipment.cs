using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trakingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination)
           : base(trakingcode, describtion, weight, deliveryFee, destination)
        {
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override decimal CalculateInsurance() => EstimatedCost * 0.05m;
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public override void PrintShipmentDetails()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

    }
}
