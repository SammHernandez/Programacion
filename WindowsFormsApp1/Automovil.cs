using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class Automovil : Vehiculo
    {
        private int cantidadpuertas;
        private String tipocombustible;
        public string matricula;
        public int Cantidadpuertas
        {
            get => cantidadpuertas;
            set => cantidadpuertas = value;
        }
        public String Tipocompustible
        {
            get => tipocombustible;
            set => tipocombustible = value;
        }
        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }
        public override String MostrarInformacion()
        {
            
            return base.MostrarInformacion() + "Cantidad de puertas: " + this.cantidadpuertas + 
            "Tipo de Combustible" + this.tipocombustible;
        }

    }
}

