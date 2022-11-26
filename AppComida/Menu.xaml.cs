using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComida
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalchi_Papa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pedidos.Salchi_Papas()); // navega entre ventanas 
        }

        private void btnAmurgesa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pedidos.hamburguesa()); // navega entre ventanas 
        }

        private void btnAPapi_Pollo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pedidos.Papi_Pollo()); // navega entre ventanas
        }
    }
}