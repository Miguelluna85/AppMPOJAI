using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.Data;
using AppMPOJAI.Models;
using AppMPOJAI.Models.DTO;
using Xamarin.Forms;

namespace AppMPOJAI.ViewModels
{
    public class ConductorViewModel : BaseViewModel
    {

        public ConductorViewModel()
        {
          getConductores();
        }
        private void getConductores()
        {
            try
            {
                Conductor conductor = new Conductor();
                eConductorEmpleadoDTO eVehiculo = new eConductorEmpleadoDTO();
                ListConductores = conductor.getConductores();
            }
            catch (Exception ex)
            {
                throw ex;
                //await Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }
        }

        #region propiedades

        private List<eConductorEmpleadoDTO> listConductores;
        public List<eConductorEmpleadoDTO> ListConductores
        {
            get => listConductores;
            set
            {
                listConductores = value;
                OnPropertyChanged();
            }
        }

        private eVehiculo selectedConductor;
        public eVehiculo SelectedConductor
        {
            get => selectedConductor;
            set
            {
                selectedConductor = value;
                OnPropertyChanged();
            }
        }

        #endregion


    }
}
