using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoCurrency.Models
{
    public class ConversionResponseDTO
    {
        [DisplayName("Result")]
        public string ConvertedAmount { get; set; }
    }
}
