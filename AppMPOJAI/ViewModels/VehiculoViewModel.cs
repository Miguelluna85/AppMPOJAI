using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.Data;
using AppMPOJAI.Models;
using Xamarin.Forms;

namespace AppMPOJAI.ViewModels
{
    public class VehiculoViewModel : BaseViewModel
    {

        public VehiculoViewModel()
        {
            _ = getVehiculos();
        }
        private async Task getVehiculos()
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                eVehiculo eVehiculo = new eVehiculo();
                ListVehiculos = await vehiculo.getVehiculosAsync();
            }
            catch (Exception)
            {
                throw;
                //await Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
        }



        #region propiedades

        private List<eVehiculo> listVehiculos;
        public List<eVehiculo> ListVehiculos
        {
            get => listVehiculos;
            set
            {
                listVehiculos = value;
                OnPropertyChanged();
            }
        }


        private eVehiculo selectedVehiculo;
        public eVehiculo SelectedVehiculo
        {
            get => selectedVehiculo;
            set
            {
                selectedVehiculo = value;
                OnPropertyChanged();
            }
        }

        #endregion


    }
}
