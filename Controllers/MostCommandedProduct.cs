using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockAPI.Data;
using StockAPI.Models;

namespace StockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MostCommandedProduct : ControllerBase
    {
        private readonly DataContext _context;
        public MostCommandedProduct(DataContext context){
            _context = context;
        }

        [HttpGet("CurrentMonth")]
        public async Task<ActionResult<List<CurrentMonthMostCommandedTopThree>>> GetMonthlyRank()
        {
            var sqlQuery = @"SELECT p.design AS product_name, SUM(s.quantite_entree) AS commanded_quantity
                            FROM Products p 
                            INNER JOIN Stockages s ON p.num_produit = s.num_produit 
                            INNER JOIN Entrees e ON s.num_bon_liv = e.num_bon_liv 
                            WHERE strftime('%m',e.dateEntree) = strftime('%m',CURRENT_DATE) 
                            GROUP BY p.design 
                            ORDER BY commanded_quantity DESC 
                            LIMIT 3;
                        ";

            var most_commanded_monthly = await _context.TopThreeCommands.FromSqlRaw(sqlQuery).ToListAsync();

            return most_commanded_monthly;
        }
    }
}