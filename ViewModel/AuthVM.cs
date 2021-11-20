using CourseWork.Model;
using CourseWork.Model.Data;
using CourseWork.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace CourseWork.ViewModel
{
    public class AuthVM: INotifyPropertyChanged
    {


        private List<User> allUsers = DataWorker.GetAllUsers();

        public string Nickname { get; set; }
        public string Password { get; set; }
        public List<User> AllUsers
        {
            get => allUsers;
            set
            {
                allUsers = value;
                NotifyPropertyChanged(nameof(AllUsers));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region METHODS
        private void OpenMainWindow()
        {
            MainWindow mainWindow = new();
            if (DataWorker.AuthUser(Nickname, Password))
                OpenWindow(mainWindow);
            else MessageBox.Show("WRONG DATA!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private static void OpenWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.Show();
        }
        #endregion

        #region COMMANDS

        private readonly RelayCommand? openMainWnd;
        public RelayCommand OpenMainWnd { get => openMainWnd ?? new(o => OpenMainWindow()); }

        #endregion
    }
}
