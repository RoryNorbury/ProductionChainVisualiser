using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using ProductionChainVisualiser.ViewModels;
using System;
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
            // TODO: wait until mouse is back over item after going outside canvas
            if (_isDragging && _draggedItem == (Control)sender)
            {
                var currentPos = e.GetPosition(_draggedItem.FindAncestorOfType<Canvas>());
                var delta = currentPos - _dragStartPos;

                if (_draggedItem.DataContext is RecipeNodeViewModel node)
                {
                    node.LeftCoordinate += delta.X;
                    node.TopCoordinate += delta.Y;

                    // Ensure node stays within parent
                    if (node.LeftCoordinate < 0) { node.LeftCoordinate = 0; }
                    if (node.TopCoordinate < 0) { node.TopCoordinate = 0; }
                    // Get parent control (should be the contentpresenter)
                    Canvas canvas = _draggedItem.FindAncestorOfType<Canvas>() ?? throw new Exception("Could not find canvas ancestor");
                    if (node.LeftCoordinate + _draggedItem.Bounds.Width > canvas.Bounds.Width)
                    {
                        node.LeftCoordinate = canvas.Bounds.Width - _draggedItem.Bounds.Width;
                    }
                    if (node.TopCoordinate + _draggedItem.Bounds.Height > canvas.Bounds.Height)
                    {
                        node.TopCoordinate = canvas.Bounds.Height - _draggedItem.Bounds.Height;
                    }
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