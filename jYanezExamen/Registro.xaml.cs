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
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "Es" + " " + usuario;
            this.usuario = usuario;
        }

        private void dpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string dt1 = txtNombre.Text;
            string dt2 = txtApellido.Text;
            string dt3 = txtEdad.Text;
            string dt4 = dpCountry.SelectedItem.ToString();
            string dt5 = dpCity.SelectedItem.ToString();
            string dt6 = Monto.Text;
            string dt7 = Pago.Text;

            Navigation.PushAsync(new Resumen( dt1, dt2, dt3, dt4,dt5,dt6, dt7 ));
            
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            int valorInicial = 1500;

            double valor = Convert.ToDouble(Monto.Text);
            double respt = (valorInicial - valor) / 4;
            double porcentaje = 0.04;
            double porce = (respt * porcentaje)+ respt;
            Pago.Text=porce.ToString();
        }
    }
}