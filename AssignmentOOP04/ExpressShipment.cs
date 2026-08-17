using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class ExpressShipment : Shipment
    {
        private decimal extrafee;

        public decimal Extrafee
        {
            get { return extrafee; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Invalid Fee");
                extrafee = value;
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + Extrafee;

        public ExpressShipment(string trakingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trakingcode, describtion, weight, deliveryFee, destination)
        {
            Extrafee = extraFee;
        }
        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }   


        public override decimal CalculateInsurance() => EstimatedCost * 0.08m;
        public override void PrintShipmentDetails()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee : {Extrafee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
