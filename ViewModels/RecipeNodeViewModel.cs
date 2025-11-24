using ProductionChainVisualiser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ReactiveUI;

namespace ProductionChainVisualiser.ViewModels
{
    public partial class RecipeNodeViewModel : ReactiveObject
    {
        private Point _position;
        public Point Position
        {
            get { return _position; }
            set
            {
                // part of ReactuiveUI, tells the View that this value has been changed
                this.RaiseAndSetIfChanged(ref _position, value);
            }
        }
        private Recipe _recipe;
        public Recipe Recipe
        {
            get { return _recipe; }
            set
            {
                // part of ReactuiveUI, tells the View that this value has been changed
                this.RaiseAndSetIfChanged(ref _recipe, value);
            }
        }
        /// <summary>
        /// Creates a new blank RecipeNodeViewModel
        /// </summary>
        public RecipeNodeViewModel()
        {

        }
        /// <summary>
        /// Creates a new RecipeNodeViewModel from a given RecipeNode
        /// </summary>
        /// <param name="recipeNode">The RecipeNode to load the data from</param>
        public RecipeNodeViewModel(RecipeNode recipeNode)
        {
            Position = recipeNode.Position;
            Recipe = recipeNode.Recipe;
        }
        /// <summary>
        /// Gets a RecipeNode of this ViewModel
        /// </summary>
        /// <returns>The RecipeNode</returns>
        public RecipeNode GetToDoItem()
        {
            return new RecipeNode()
            {
                Position = this.Position,
                Recipe = this.Recipe
            };
        }
    }
}
