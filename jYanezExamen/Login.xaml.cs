using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jYanezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            String usuario = "estudiante2023";
            String contraseña = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContrasena.Text == contraseña)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "usuario/contaseña incorrectos", "cerrar");
            }
        }
    }

}