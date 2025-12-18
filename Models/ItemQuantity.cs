using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.Models
{
    public class ItemQuantity
    {
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public ItemQuantity(string itemName, int quantity)
        {
            ItemName = itemName;
            Quantity = quantity;
        }
        public string Display { get { return $"{ItemName} x {Quantity}"; } }
    }
}
