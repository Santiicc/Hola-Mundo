using System;

namespace Proyecto6;

class Program
{
    static void Main(string[]args)
    {
        Refugio refugio1=new Refugio("RefugioEsperanzakdf","Calle256,EsqMitre","Refugio con mas de 100 años de experiencia");
        Refugio refugio2=new Refugio("RefugioEsperanza2smd","Calle256,EsqMitre2","Refugio con mas de 70 años de experiencia");
        Refugio refugio3=new Refugio("RefugioEsperanza3msd","Calle256,EsqMitre3","Refugio con mas de 10 años de experiencia");
        Dueño carlos=new Dueño("Carlos",093607913);
        Admin juan=new Admin("Juan");
        UsuarioBase lucas=new UsuarioBase("lucas");
        Refugiosaux refugiosaux1=new Refugiosaux();
        carlos.crearrefugio(refugio1);
        Console.WriteLine(refugio1.owner);
        Categoria categoriax=new Categoria("Ambos");
        Categoria categoria3=new Categoria("Bebes");
        refugio1.agregarcategoria(refugio1,categoriax);
        refugio1.agregarcategoria(refugio1,categoria3);
        Console.WriteLine($"Las categorias de {refugio1.nameshelter} son:");
        foreach (var item in refugio1.categories)
        {
            Console.WriteLine($"-{item.type}");
        }
        Calificacion calificacionx=new Calificacion(4.0);
        Calificacion calificacionx2=new Calificacion(1.8);
        Calificacion calificacionaux=new Calificacion(0.0);
        Calificacion calificacionx3=new Calificacion(3.2);
        Calificacion calificacionx4=new Calificacion(2.2);
        carlos.Calificate(refugio1,calificacionx);
        carlos.Calificate(refugio1,calificacionx2);
        Console.WriteLine($"El promedio de calificacion del refugio {refugio1.nameshelter} es: {calificacionaux.calcularpromedio(refugio1)}");
        carlos.Cambiardescripcion(refugio1,"Es un refugio con mas de 101 años de experiencia");
        Console.WriteLine(refugio1.description);
        juan.agregarrefugiobasedatos(refugio2,refugiosaux1);
        juan.agregarrefugiobasedatos(refugio3,refugiosaux1);
        lucas.Calificate(refugio2,calificacionx3);
        lucas.Calificate(refugio3,calificacionx4);
        lucas.buscarrefugios(refugiosaux1);

    }
}
