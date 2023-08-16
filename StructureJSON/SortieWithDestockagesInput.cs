using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.StructureJSON
{
    public class SortieWithDestockagesInput
    {
        public string num_facture { get; set; }
        public DateTime DateSortie { get; set; }
        public string? nom_cli { get; set; }
        public List<DestockageInputModel> products { get; set; }
    }
}