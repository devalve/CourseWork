using CourseWork.Model;
using CourseWork.Model.Data;
using CourseWork.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace CourseWork.ViewModel
{
    public class DataManageVM : INotifyPropertyChanged
    {
        private List<User> allUsers = DataWorker.GetAllUsers();
        public List<User> AllUsers
        {
            get => allUsers;
            set
            {
                allUsers = value;
                NotifyPropertyChanged("AllUsers");
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
            OpenWindow(mainWindow);
        }
        private void OpenWindow(Window window)
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
