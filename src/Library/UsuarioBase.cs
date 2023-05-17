using System;
namespace Proyecto6;

public class UsuarioBase : Usuario
{
    //Usuario basico que hereda las funcionalidades de usuario 
    public int id{get;set;}
    public string nombre;

    public UsuarioBase(string name)
    {
        this.nombre=name;
    }

}