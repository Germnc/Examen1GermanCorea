using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen1GermanCorea
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", txtnombre.Text + " " + txtapellido.Text, "OK");
        }

        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
            var contactos = new Models.Contactos
            {
                Nombre = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                
                Nota = txtnota.Text,
            };

            var page = new Views.PageTwo();
            page.BindingContext = contactos;
            await Navigation.PushAsync(page);
        }
    }
}
