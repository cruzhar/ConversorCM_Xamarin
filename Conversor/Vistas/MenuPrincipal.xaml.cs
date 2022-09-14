using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Conversor.Vistas;
using Conversor.Vista;

namespace Conversor.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }
    }
}