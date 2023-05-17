using System;
using System.Collections.Generic;

namespace Proyecto6
{
    public class Refugiosaux
    {
        public List<Refugio> listaderefugios=new List<Refugio>();

        public string namebasedatos{get;set;}


        public void getinfo(Refugio shelterf)
        {
            Console.WriteLine($"El nombre del refugio es: {shelterf.nameshelter}, el dueño de este refugio es {shelterf.owner}, este refugio se encuentra en.... ");
        }

        
    /*
        
        *MAS METODOS PARA REFUGIOSAUX PROXIMAMENTE*

    */


    }
}