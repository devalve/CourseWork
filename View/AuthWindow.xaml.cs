using CourseWork.ViewModel;
using System.Windows;

namespace CourseWork.View
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
