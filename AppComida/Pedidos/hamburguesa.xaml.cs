using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComida.Pedidos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class hamburguesa : ContentPage
    {
        public hamburguesa()
        {
            InitializeComponent();
        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Llega_Pedido());
        }
    }
}