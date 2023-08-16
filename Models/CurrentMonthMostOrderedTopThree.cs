using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Models
{
    public class CurrentMonthMostOrderedTopThree
    {
        public string product_name { get; set; }
        public int ordered_quantity { get; set; }
    }
}