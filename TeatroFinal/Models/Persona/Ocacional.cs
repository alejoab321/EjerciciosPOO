using System;
using System.Collections.Generic;
using System.Text;

namespace TeatroFinal.Models.Persona
{
    public class Ocacional : Espectador
    {
        public Ocacional(string nombre) : base(nombre)
        {
        }

        public override long ComprarBoleta(Obra obra)
        {
            int precioBoleta = Constantes.PrecioBoletaOcasional;
            if (obra.Hora > 9)
            {
                return CobrarRecargoExtra(precioBoleta);
            }
            return precioBoleta;
        }
    }
}
