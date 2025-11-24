using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace ProductionChainVisualiser.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddNode(object? sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Nuh uh");
        }
        private void RemoveNode(object? sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Nuh uh");
        }
    }
}