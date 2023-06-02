using System;

namespace ClassLibrary
{
    public class Administrator:User
    {
    public int id{get;set;}
    public string nombre;

        public Administrator(string name, string email, int phone) : base(name, email, phone)
        {
        }

/*
        public void addShelter(string name, string location, string description,ShelterManager shelterManager)
    {
        shelterManager.CreateShelter(name,location,description);
    }
     public void removeShelter(int id,ShelterManager sheltermanager )
    {
        sheltermanager.GetShelters().Remove(id);
    }
*/
    //El admin con estos dos metodos iniciales tendrá la capacidad de agregar y quitar refugios de listaaux

    
    /*
        
        *MAS METODOS PARA EL ADMIN PROXIMAMENTE*

    */
    }
}