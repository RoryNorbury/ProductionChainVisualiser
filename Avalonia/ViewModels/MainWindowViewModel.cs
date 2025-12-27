using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using ProductionChainVisualiser.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProductionChainVisualiser.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() { }
        public ChartWindowViewModel ChartWindowViewModel { get; } = new ChartWindowViewModel();

    }
}
