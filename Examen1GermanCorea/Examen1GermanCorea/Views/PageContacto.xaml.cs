using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1GermanCorea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContacto : ContentPage
    {
        public PageContacto()
        {
            InitializeComponent();
         
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtnota.Text = "";
            
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtapellido.Text) &&
                !string.IsNullOrEmpty(txtedad.Text) &&
                !string.IsNullOrEmpty(txtnota.Text))
            {

                
                var contactos = new Models.Contactos
                {
                    Nombre = txtnombre.Text,
                    Apellidos = txtapellido.Text,
                    Edad = Convert.ToInt32(txtedad.Text),
                    Pais = pikpais.SelectedItem as string,
                    Nota = txtnota.Text,

                    
            };
                limpiar();

                if (await App.dbcontac.Storecontacto(contactos) > 0)
                    await DisplayAlert("Aviso", "Registro Ingresado con exito !!", "OK");

                
            }
            else
            {
               await DisplayAlert("Datos erróneos",
                    "Por favor, llena toda la información",
                    "Ok");
            }






        }
    }
}