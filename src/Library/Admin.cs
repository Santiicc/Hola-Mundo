using System;
namespace Proyecto6;

public class Admin:Usuario
{
    //Usuario de tipo admin que hereda funcionalidades de Usuario y agrega exclusivas de tipo admin
    public int id{get;set;}
    public string nombre;

    public Admin(string name)
    {
        this.nombre=name;
    }

    public void agregarrefugiobasedatos(Refugio refugiov,Refugiosaux refugiosauxv)
    {
        refugiosauxv.listaderefugios.Add(refugiov);
    }
     public void quitarrefugiobasedatos(Refugio refugiol,Refugiosaux refugiosauxl)
    {
        refugiosauxl.listaderefugios.Remove(refugiol);
    }

    //El admin con estos dos metodos iniciales tendrá la capacidad de agregar y quitar refugios de listaaux

    
    /*
        
        *MAS METODOS PARA EL ADMIN PROXIMAMENTE*

    */
}