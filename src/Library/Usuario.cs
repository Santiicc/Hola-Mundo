using System;

namespace Proyecto6;
public class Usuario
{
    public string name;


    public void Calificate(Refugio shelterx4,Calificacion calificationx3)
    {
        shelterx4.calificaciones.Add(calificationx3);
    }
}
