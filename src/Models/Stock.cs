using System;

namespace stocks.Models
{
    public class Stock
    {
        public int ID { get; set; }

        public string Ticker { get; set; }

        public string Name { get; set; }

        public DateTime Updated { get; set; }

        public decimal Price { get; set; }
    }
}