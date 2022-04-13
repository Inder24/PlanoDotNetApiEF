using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlanoCurrency.Database;
using PlanoCurrency.Models;

namespace PlanoCurrency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CurrencyConverterController(ApplicationDbContext  dbContext)
        {
            _context = dbContext;
        }

        [HttpGet("Currencies")]
        public async Task<ActionResult<List<CurrencyDTO>>> GetAllCurrencies()
        {
            return Ok(_context.CurrencyProps.Select(x => new CurrencyDTO(x.Name,x.Symbol,x.CurrencyCode)).ToList());
        }

        [HttpGet("ExchanegRates")]
        public async Task<ActionResult<ExchangeDTO>> GetAllExchangeRates()
        {
            return Ok(_context.ExchangeRates.Select(x => new ExchangeDTO(x.CurrencyCode, x.ExchangeRates.GetValueOrDefault())).ToList());
        }

        [HttpPost("Conversion")]
        public async Task<ActionResult<ConversionResponseDTO>> ConvertCurrencyRates(ConversionDTO inputData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ConversionResponseDTO response = new ConversionResponseDTO();
                    response.ConvertedAmount = CurrencyConversionAndValidation.ConversionIntoTargetCurrency(inputData,_context);
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    return BadRequest("Invalid Data. Please check request data and try again.");
                }

            }
            else
            {
                return BadRequest("Request not upto API Standards");
            }
        }
    }
}
