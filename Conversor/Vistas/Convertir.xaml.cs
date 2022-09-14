using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;

        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lblResultado.Text = m.ToString() + " m";
        }
        private void Validar()
        {
            if( !string.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error","Ingrese una cantidad","OK");
            }
        }


        private void Volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

      

        private void CalcularCm_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}