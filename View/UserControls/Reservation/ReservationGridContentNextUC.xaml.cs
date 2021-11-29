using CourseWork.Utils;
using System.Windows.Controls;

namespace CourseWork.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReservationGridContentNextUC.xaml
    /// </summary>
    public partial class ReservationGridContentNextUC : UserControl
    {
        public ReservationGridContentNextUC()
        {
            InitializeComponent();
            FillUtil.FillDaysOfWeek(contentHeaderGrid, 7, 14);
            FillUtil.FillContentGrid(contentGrid);
        }
    }

}