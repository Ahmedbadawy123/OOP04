using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] shipments;
        private int count;
        private int MaxCapacity;
        public Driver Driver { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            count = 0;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return shipments[index];
                return null;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var shipment in shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                        return shipment;
                }

                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (count < MaxCapacity)
            {
                shipments[count++] = shipment;
                Console.WriteLine("Shipment Added Successfully.");
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string trackingcode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingcode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[--count] = null;
                    Console.WriteLine("Shipment Removed Successfully.");
                    return true;
                }
            }
            Console.WriteLine("\n NOt Found");
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipmentDetails();
            }
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            for (int i = 0; i < count; i++)
            {
                ITrackable trackable = shipments[i];
                Console.WriteLine(trackable.GetTrackingStatus());
            }
        }

        public Shipment[] GetActiveShipments()
        {
            Shipment[] result = new Shipment[count];
            Array.Copy(shipments, result, count);
            return result;
        }
    }
}
