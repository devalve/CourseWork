using CourseWork.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }
    }
}
