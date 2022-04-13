using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PlanoCurrency.Database
{
    public partial class CurrencyProp
    {
        [Key]
        [Column("CPID")]
        public long Cpid { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(5)]
        public string Symbol { get; set; }
        [StringLength(5)]
        public string CurrencyCode { get; set; }
        public short? DecimalPlace { get; set; }
    }
}
