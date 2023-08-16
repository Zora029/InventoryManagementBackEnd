using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.StructureJSON
{
    public class EntryWithStockagesInput
    {
        public string num_bon_liv { get; set; }
        public DateTime DateEntree { get; set; }
        public string nom_fournisseur { get; set; }
        public List<StockageInputModel> products { get; set; }
    }
}