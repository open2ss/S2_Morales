using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S2_Morales
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnValidar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double parcial1, parcial2, notaFinal;
                double n1 = Convert.ToDouble(txtN1.Text);
                double e1 = Convert.ToDouble(txtE1.Text);


                double n2 = Convert.ToDouble(txtN2.Text);
                double e2 = Convert.ToDouble(txtE2.Text);


                parcial1 = (n1 * 0.3) + (e1 * 0.2);
                parcial2 = (n2 * 0.3) + (e2 * 0.2);
                notaFinal = parcial1 + parcial2;

                txtT1.Text = parcial1.ToString();
                txtT2.Text = parcial2.ToString();
                txtNF.Text = notaFinal.ToString();

                if (notaFinal >= 7)
                {
                    DisplayAlert("Aprobado", "Su calificacion es de: " + notaFinal + "/10", "Aceptar");
                    txtNF.BackgroundColor = Color.Green;
                }
                else
                {
                    DisplayAlert("Reprobado", "Su calificacion es de: " + notaFinal + "/10", "Aceptar");
                    txtNF.BackgroundColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Aceptar");
            }
        }
    }
}

