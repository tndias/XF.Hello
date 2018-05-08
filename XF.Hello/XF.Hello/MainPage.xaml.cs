using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Hello
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }
        private void ClicarNomeBotao(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                DisplayAlert("Atenção"
                    , "Informe o seu nome na caixa de texto", "OK");
                txtTexto.Focus();
            }
            else
                DisplayAlert("Atenção"
                    , string.Format("Olá, {0}, seja bem-vindo", txtTexto.Text)
                    , "OK");
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void btnConfig_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConfigPage());
        }

        private async void btnConteudo_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CursoPage());
        }
        private async void btnDataBinding_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataBindingPage());
        }
    }
}
