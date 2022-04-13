using PlanoCurrency.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoCurrency.Models
{
    public static class CurrencyConversionAndValidation
    {
        internal static string ConversionIntoTargetCurrency(ConversionDTO inputData, ApplicationDbContext context)
        {
            var currencyCodePresent = context.CurrencyProps.Where(currItem => currItem.CurrencyCode.Contains(inputData.CurrCode)).Count();
            var targetCurrencyCodePresent = context.CurrencyProps.Where(targetItem => targetItem.CurrencyCode.Contains(inputData.TargetCode)).Count();
            if(currencyCodePresent == 0 || targetCurrencyCodePresent == 0)
            {
                throw new Exception("Currency Code or Target Currency Code not present in database");
            }
            var targetCurrencyData = context.CurrencyProps.Where(currItem => currItem.CurrencyCode == inputData.TargetCode).ToList();
            var targetExchangeData = context.ExchangeRates.Where(currItem => currItem.CurrencyCode == inputData.TargetCode).ToList();

            var convertedValue = Math.Round((inputData.Amount.GetValueOrDefault() * targetExchangeData[0].ExchangeRates.GetValueOrDefault()), Convert.ToInt32(targetCurrencyData[0].DecimalPlace));
            return targetCurrencyData[0].Symbol + convertedValue;
        }
    }
}
