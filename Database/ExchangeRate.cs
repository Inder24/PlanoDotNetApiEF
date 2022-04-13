using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PlanoCurrency.Database
{
    public partial class ExchangeRate
    {
        [Key]
        [Column("ERID")]
        public long Erid { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? ExchangeRates { get; set; }
        public bool? IsDefault { get; set; }
    }
}
