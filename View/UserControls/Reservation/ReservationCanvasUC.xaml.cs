using CourseWork.Utils;
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
            FillUtil.FillHoursStackPanel(hours);
        }

    }
}
