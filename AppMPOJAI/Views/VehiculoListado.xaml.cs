using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMPOJAI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMPOJAI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehiculoListado : ContentPage
    {
        public VehiculoListado()
        {
            InitializeComponent();
            BindingContext = new VehiculoViewModel();
        }
    }
}