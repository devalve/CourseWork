using System.Windows.Controls;
using CourseWork.Utils;

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
            FillUtil.FillDaysOfWeek(contentHeaderGrid, 0, 7);
            FillUtil.FillContentGrid(contentGrid);
        }
    }
}