using Xunit;
using System;
using Cotizaciones.Utilities;
namespace Utilities.UnitTests {
    public class Utilidades_esRutValido{

         [Fact]
        public void TestRut()    
        {
            Utilidades utilidades = new Utilidades();

            bool prueba;
            prueba = utilidades.validarRut("19149491-5");
            Assert.False(prueba, "Fallo testing Rut");
            prueba = utilidades.validarRut("19149491-5");
            Assert.False(prueba, "Fallo testing Rut");
            prueba = utilidades.validarRut("19149491-8");
            Assert.False(prueba, "Fallo testing Rut");
            prueba = utilidades.validarRut("19149491-5");
            Assert.False(prueba, "Fallo testing Rut");

        }
        [Fact]
        public void TestNombre()    
        {
            Utilidades utilidades = new Utilidades();

            bool prueba;
            prueba = utilidades.validarNombre("Gasper");
            Assert.False(prueba, " 1");
            prueba = utilidades.validarNombre("asca133");
            Assert.False(prueba, "2");
            prueba = utilidades.validarNombre("FiscoGasper");
            Assert.False(prueba, "3");
            prueba = utilidades.validarNombre("GranJC");
            Assert.False(prueba, "4");

        }
    }
}