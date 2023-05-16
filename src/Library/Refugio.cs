using System;
namespace Proyecto6;

public class Refugio
{
    public string owner{get;set;}

    public string ubication{get;set;}

    public string nameshelter{get;set;}

    public List<Categoria>categories=new List<Categoria>();

    public string description{get;set;}
    public List<Calificacion> calificaciones = new List<Calificacion>();


    public Refugio(string namex,string ubicationx)
    {
        this.ubication=ubicationx;
        this.nameshelter=namex;
    }

     public void agregarcategoria(Refugio refugiox2,Categoria categoriax)
    {
        refugiox2.categories.Add(categoriax);
    }


}