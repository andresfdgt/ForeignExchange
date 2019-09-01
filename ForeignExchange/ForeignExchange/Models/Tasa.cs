using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignExchange.Models
{
    public class Tasa
    {
        public int RateId { get; set; }
        public string Code { get; set; }
        public Double TaxRate { get; set; }
        public string Name { get; set; }
    }
}
