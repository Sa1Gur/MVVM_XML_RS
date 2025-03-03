﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_XML_RS.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected virtual void OnPropertyChanged(string PropertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));        

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }

}
