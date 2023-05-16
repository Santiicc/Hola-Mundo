using System;

namespace Proyecto6;

class Program
{
    static void Main(string[]args)
    {
        Refugio refugio1=new Refugio("RefugioEsperanza","Calle256,EsqMitre");
        Dueño carlos=new Dueño("Carlos",093607913);
        carlos.crearrefugio(refugio1);
        Console.WriteLine(refugio1.owner);
        Categoria categoriax=new Categoria("Ambos");
        refugio1.agregarcategoria(refugio1,categoriax);
        Console.WriteLine($"Las categorias de {refugio1.nameshelter} son:");
        foreach (var item in refugio1.categories)
        {
            Console.WriteLine($"-{item.type}");
        }
        Calificacion calificacionx=new Calificacion(4.0);
        Calificacion calificacionx2=new Calificacion(1.8);
        Calificacion calificacionaux=new Calificacion(0.0);
        carlos.Calificate(refugio1,calificacionx);
        carlos.Calificate(refugio1,calificacionx2);
        Console.WriteLine($"El promedio de calificacion del refugio {refugio1.nameshelter} es: {calificacionaux.calcularpromedio(refugio1)}");
    }
}
