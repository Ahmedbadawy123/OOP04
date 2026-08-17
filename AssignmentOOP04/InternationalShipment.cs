using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class InternationalShipment : Shipment
    {
        private string destinationcountry;
        private decimal customsfee;

        public string DestinationCountry

        {
            get { return destinationcountry; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("DestinationCountry Cannot Be Empty ");
                destinationcountry = value;
            }
        }
        public decimal CustomsFee
        {
            get { return customsfee; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Invalid CustomsFee");
                customsfee = value;
            }
        }
        public override string GetTrackingStatus() => $"Shipment {TrackingCode} has been Delivered.";

        public override decimal CalculateInsurance() => EstimatedCost * 0.12m;
       
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationcountry, decimal customsfee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = customsfee;
        }


        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("We Generate Customs Report For International Shipment.");
        }

        public override void PrintShipmentDetails()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

    }
}
