using System;
namespace Proyecto6;

public class Admin:Usuario
{
    public int id{get;set;}
    public string nombre;

    public Admin(string name)
    {
        this.nombre=name;
    }
}