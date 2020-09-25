using System;
using TeatroFinal.Models;
using TeatroFinal.Models.Persona;

namespace TeatroFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Abonado("Diego");
            var p2 = new Ocacional("Alejo");
            var obra = new Obra("El Señor de los Anillos", 10);
            var teatro = new Teatro("Teatro Mayor");
            teatro.VenderBoleta(obra, p1);
            teatro.VenderBoleta(obra, p2);
            teatro.VenderBoleta(obra, p2);
            teatro.VenderBoleta(obra, p2);

            obra.MostrarAbonados();
            obra.MostrarOcasional();
            Console.WriteLine($"obra.Recaudo {obra.Recaudo}");
            Console.Read();
        }
    }
}
