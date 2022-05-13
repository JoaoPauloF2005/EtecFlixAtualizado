using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EtecFlix.Filmes;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.logo.png");

            btnjumangi2.Source = ImageSource.FromResource("EtecFlix.Posters.jumangi2.jpg");

        }

        private async void Btn_Open_Jumangi2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Jumangi2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}
        