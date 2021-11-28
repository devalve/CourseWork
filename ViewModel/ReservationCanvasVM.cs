using CourseWork.Model;
using System;
using System.Windows.Controls;
using CourseWork.View.UserControls;

namespace CourseWork.ViewModel
{
    public class ReservationCanvasVM : BaseVM
    {
        #region PROPERTIES
        private readonly string _nickname = AuthVM.Nickname;
        public static string UserIconPath { get => "/Resources/img/UserIcon.png"; }
        public string UserNickname { get => _nickname ?? "Default user"; }

        private UserControl _currentUserControl = new ReservationGridContentUC();

        public UserControl CurrentUserControl
        {
            get { return _currentUserControl; }
            set { _currentUserControl = value; NotifyPropertyChanged(nameof(CurrentUserControl)); }
        }

        private UserControl _prevUserControl;

        public UserControl PrevUserControl
        {
            get { return _prevUserControl; }
            set { _prevUserControl = value; NotifyPropertyChanged(nameof(PrevUserControl)); }
        }

        #endregion


        #region COMMANDS
        private RelayCommand userControlLoaded;
        public RelayCommand UserControlLoaded { get => userControlLoaded ?? new(o => Loaded()); }


        private RelayCommand setFutureReservationUserControl;
        public RelayCommand SetFutureReservationUserControl { get => setFutureReservationUserControl ?? new(o => _SetFutureReservationUserControl()); }

        private RelayCommand setPresentReservationUserControl;
        public RelayCommand SetPresentReservationUserControl { get => setPresentReservationUserControl ?? new(o => _SetPresentReservationUserControl()); }

        #endregion





        #region METHODS

        private static void Loaded()
        {

        }

        private void _SetFutureReservationUserControl()
        {
            PrevUserControl = CurrentUserControl;
            CurrentUserControl = new ReservationGridContentPastUC();
        }
        private void _SetPresentReservationUserControl()
        {
            CurrentUserControl = PrevUserControl;
        }

        #endregion


    }
}
public class Time
{
    public Time(string currentTime)
    {
        CurrentTime = currentTime ?? throw new ArgumentNullException(nameof(currentTime));
    }

    public string CurrentTime { get; set; }


}
