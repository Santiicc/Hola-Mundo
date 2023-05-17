using Xunit;
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
    //test de Usuario
    public void BuscarRefugios_DisplayAvailableRefugios()
    {
        
        var usuario = new Usuario();
        var shelterxaux4 = new Refugiosaux(); 

        var refugio1 = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
        var calificacion1 = new Calificacion(); 
        calificacion1.AddRating(4); 
        refugio1.calificaciones.Add(calificacion1);
        shelterxaux4.listaderefugios.Add(refugio1);

        var refugio2 = new Refugio("Refugio2", "Ubicacion2", "Descripción2");
        var calificacion2 = new Calificacion(); 
        calificacion2.AddRating(3);
        refugio2.calificaciones.Add(calificacion2);
        shelterxaux4.listaderefugios.Add(refugio2);

        var expectedOutput = $"Los refugios disponibles en la plataforma son: {Refugio1} con una valoracion de {Refugio2} con una valoracion de 3";

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            usuario.buscarrefugios(shelterxaux4);
            string consoleOutput = sw.ToString().Trim();

            
            Assert.Equal(expectedOutput, consoleOutput);
        }
    }

}
