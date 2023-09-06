using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.Data;
using AppMPOJAI.Models;
using Xamarin.Forms;

namespace AppMPOJAI.ViewModels
{
    public class RecepcionAlimentoViewModel : BaseViewModel
    {

        public RecepcionAlimentoViewModel()
        {
            getVehiculosXArea();
        }
        private async Task getVehiculosXArea()
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                eVehiculo eVehiculo = new eVehiculo();
                ListVehiculos = await vehiculo.getVehiculosActivosxAreaAsync(6);
            }
            catch (Exception ex)
            {
                throw ex;
                //await Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
        }

        private async Task getDepartamentosXArea()
        {
            try
            {                
                Departamento departamento = new Departamento();
                eDepartamento eDepartamento = new eDepartamento();
                ListDepartamentos = await departamento.getDepartamentosActivosXAreaAsync(2);
            }
            catch (Exception ex)
            {
                throw ex;
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
