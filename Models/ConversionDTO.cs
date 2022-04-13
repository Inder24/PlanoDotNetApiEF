using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlanoCurrency.Models
{
    public class ConversionDTO
    {
        [Required]
        [DisplayName("Currency Code")]
        public string CurrCode { get; set; }

        [Required]
        [DisplayName("Amount")]
        public decimal? Amount { get; set; }

        [Required]
        [DisplayName("Target Currency Code")]
        public string TargetCode { get; set; }
    }
}
