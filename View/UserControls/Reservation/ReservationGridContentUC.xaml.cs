using System;
using System.Windows;
using System.Windows.Controls;

namespace CourseWork.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReservationGridContentUC.xaml
    /// </summary>
    public partial class ReservationGridContentUC : UserControl
    {

        public ReservationGridContentUC()
        {
            InitializeComponent();
            FillDaysOfWeek();
        }
        private void FillDaysOfWeek()
        {
            DateTime today = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                StackPanel stackPanel = new() { Orientation = Orientation.Vertical };
                stackPanel.Children.Add(new TextBlock() { Text = today.AddDays(i).DayOfWeek.ToString() });
                stackPanel.Children.Add(new Label() { Content = today.AddDays(i).ToString("d"), FontWeight = FontWeights.Bold, FontSize = 7 });
                contentHeaderGrid.Children.Add(stackPanel);
            }
        }
    }

}