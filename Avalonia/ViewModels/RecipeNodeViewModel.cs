using CommunityToolkit.Mvvm.ComponentModel;
using ProductionChainVisualiser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionChainVisualiser.ViewModels
{
    public partial class RecipeNodeViewModel : ViewModelBase
    {
        public RecipeNodeViewModel(Recipe recipe, double machineCount, double leftCoordinate, double topCoordinate)
        {
            Recipe = recipe;
            MachineCount = machineCount;
            _leftCoordinate = leftCoordinate;
            _topCoordinate = topCoordinate;
        }

        public Recipe Recipe { get; set; } = new Recipe();
        /// <summary>
        /// The number of machines needed to match item demand
        /// </summary>
        public double MachineCount { get; set; } = 1.0;
        // Coordinates for displaying the node in the canvas
        [ObservableProperty]
        private double _leftCoordinate = 0;
        [ObservableProperty]
        private double _topCoordinate  = 0;
        [ObservableProperty]
        private double _zIndex = 0;
    }
}
