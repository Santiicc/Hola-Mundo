﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class User
    {
        //Superclase Usuario
    private string name;

    private string email;

    private int phone;

    public User(string name,string email,int phone)
    {
        this.name=name;
        this.phone=phone;
        this.email=email;
    }

/*
    public void Calificate(Shelter shelterx4,Qualification calificationx3)
    {
        shelterx4.calificaciones.Add(calificationx3);
    }
    //Calificate obtiene un objeto de tipo Refugio y uno de tipo calificacion
    //Y añade ese objeto de tipo calificacion a la lista de calificaciones del tipo Refugio.
*/
/*
    public void buscarrefugios(Shelteraux shelterxaux4)
    {
        Dictionary<string,double>diiccauxcalificate=new Dictionary<string, double>();
        foreach (var item in shelterxaux4.listaderefugios)
        {
            foreach (var item2 in item.calificaciones)
            {
                diiccauxcalificate.Add(item.nameshelter,item2.calcularpromedio(item));
            }
        }
        Console.WriteLine("Los refugios disponibles en la plataforma son:");
        foreach (var item3 in diiccauxcalificate)
        {
            Console.WriteLine($"{item3.Key} con una valoracion de {item3.Value}");
        }
    }
*/
    
    /*
        
        *MAS METODOS PARA EL USUARIO PROXIMAMENTE*

    */

    }
}