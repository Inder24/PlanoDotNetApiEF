using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoCurrency.Models
{
    public class ExchangeDTO
    {

        public ExchangeDTO(string currencyCode , decimal exchangeRates)
        {
            CurrencyCode = currencyCode;
            ExchangeRates = exchangeRates;
        }
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRates { get; set; }
    }
}
