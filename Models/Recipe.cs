using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public float Time { get; set; }
        public List<string> Inputs { get; set; } = new List<string>();
        public List<string> Outputs { get; set; } = new List<string>();
        public Recipe(string name, float time, List<string> inputs, List<string> outputs)
        {
            Name = name;
            Time = time;
            Inputs = inputs;
            Outputs = outputs;
        }
        public Recipe(string name, float time) : this(name, time, new List<string>(), new List<string>())
        { }
        public Recipe() : this("blank", 0.0f)
        { }
    }
}
