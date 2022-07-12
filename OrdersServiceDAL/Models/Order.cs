using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersServiceDAL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string SenderTown { get; set; }
        
        public string SenderAddress { get; set; }

        public string DestinationTown { get; set; }

        public string DestinationAddress { get; set; }

        public double LoadWeightInKilos { get; set; }
        
        public DateTime ShippingTime { get; set; }
    }
}