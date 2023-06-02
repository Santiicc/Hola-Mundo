using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class ShelterManager
    {
        
        private Dictionary<int,Shelter>shelters;

        private int id;

        public ShelterManager()
        {
            shelters = new Dictionary<int, Shelter>();
        }

        public void CreateShelter(Administrator administrator,string name, string ubication, string description)
        {
            Shelter newShelter = new Shelter(name, ubication, description);
            IdGenerator idmanage= new IdGenerator();
            int id = idmanage.GenerateId();
            newShelter.id=id;
            shelters.Add(id,newShelter);
        }

        public Dictionary<int,Shelter> GetShelters()
        {
            return shelters;
        }

        public void removeShelter(int id)
        {
            shelters.Remove(id);
        }


        public void getinfo()
        {
            Console.WriteLine("Los refugios de la plataforma son:");
            foreach (KeyValuePair<int, Shelter> elemento in shelters)
                {
                    Console.WriteLine($"{elemento.Key}: {elemento.Value.nameshelter}");
                }
        }

        
    /*
        
        *MAS METODOS PARA REFUGIOSAUX PROXIMAMENTE*

    */


    }
}