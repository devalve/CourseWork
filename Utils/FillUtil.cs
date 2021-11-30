using CourseWork.Model.Data;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace CourseWork.Utils
{
    public class FillUtil
    {
        private readonly static DateTime today = DateTime.Today;
        public static Grid CONTENT_GRID;


        private static void OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Строка: " + Grid.GetRow(sender as Button) + " Столбец: " + Grid.GetColumn(sender as Button));
            TextBox textBox = new() { Text = "Test" };
            CONTENT_GRID.Children.Add(textBox);
            Grid.SetRow(textBox, Grid.GetRow(sender as Button));
            Grid.SetColumn(textBox, Grid.GetColumn(sender as Button));
        }

        public static void FillContentGrid(Grid contentGrid, string page)
        {
            UIElement ui = new();
            for (int row = 0; row < 24; row++)
            {
                CONTENT_GRID = contentGrid;
                for (int column = 0; column < 7; column++)
                {
                    var dayOfWeek = today.AddDays(column).DayOfWeek;
                    if (dayOfWeek == DayOfWeek.Saturday | dayOfWeek == DayOfWeek.Sunday)
                    {
                        if (DataWorker.isReservationExist(row, column, page))
                        {
                            ui = new TextBox() { Text = "test" };
                        }
                        else
                        {
                            ui = new Button() { Content = "+" };
                            ((Button)ui).Click += OnClick;
                        }
                        contentGrid.Children.Add(ui);
                        Grid.SetColumn(ui, column);
                        Grid.SetRow(ui, row);
                    }
                }
            }
        }
        public static void FillDaysOfWeek(UniformGrid contentHeaderGrid, int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                //todo вынести в Loaded контрола
                StackPanel stackPanel = new() { Orientation = Orientation.Vertical, Margin = new Thickness(10, 0, 0, 0) };
                stackPanel.Children.Add(new TextBlock() { Text = today.AddDays(i).DayOfWeek.ToString() });
                stackPanel.Children.Add(new Label() { Content = today.AddDays(i).ToString("d"), FontWeight = FontWeights.Bold, FontSize = 7 });
                contentHeaderGrid.Children.Add(stackPanel);
            }
        }
    }
}
