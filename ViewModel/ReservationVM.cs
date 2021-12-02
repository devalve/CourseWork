using CourseWork.Model;
using CourseWork.Model.Data;
using CourseWork.Utils;
using System;
using System.Windows;

namespace CourseWork.ViewModel
{
    public class ReservationVM : BaseVM
    {

        private static string nickname = AuthVM.Nickname;
        public static string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        private static TimeSpan timeFrom;
        public static TimeSpan TimeFrom
        {
            get { return timeFrom; }
            set { timeFrom = value; }
        }

        private static TimeSpan timeTo;
        public static TimeSpan TimeTo
        {
            get { return timeTo; }
            set { timeTo = value; }
        }

        private static string members;

        public static string Members
        {
            get { return members; }
            set { members = value; }
        }
        #region METHODS
        private static void _AddNewReservation()
        {
            if (Math.Abs(TimeFrom.TotalMinutes - TimeTo.TotalMinutes) > 30)
            {
                DataWorker.CreateReservation(FillUtil.ROW,
                                         FillUtil.COLUMN,
                                         FillUtil.PAGE,
                                         AuthVM.Nickname,
                                         Members);
                MessageBox.Show("Reservation has been successfully created. You can close this window", "Success!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else MessageBox.Show("The time interval should be more than 30 minutes", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private static void _OnClosed()
        {
            FillUtil.FillContentGrid(FillUtil.CONTENT_GRID, FillUtil.PAGE);
        }
        #endregion

        #region COMMANDS

        private readonly RelayCommand addNewReservation;
        public RelayCommand AddNewReservation { get => addNewReservation ?? new(o => _AddNewReservation()); }


        private readonly RelayCommand onClosed;
        public RelayCommand OnClosed { get => onClosed ?? new(o => _OnClosed()); }
        #endregion  
    }
}
