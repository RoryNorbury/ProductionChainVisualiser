using System.Collections.ObjectModel;

namespace ProductionChainVisualiser.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public RecipeNodeViewModel RecipeNodeViewModel1 { get; } = new RecipeNodeViewModel();
        public ObservableCollection<RecipeNodeViewModel> RecipeNodes { get; } = new ObservableCollection<RecipeNodeViewModel>();

    }
}
