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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "xavier";
            string contraseña = "123456";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContraseña.Text;

            if (usuario == tUsuario & contraseña == tContrasena)
            {
               DisplayAlert("Alerta", "Correcto", "Cerrar");
                
            Navigation.PushAsync(new Menu()); // es el que navega en ventanas

                //await Navigation.PushAsync(new Registro( txUsuario.Text));

            }
            else
            {
                DisplayAlert("Alerta", "Usuario no existe", "cerrar");
            }
        }

        private void btnIngresa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}