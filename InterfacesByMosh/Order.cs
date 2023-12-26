using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesByMosh
{
    public class Order
    {
        public Shipment Shipment;
        public bool IsShipped { get { return Shipment != null; } }
        public float TotalPrice { get; set; }
        public int ID { get; set; }

        public DateTime DatePlaced {  get; set; }
    }

}
