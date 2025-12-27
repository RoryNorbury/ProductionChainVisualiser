using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.Models
{
    public class Recipe
    {
        /// <summary>
        /// string to identify the recipe
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// time in seconds to complete the recipe
        /// </summary>
        public double Time { get; set; }
        /// <summary>
        /// list of input item names
        /// </summary>
        public List<ItemQuantity> Inputs { get; set; } = new List<ItemQuantity>();
        /// <summary>
        /// list of output item names
        /// </summary>
        public List<ItemQuantity> Outputs { get; set; } = new List<ItemQuantity>();
        /// <summary>
        /// indicates the power usage for the recipe every second
        /// units unconfirmed, most likely EU/s
        /// </summary>
        public double PowerUsage { get; set; } = 0.0;
        public Recipe(string name, double time, List<ItemQuantity> inputs, List<ItemQuantity> outputs, double powerUsage)
        {
            Name = name;
            Time = time;
            Inputs = inputs;
            Outputs = outputs;
            PowerUsage = powerUsage;
        }
        public Recipe(string name, double time)
        { 
            Name = name;
            Time = time;
        }
        // this really shouldn't ever be used, hopefully we can remove it later
        public Recipe() : this("blank", 0.0f)
        { }
    }
}
