using CourseWork.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace CourseWork.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReservationCanvasUC.xaml
    /// </summary>
    public partial class ReservationCanvasUC : UserControl
    {
        public ReservationCanvasUC()
        {
            InitializeComponent();
            DataContext = new ReservationCanvasVM();
            FillHoursStackPanel(hours);

        }
        private static void FillHoursStackPanel(StackPanel stackPanel)
        {

            for (int i = 0; i < 25; i++)
            {
                TextBlock tb = new()
                {
                    FontSize = 9,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 0, 0, 1)
                };
                switch (i)
                {
                    case < 10:
                        tb.Text = $"00:0{i}";
                        break;
                    case >= 10:
                        tb.Text = $"00:{i}";
                        break;
                    default:
                }
                stackPanel.Children.Add(tb);
            }

        }
    }
}
