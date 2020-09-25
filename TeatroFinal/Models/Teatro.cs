using System;
using System.Collections.Generic;
using System.Text;
using TeatroFinal.Models.Persona;

namespace TeatroFinal.Models
{
    public class Teatro
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }

        public Teatro(string nombre)
        {
            Nombre = nombre;
            Capacidad = 0;
        }

        public bool VenderBoleta(Obra obra,Espectador espectador)
        {
            Capacidad++;
            if (Capacidad <= Constantes.CapacidadMaxima)
            {               
                obra.Espectadores.Add(espectador);
                obra.Recaudo += espectador.ComprarBoleta(obra);
                return Constantes.CupoDisponible;
            }
            Console.WriteLine("EL Teatro está lleno");
            return Constantes.CupoNoDisponible;
        }
    }
}
