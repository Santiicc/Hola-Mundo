using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using TestDateFormat;
namespace Library.Tests;

public class RefugioTests
{
    [Test]
    //test de Refugio
    public void AgregarCategoria_AddsCategoriaToRefugio()
    {
        
        var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var categoria = new Categoria(); 

        
        refugio.agregarcategoria(refugio, categoria);

        Assert.Contains(categoria, refugio.categories);
    }
    [Test]
    //test de Admin
    public void AgregarRefugioBasedatos_AddsRefugioToList()
    {
        
        var admin = new Admin("Admin1");
        var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var refugiosaux = new Refugiosaux();

        
        admin.agregarrefugiobasedatos(refugio, refugiosaux);

        
        Assert.Contains(refugio, refugiosaux.listaderefugios);
    }

    [Test]
    public void QuitarRefugioBasedatos_RemovesRefugioFromList()
    {
        
        var admin = new Admin("Admin1");
        var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var refugiosaux = new Refugiosaux();
        refugiosaux.listaderefugios.Add(refugio);

        
        admin.quitarrefugiobasedatos(refugio, refugiosaux);

        Assert.DoesNotContain(refugio, refugiosaux.listaderefugios);
    }
    //test de Usuario
   [Test]
    public void Calificate_AddsCalificationToRefugio()
    {
        var usuario = new Usuario();
        var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var calificacion = new Calificacion(4.5);

        usuario.Calificate(refugio, calificacion);

        Assert.Contains(calificacion, refugio.calificaciones);
    }

    [Test]
    public void BuscarRefugios_DisplayAvailableRefugios()
    {
        
        var usuario = new Usuario();
        var shelterxaux = new Refugiosaux();

        var refugio1 = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var calificacion1 = new Calificacion(4.2);
        refugio1.calificaciones.Add(calificacion1);
        shelterxaux.listaderefugios.Add(refugio1);

        var refugio2 = new Refugio("Refugio2", "Ubicacion2", "Descripción2");
        var calificacion2 = new Calificacion(3.8);
        refugio2.calificaciones.Add(calificacion2);
        shelterxaux.listaderefugios.Add(refugio2);
       
        using (var consoleOutput = new ConsoleOutput())
        {
            usuario.buscarrefugios(shelterxaux);

            Assert.AreEqual(expectedOutput, consoleOutput.GetOutput());
        }
    }

}
