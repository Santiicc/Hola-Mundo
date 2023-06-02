using System;
namespace ClassLibrary;

public class Basicuser:User
{
    //Usuario basico que hereda las funcionalidades de usuario 
    public int id{get;set;}
    public string nombre;

    public Basicuser(string name, string email, int phone) : base(name, email, phone)
    {
    }
}