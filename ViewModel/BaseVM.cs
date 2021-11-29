﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModel
{
    public abstract class BaseVM : INotifyPropertyChanged, IDisposable

    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void Dispose() { }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}