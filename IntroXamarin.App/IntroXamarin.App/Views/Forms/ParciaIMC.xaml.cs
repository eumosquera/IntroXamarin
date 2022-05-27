using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParciaIMC : ContentPage
    {
        public ParciaIMC()
        {
            InitializeComponent();
        }

        private void Calcular_IMC(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var altura1 = (altura / 100);
                var imc = peso / (altura1 * altura1);

                ResultadoIMC.Text = Math.Round(imc, 2).ToString();
                 

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobrepreso";
                }
                else
                {
                    resultado = "Tienes obesidad, Come saludable";
                }

                DisplayAlert("Resultado", resultado, "Aceptar");
            }
            else
            {
            
                DisplayAlert("Notify",
                    "Faltaron Datos, Intenta otra vez",
                    "Aceptar");
            }

            
        }
    }
}