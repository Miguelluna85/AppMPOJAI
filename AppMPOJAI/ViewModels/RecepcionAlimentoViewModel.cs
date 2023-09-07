using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AppMPOJAI.Data;
using AppMPOJAI.Models;
using Xamarin.Forms;

namespace AppMPOJAI.ViewModels
{
    public class RecepcionAlimentoViewModel : BaseViewModel
    {
        public ICommand GuardarCommand => new Command(async ()=>await Guardar());

        public RecepcionAlimentoViewModel()
        {
            getVehiculosXArea();
            getDepartamentosXArea();
        }

        #region Metodos
        private void getVehiculosXArea()
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                eVehiculo eVehiculo = new eVehiculo();
                ListVehiculos =  vehiculo.getVehiculosActivosxArea(6);
            }
            catch (Exception ex)
            {
                throw ex;
                //await Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
        }
        private void getDepartamentosXArea()
        {
            try
            {                
                Departamento departamento = new Departamento();
                eDepartamento eDepartamento = new eDepartamento();
                ListDepartamentos = departamento.getDepartamentosActivosXArea(2);
            }
            catch (Exception ex)
            {
                throw ex;
                //await Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
        }

        private async Task Guardar()
        {
            await Task.Delay(2000);
            await App.Current.MainPage.DisplayAlert("Mensaje","Enviado Correctamente","Ok");
        }
        #endregion

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

        private List<eDepartamento> listDepartamentos;
        public List<eDepartamento> ListDepartamentos
        {
            get => listDepartamentos;
            set
            {
                listDepartamentos = value;
                OnPropertyChanged();
            }
        }
        private eDepartamento selectedDepartamento;
        public eDepartamento SelectedDepartamento
        {
            get => selectedDepartamento;
            set
            {
                selectedDepartamento = value;
                OnPropertyChanged();
            }
        }
        #endregion


    }
}
