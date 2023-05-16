using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto6;
public class Usuario
{
    public string name;

    public void Calificate(Refugio shelterx4,Calificacion calificationx3)
    {
        shelterx4.calificaciones.Add(calificationx3);
    }

    public void buscarrefugios(Refugiosaux shelterxaux4)
    {
        Dictionary<string,double>diiccauxcalificate=new Dictionary<string, double>();
        foreach (var item in shelterxaux4.listaderefugios)
        {
            foreach (var item2 in item.calificaciones)
            {
                diiccauxcalificate.Add(item.nameshelter,item2.calcularpromedio(item));
            }
        }
        Console.WriteLine("Los refugios disponibles en la plataforma son:");
        foreach (var item3 in diiccauxcalificate)
        {
            Console.WriteLine($"{item3.Key} con una valoracion de {item3.Value}");
        }
    }
}
