using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Vehiculo
    {
        private String marca;
        private String modelo;
        private int año;

        public String Marca
        {
            get => marca;
            set => marca = value;
        }
        public String Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public int Año
        {
            get => año;
            set => año = value;
        }
        public virtual String MostrarInformacion()
        {
            return "Marca: " + this.marca + "Modelo: " + this.modelo +
            "Año: " + this.año;
            
        }
    }
}

