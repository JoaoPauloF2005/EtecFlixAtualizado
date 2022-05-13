using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomemAranha : ContentPage
    {
        public HomemAranha()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.netflix.jpg");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.homem_aranha.jpg");

            sinopse.Text = "O Homem-Aranha precisa lidar com as consequências da sua verdadeira identidade ter sido descoberta.";
        }
    }
}