using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace jYanezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string dt1, string dt2, string dt3, string dt4, string dt5, string dt6, string dt7)
        {
            InitializeComponent();

            txtNombre.Text = dt1;
            txtApellido.Text = dt2;
            txtEdad.Text = dt3;
            txtCountry.Text = dt4;
            txtCiudad.Text = dt5;
            txtMonto.Text = dt6;
            txtPago.Text = dt7;

                
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}