using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Operacion_de_2_numeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var resultado = dato1 + dato2;
            Resultado.Text = resultado.ToString();
            string mensaje = "";
        }
    }
}
