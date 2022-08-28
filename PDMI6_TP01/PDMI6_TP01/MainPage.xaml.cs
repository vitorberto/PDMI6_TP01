using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDMI6_TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnOkButtonClicked(object sender, EventArgs args)
        {
            string id = idEntry.Text;
            string password = passEntry.Text;

            if (id == "admin" && password == "@dmin")
                await DisplayAlert("Sucesso", "Login efetuado com sucesso!", "Ok");
            else
                await DisplayAlert("Login não autorizado", "credenciais de acesso incorretas", "Ok");
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            idEntry.Text = "";
            passEntry.Text = "";

            idEntry.Focus();
        }

        private void OnCreditsButtonClicked(object sender, EventArgs e)
        {
            ContentPage credits = new Credits();
            Navigation.PushModalAsync(credits);
        }
    }
}
