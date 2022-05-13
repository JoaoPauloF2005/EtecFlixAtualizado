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
    public partial class Jumangi2 : ContentPage
    {
        public Jumangi2()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.jumangi2.jpg");

            sinopse.Text = "Spencer volta ao mundo fantástico de Jumanji. Os amigos Martha, Fridge e Bethany entram no jogo e tentam trazê-lo para casa. Mas eles logo descobrem mais obstáculos e perigos a serem superados.";
        }


    }
}