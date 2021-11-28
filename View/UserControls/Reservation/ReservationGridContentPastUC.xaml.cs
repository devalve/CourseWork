using System;
using System.Windows;
using System.Windows.Controls;

namespace CourseWork.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReservationGridContentUC.xaml
    /// </summary>
    public partial class ReservationGridContentPastUC : UserControl
    {
        readonly DateTime today = DateTime.Today;
        public ReservationGridContentPastUC()
        {
            InitializeComponent();
            FillDaysOfWeek();
        }
        private void FillDaysOfWeek()
        {
            for (int i = 7; i < 14; i++)
            {
                StackPanel stackPanel = new() { Orientation = Orientation.Vertical };
                stackPanel.Children.Add(new TextBlock() { Text = today.AddDays(i).DayOfWeek.ToString() });
                stackPanel.Children.Add(new Label() { Content = today.AddDays(i).ToString("d"), FontWeight = FontWeights.Bold, FontSize = 7 });
                contentHeaderGrid.Children.Add(stackPanel);
            }
        }
    }

}