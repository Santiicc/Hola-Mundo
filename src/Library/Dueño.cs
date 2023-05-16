using System;
namespace Proyecto6;

public class Dueño:Usuario
{
    public string nombre{get;set;}

    public int contacto{get;set;}

    public Dueño(string name,int numero)
    {
        this.nombre=name;
        this.contacto=numero;
    }

    
    public void crearrefugio(Refugio refugiox)
    {
        refugiox.owner=this.nombre;
    }  

    public void Cambiardescripcion(Refugio shelterx4,string descriptionx2)
    {
        shelterx4.description=descriptionx2;
    }
}