using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using ProductionChainVisualiser.ViewModels;
using System.Diagnostics;

namespace ProductionChainVisualiser.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Drag and drop logic - TEST

        private bool _isDragging;
        private Point _dragStartPos;
        private Control? _draggedItem;

        private void OnItemPointerPressed(object sender, PointerPressedEventArgs e)
        {
            _draggedItem = (Control)sender;
            _isDragging = true;
            _dragStartPos = e.GetPosition(_draggedItem.FindAncestorOfType<Canvas>());

            e.Handled = true;
        }

        private void OnItemPointerMoved(object sender, PointerEventArgs e)
        {
            if (_isDragging && _draggedItem == (Control)sender)
            {
                var currentPos = e.GetPosition(_draggedItem.FindAncestorOfType<Canvas>());
                var delta = currentPos - _dragStartPos;

                if (_draggedItem.DataContext is RecipeNodeViewModel node)
                {
                    node.LeftCoordinate += delta.X;
                    node.TopCoordinate += delta.Y;
                }

                _dragStartPos = currentPos;
                e.Handled = true;
            }
        }

        private void OnItemPointerReleased(object sender, PointerReleasedEventArgs e)
        {
            if (_isDragging)
            {
                _isDragging = false;
                e.Handled = true;
            }
        }
    }
}