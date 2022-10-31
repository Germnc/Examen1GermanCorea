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
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.dbcontac.listacontactos();

        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageContacto());
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void maps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageMap());
        }
    }
}