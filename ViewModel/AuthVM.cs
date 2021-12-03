using CourseWork.Model;
using CourseWork.Model.Data;
using CourseWork.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using CourseWork.Utils;

namespace CourseWork.ViewModel
{
    public class AuthVM : BaseVM
    {

        public static string Nickname { get; set; }
        public string Password { get; set; }

        #region METHODS
        private void OpenMainWindow()
        {
            MainWindow mainWindow = new();
            if (DataWorker.AuthUser(Nickname, Password))
                CommonUtil.OpenWindow(mainWindow);
            else MessageBox.Show("WRONG DATA!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
       
        #endregion

        #region COMMANDS

        private readonly RelayCommand openMainWnd;
        public RelayCommand OpenMainWnd { get => openMainWnd ?? new(o => OpenMainWindow()); }

        #endregion  
    }
}
