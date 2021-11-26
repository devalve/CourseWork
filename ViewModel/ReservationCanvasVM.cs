using CourseWork.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CourseWork.ViewModel
{
    public class ReservationCanvasVM : BaseVM
    {
        private readonly string _nickname = AuthVM.Nickname;
        public static string UserIconPath { get => "/Resources/img/UserIcon.png"; }
        public string Nickname { get => _nickname ?? "Default user"; }

        public static Grid contentGrid { get; set; }

        #region COMMANDS
        private RelayCommand userControlLoaded;
        public RelayCommand UserControlLoaded { get => userControlLoaded ?? new(o => Loaded()); }
        #endregion





        #region METHODS

        private static void Loaded()
        {
            MessageBox.Show("User Control was loaded!");
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