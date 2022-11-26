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
    public partial class Registro : ContentPage
    {
        public Registro() // (string usuario)
        {
            InitializeComponent();
            //lblUsuario.Text = "El usuario conectado es";
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre .Text;
            string apellido = txtApellido.Text;
            string dierccion = txtDireccion.Text;
            string clave = txtClave.Text;

        }
    }
}