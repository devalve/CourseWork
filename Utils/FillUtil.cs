using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace CourseWork.Utils
{
    public static class FillUtil
    {
        private readonly static DateTime today = DateTime.Today;
        public static void FillContentGrid(Grid contentGrid)
        {
            for (int row = 0; row < 24; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    var dayOfWeek = today.AddDays(column).DayOfWeek;
                    if (dayOfWeek == DayOfWeek.Saturday | dayOfWeek == DayOfWeek.Sunday)
                    {
                        Button button = new() { Content = "+" };
                        contentGrid.Children.Add(button);
                        Grid.SetColumn(button, column);
                        Grid.SetRow(button, row);
                    }
                }
            }
        }
        public static void FillDaysOfWeek(UniformGrid contentHeaderGrid, int from, int to)
        {
            if (from < 0 || to < 0)
            {
                for (int i = from; i < to; i++)
                {
                    //todo вынести в Loaded контрола
                    StackPanel stackPanel = new() { Orientation = Orientation.Vertical, Margin = new Thickness(10, 0, 0, 0) };
                    stackPanel.Children.Add(new TextBlock() { Text = today.AddDays(-i).DayOfWeek.ToString() });
                    stackPanel.Children.Add(new Label() { Content = today.AddDays(-i).ToString("d"), FontWeight = FontWeights.Bold, FontSize = 7 });
                    contentHeaderGrid.Children.Add(stackPanel);
                }
            }
            else for (int i = from; i < to; i++)
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
