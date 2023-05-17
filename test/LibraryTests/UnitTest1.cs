using Xunit;
using System.Collections.Generic;

namespace Proyecto6.Tests
{
    public class RefugioTests
    {
        [Test]
        public void AgregarCategoria_AddsCategoriaToRefugio()
        {
            
            var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
            var categoria = new Categoria(); 

            
            refugio.agregarcategoria(refugio, categoria);

            Assert.Contains(categoria, refugio.categories);
        }
        [Test]
        public void AgregarRefugioBasedatos_AddsRefugioToList()
        {
            
            var admin = new Admin("Admin1");
            var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");
            var refugiosaux = new Refugiosaux();

           
            admin.agregarrefugiobasedatos(refugio, refugiosaux);

          
            Assert.Contains(refugio, refugiosaux.listaderefugios);
        }
        
        

    }
}