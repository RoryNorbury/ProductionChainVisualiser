using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.Models
{
    // UNUSED, should delete later
    public class ItemQuantityCollection
    {
        public List<ItemQuantity> Items { get; set; } = new List<ItemQuantity>();
        public ItemQuantityCollection() 
        {
            EvaluateIndexes();
        }
        public ItemQuantityCollection(List<ItemQuantity> items)
        {
            Items = items;
            EvaluateIndexes();
        }
        public void EvaluateIndexes()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Index = i;
            }
        }
        public string RowDefinitions
        {
            get
            {
                return string.Join(",", Enumerable.Repeat("*", Items.Count));
            }
        }
    }
}
