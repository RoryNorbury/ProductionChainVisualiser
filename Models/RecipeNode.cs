using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.Models
{
    public class RecipeNode
    {
        // relative to canvas center
        public Point Position { get; set; }
        public Recipe Recipe { get; set; }

        public RecipeNode(Point position, Recipe recipe)
        {
            Position = position;
            Recipe = recipe;
        }
        public RecipeNode() : this(new Point(0.0, 0.0), new Recipe("blank", 0.0f))
        { }
    }
}
