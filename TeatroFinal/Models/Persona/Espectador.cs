using System;
using System.Collections.Generic;
using System.Text;

namespace TeatroFinal.Models.Persona
{
    public abstract class Espectador
    {
        public string Nombre { get; set; }
        public Espectador(string nombre)
        {
            Nombre = nombre;
        }
        public abstract long ComprarBoleta(Obra obra);
        public int CobrarRecargoExtra(int precioBoleta)
        {
            return (int)(precioBoleta + precioBoleta * 0.15);
        }
        
    }
}
