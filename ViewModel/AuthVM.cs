using CourseWork.Model;
using CourseWork.View;
using System.Windows;
using CourseWork.Utils;
using CourseWork.Model.Data.Service;

namespace CourseWork.ViewModel
{
    public class AuthVM : BaseVM
    {
        #region PROPERTIES
        public static string Nickname { get; set; }
        public string Password { get; set; }
        #endregion

        #region METHODS
        private void _OpenMainWnd()
        {
            MainWindow mainWindow = new();
            if (UserService.AuthUser(Nickname, Password))
                CommonUtil.OpenWindow(mainWindow);
            else MessageBox.Show("WRONG DATA!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void _OnWndLoaded() => UserService.CreateUser("test", "123");

        #endregion

        #region COMMANDS

        private readonly RelayCommand openMainWnd;
        public RelayCommand OpenMainWnd { get => openMainWnd ?? new(o => _OpenMainWnd()); }

        private RelayCommand onWndLoaded;

        public RelayCommand OnWndLoaded
        {
            get => onWndLoaded ?? new(o => _OnWndLoaded());
        }


        #endregion
    }
}
