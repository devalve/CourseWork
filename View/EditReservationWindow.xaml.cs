using CourseWork.ViewModel;
using System.Windows;

namespace CourseWork.View
{
    /// <summary>
    /// Логика взаимодействия для EditReservationWindow.xaml
    /// </summary>
    public partial class EditReservationWindow : Window
    {
        public EditReservationWindow()
        {
            InitializeComponent();
            DataContext = new ReservationVM();
        }
    }
}
