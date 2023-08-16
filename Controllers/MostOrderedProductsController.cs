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
    public class MostOrderedProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public MostOrderedProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MostOrdered>>> GetGlobalRank()
        {
            var sqlQuery = @"SELECT  p.num_produit AS num_produit ,p.design AS product_name, SUM(d.quantite_sortie) AS ordered_quantity FROM Products p INNER JOIN Destockages d ON p.num_produit = d.num_produit GROUP BY p.design ORDER BY SUM(d.quantite_sortie) DESC LIMIT 5;";

            var most_ordered = await _context.MostsOrdered.FromSqlRaw(sqlQuery).ToListAsync();

            return most_ordered;
        }
        [HttpGet("CurrentMonth")]
        public async Task<ActionResult<List<CurrentMonthMostOrderedTopThree>>> GetMonthlyRank()
        {
            var sqlQuery = @"SELECT p.design AS product_name, SUM(d.quantite_sortie) AS ordered_quantity
                            FROM Products p 
                            INNER JOIN Destockages d ON p.num_produit = d.num_produit 
                            INNER JOIN Sorties s ON d.num_facture = s.num_facture 
                            WHERE strftime('%m',s.dateSortie) = strftime('%m',CURRENT_DATE) 
                            GROUP BY p.design 
                            ORDER BY ordered_quantity DESC 
                            LIMIT 3;
                        ";

            var most_ordered_monthly = await _context.TopThreeOrders.FromSqlRaw(sqlQuery).ToListAsync();

            return most_ordered_monthly;
        }

    }
}