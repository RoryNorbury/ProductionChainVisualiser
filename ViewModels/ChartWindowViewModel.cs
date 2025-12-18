using CommunityToolkit.Mvvm.Input;
using ProductionChainVisualiser.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.ViewModels
{
    public partial class ChartWindowViewModel : ViewModelBase
    {
        public const double NodeWidth = 150.0;
        public ObservableCollection<RecipeNodeViewModel> RecipeNodes { get; set; } = new ObservableCollection<RecipeNodeViewModel>();
        public ChartWindowViewModel()
        {
            AddNode();
        }
        [RelayCommand]
        private void AddNode()
        {
            // For testing, we add a sample node
            RecipeNodes.Add(SampleNode());
        }
        private RecipeNodeViewModel SampleNode()
        {
            Recipe SampleRecipe = new Recipe(

            "Test Recipe", // Name
            5.0, // Duration
            new List<ItemQuantity> // Inputs
            {
                new ItemQuantity("Iron Ore", 10),
                new ItemQuantity("Coal", 5)
            },
            new List<ItemQuantity> // Outputs
            {
                new ItemQuantity("Iron Ingot", 8)
            },
            15.0 // Power Usage
        );
            return new RecipeNodeViewModel(SampleRecipe, 1.0, 100, 100);
        }
    }
}
