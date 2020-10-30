using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2_Morales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnMainPage_Clicked1(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("estudiante2020") && txtPassword.Text.Equals("uisrael2020"))
            {
                await Navigation.PushAsync(new MainPage());

            }
            else
            {
                DisplayAlert("Mensaje de alerta", "clave incorrecta", "vuelva intentarlo");
            }
        }
    }
}