 [Fact]
        public void CrearRefugio_SetsOwnerAndContactNumber()
        {
            // Arrange
            var dueño = new Dueño("Dueño1", 1234567890);
            var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");

            // Act
            dueño.crearrefugio(refugio);

            // Assert
            Assert.Equal("Dueño1", refugio.owner);
            Assert.Equal(1234567890, refugio.contactnumber);
        }

        [Fact]
        public void CambiarDescripcion_SetsNewDescription()
        {
            // Arrange
            var dueño = new Dueño("Dueño1", 1234567890);
            var refugio = new Refugio("Refugio1", "Ubicacion1", "Descripción1");

            // Act
            dueño.Cambiardescripcion(refugio, "Nueva descripción");

            // Assert
            Assert.Equal("Nueva descripción", refugio.description);
        }
    //Este metodo calcula el promedio de un objeto Refugio estableciendo una variable sum y otra counter
    //las cuales va a dividir posteriormente para obtener el promedio de la lista de calificaciones del refugio

}