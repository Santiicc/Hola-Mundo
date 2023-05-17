using System;
namespace Proyecto6;

public class Dueño:Usuario
{
    //Usuario de tipo dueño que hereda funcionalidades de usuario y agrega mas
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
        refugiox.contactnumber=this.contacto;
    }  

    public void Cambiardescripcion(Refugio shelterx4,string descriptionx2)
    {
        shelterx4.description=descriptionx2;
    }

    //dueño podrá con estos dos metodos cambiar la descripcion del refugio y agregarle el nombre del dueño

    /*
        
        *MAS METODOS PARA EL DUEÑO PROXIMAMENTE*

    */
}