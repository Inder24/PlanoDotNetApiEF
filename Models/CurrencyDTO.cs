using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoCurrency.Models
{
    public class CurrencyDTO
    {
        public CurrencyDTO(string name, string symbol, string currencyCode)
        {
            Name = name;
            Symbol = symbol;
            CurrencyCode = currencyCode;
        }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string CurrencyCode { get; set; }
    }
}
