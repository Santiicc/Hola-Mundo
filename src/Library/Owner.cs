using System;
namespace ClassLibrary;

public class Owner:User
{
    //Usuario de tipo dueño que hereda funcionalidades de usuario y agrega mas
    public string nombre;

    public int contacto;

    public Owner(string name, string email, int phone) : base(name, email, phone)
    {
    }


    /* 
     public void crearrefugio(Shelter refugiox)
     {
         refugiox.owner=this.nombre;
         refugiox.contactnumber=this.contacto;
     }  
     */

    /*
    public void Cambiardescripcion(Shelter shelterx4,string descriptionx2)
    {
        shelterx4.description=descriptionx2;
    }
    */
    //dueño podrá con estos dos metodos cambiar la descripcion del refugio y agregarle el nombre del dueño

    /*
        
        *MAS METODOS PARA EL DUEÑO PROXIMAMENTE*

    */
}