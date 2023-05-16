using System;
namespace Proyecto6;

public class Calificacion
{
    public double rating;
    public Calificacion(double ratingx)
    {
        this.rating=ratingx;
    }

    public double calcularpromedio(Refugio shelterx3)
    {
        double sum=0.0;
        double counter=0.0;
        foreach (var item2 in shelterx3.calificaciones)
        {   
            sum=sum+item2.rating;
            counter=counter+1;
        }
        return sum/counter;
    }
}