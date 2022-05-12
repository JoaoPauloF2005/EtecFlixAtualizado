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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.netflix.jpg");

            btnBatman.Source = ImageSource.FromResource("EtecFlix.Posters.thebatman.jpg");
            btnDoutorEstranho.Source = ImageSource.FromResource("EtecFlix.Posters.doutorestranho.jpg");
            btnHomemAranha.Source = ImageSource.FromResource("EtecFlix.Posters.homem_aranha.jpg");
            btnVingadores.Source = ImageSource.FromResource("EtecFlix.Posters.vingadores.jpg");
        }

        private async void Btn_Open_Batman(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Batman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_DoutorEstranho(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EtecFlix.Filmes.DoutorEstranho());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_HomemAranha(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EtecFlix.Filmes.HomemAranha());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_Vingadores(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EtecFlix.Filmes.Vingadores());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}