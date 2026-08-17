using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal abstract class Shipment : ITrackable, IInsurable
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;
        public abstract string GetTrackingStatus();
        public abstract decimal CalculateInsurance();

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }

            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set
            {
                destination = value;
            }
        }

        public abstract decimal EstimatedCost  {get;}


        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1, 100m, new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {

            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "Unknown";
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0)
            {
                DeliveryFee = newDeliveryFee;
            }

        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }


        public virtual void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {trackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            //Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            //Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        
    }
    }
