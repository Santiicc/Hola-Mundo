using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Shelter
{
    //Clase de Tipo Refugio que tiene caracterisiticas del mismo y otras funcionalidades 
    public string owner{get;set;}

    public string ubication{get;set;}

    public int id;

    public string nameshelter{get;set;}

    public int contactnumber{get;set;}

    private List<Category>categories = new List<Category>();

    public string description{get;set;}

    public List<Qualification> calificaciones = new List<Qualification>();

    public List<Service> services = new List<Service>();


    public Shelter(string namex,string ubicationx,string descriptionx)
    {
        this.ubication=ubicationx;
        this.nameshelter=namex;
        this.description=descriptionx;
    }

     public void AddCategory(string type)
    {
        Category categoriax = new Category(type);
        this.categories.Add(categoriax);
    }

    /// <summary>
    /// addCategory se encarga de agregar una categoria nueva al refugio, y cumple con los principios ya que crea la instancia del objeto
    /// en el mismo metodo
    /// </summary>
    /// <param name="ratingx"></param>

    public void AddQualification(double ratingx)
    {
        Qualification qualificationx = new Qualification(ratingx);
        this.calificaciones.Add(qualificationx);
    }

    //El metodo agregar categoria se va encargar de obtener como paramteros dos objetos, un Refugio y una Categoria
    //Ademas la ejecucion de este metodo agrega ese objeto categoria en la lista categorias del objeto refugio.


    /*
        -MAS METODOS DE REFUGIO PROXIMAMENTE-
    */
}