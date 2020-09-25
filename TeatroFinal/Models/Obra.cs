using System;
using System.Collections.Generic;
using System.Text;
using TeatroFinal.Models.Persona;

namespace TeatroFinal.Models
{
    public class Obra
    {
        public string Titulo { get; set; }
        public List<Espectador> Espectadores { get; set; }
        public int Hora { get; set; }
        public long Recaudo { get; set; }

        public Obra(string titulo, int hora)
        {
            Espectadores = new List<Espectador>();
            Titulo = titulo;
            Hora = hora;
        }

        public void MostrarAbonados()
        {
            string nombresAbonados = "----- Lista de Abonados ----- \n";            
            foreach (var espectador in Espectadores)
            {
                if (typeof(Abonado).IsInstanceOfType(espectador))
                {
                    Abonado abonado = (Abonado)espectador;
                    nombresAbonados += "nombre :" + $"{abonado.Nombre}" + "\n";                    
                }
            }
            Console.WriteLine(nombresAbonados);
        }

        public void MostrarOcasional()
        {
            string nombresAbonados = "----- Lista de Ocacionales ----- \n";
            foreach (var espectador in Espectadores)
            {
                if (typeof(Ocacional).IsInstanceOfType(espectador))
                {
                    Ocacional ocacional = (Ocacional)espectador;
                    nombresAbonados += "nombre :" + $"{ocacional.Nombre}" + "\n";

                }
            }
            Console.WriteLine(nombresAbonados);
        }


    }
}
