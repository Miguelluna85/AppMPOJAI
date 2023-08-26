using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppMPOJAI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName=null)

        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return;

            backingField = value;
            OnPropertyChanged(propertyName);            

        }

        //public async Task DisplayAlertViewModel(string titulo, string mensaje, string accion)
        //{
        //    await App.MasterDet.Detail.DisplayAlert(titulo, mensaje, accion);
        //}
    }
}
