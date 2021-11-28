using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;


namespace CourseWork.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReservationGridContentUC.xaml
    /// </summary>
    public partial class ReservationGridContentUC : UserControl
    {
        DateTime today = DateTime.Today;

        public ReservationGridContentUC()
        {
            InitializeComponent();
            FillDaysOfWeek();
            FillContentGrid();

        }
        private void FillDaysOfWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                //todo вынести в Loaded контрола
                StackPanel stackPanel = new() { Orientation = Orientation.Vertical, Margin = new Thickness(10, 0, 0, 0) };
                stackPanel.Children.Add(new TextBlock() { Text = today.AddDays(i).DayOfWeek.ToString() });
                stackPanel.Children.Add(new Label() { Content = today.AddDays(i).ToString("d"), FontWeight = FontWeights.Bold, FontSize = 7 });
                contentHeaderGrid.Children.Add(stackPanel);
            }

        }
        private void FillContentGrid()
        {
            for (int row = 0; row < 23; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    Button button = new() { Content = "+" };
                    contentGrid.Children.Add(button);
                    Grid.SetColumn(button, column);
                    Grid.SetRow(button, row);
                }
            }
        }

    }
}