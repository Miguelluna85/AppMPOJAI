using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkiaSharp;
using Entry = Microcharts.ChartEntry;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;

namespace AppMPOJAI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoard : ContentPage
    {
        public DashBoard()
        {
            InitializeComponent();

            ChartDona.Chart = new DonutChart() { Entries = GetChart() };
        }

        public List<Entry> GetChart()
        {
            List<Entry> data = new List<Entry>
        {
            new Entry(1563532)
            {
                Label="Preventivos Internos",
                ValueLabel="50",
                Color=SKColor.Parse("#22EB41"),
                TextColor = SKColor.Parse("#DF013A")
            }
            ,
            new Entry(1063632)
            {
                Label="Correctivos",
                ValueLabel="25",
                Color=SKColor.Parse("#FCD803"),
                TextColor = SKColor.Parse("#DF013A")
            }
            ,
            new Entry(1043632)
            {
                Label="Rescates",
                ValueLabel="15",
                Color=SKColor.Parse("#0271F2"),
                TextColor = SKColor.Parse("#DF013A")
            }
            ,
            new Entry(1043632)
            {
                Label="Externos",
                ValueLabel="10",
                Color=SKColor.Parse("#E65409"),
                TextColor = SKColor.Parse("#DF013A")
            }

        };
            return data;
        }


    }
}