using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Day29
{
    /// <summary>
    /// Логика взаимодействия для ThirdTask.xaml
    /// </summary>
    public partial class ThirdTask : Window
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Brush brush = Brushes.Black;
        private int brushSize = 1;

        public ThirdTask()
        {
            InitializeComponent();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
            startPoint = e.GetPosition(canvas);
        }

        private void canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Line line = new Line()
                {
                    Stroke = brush,
                    X1 = startPoint.X,
                    Y1 = startPoint.Y,
                    X2 = e.GetPosition(canvas).X,
                    Y2 = e.GetPosition(canvas).Y,
                    StrokeThickness = brushSize
                };
                canvas.Children.Add(line);
                startPoint = e.GetPosition(canvas);
            }
        }

        private void brushColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string color = ((ComboBoxItem)brushColor.SelectedItem).Content.ToString();
            brush = (Brush)new BrushConverter().ConvertFromString(color);
        }

        private void brushSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = (int)BrushSizesSlider.Value;
        }

        private void drawingMode_Checked(object sender, RoutedEventArgs e)
        {
            editingMode.IsChecked = false;
            deletingMode.IsChecked = false;
        }

        private void editingMode_Checked(object sender, RoutedEventArgs e)
        {
            drawingMode.IsChecked = false;
            deletingMode.IsChecked = false;
        }

        private void deletingMode_Checked(object sender, RoutedEventArgs e)
        {
            drawingMode.IsChecked = false;
            editingMode.IsChecked = false;
        }

        private void BrushSizesSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = (int)BrushSizesSlider.Value;
        }

        private void brushColor_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}