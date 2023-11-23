using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RExmn_Diseño
{
    public partial class MainPage : ContentPage
    {
        double monto;
        double totalPagar;
        double montoPersona;
        double PersonPagar;
        double numPerson;
        double valorPorcentaje;
        double porcentaje;
  
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MostrarDatos_Clicked(object sender, EventArgs e)
        {
      
           
           
                totalPagar = Convert.ToInt64(MontoEnt.Text);
                numPerson = Convert.ToInt64(numeroPersona.Text);
                porcentaje = Convert.ToInt64(porcentajePropina.Text);
                SacarPorcentaje();
                montoCompleto();
                montoPorPersona();
                string mensaje = $"La cuenta es de {montoPersona} \nDejaste {monto} pesos de propina.\nLas personas son {numPerson} y deben pagar {PersonPagar}\n";
                mensaje += MostrarEstadoPropina(monto);
                await DisplayAlert("Resultado", mensaje, "OK");
        
        }
        
        public void montoPorPersona()
        {
         PersonPagar = montoPersona / numPerson;
        }
        public void montoCompleto()
        {
            montoPersona = monto + totalPagar;
            
        }
       
        public void SacarPorcentaje()
        {
            monto = totalPagar * porcentaje / 100;
        }
        
        private string MostrarEstadoPropina(double monto)
        {
            if (monto >= 10)
            {
                return "El empleado esta muy feliz";

            }
        
            else
            {
                return "Ya no esta feliz.";
            }
        }

    }
}