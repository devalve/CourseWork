using CourseWork.ViewModel;
using System.Windows;

namespace CourseWork.View
{
    /// <summary>
    /// Логика взаимодействия для AddNewReservationWindow.xaml
    /// </summary>
    public partial class AddNewReservationWindow : Window
    {
        public AddNewReservationWindow()
        {
            InitializeComponent();
            DataContext = new ReservationVM();
        }
    }
}
