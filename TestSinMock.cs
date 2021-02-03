using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalificacionBeca;

namespace PruebaMockingMarisol
{
    [TestClass]
    public class TestSinMock
    {
        [TestMethod]
        public void SiLaCalificacionEsMayorA950ObtieneBeca()
        {
            var estudiante = new Estudiante
            {
                Calificacion = 970
            };

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            calificacion.ObtenerBeca(estudiante);

            Assert.IsTrue(calificacion.ObtuvoBeca);
        }
        [TestMethod]
        public void SiLaCalificacionEsMenorA950NoObtieneCupo()
        {
            var estudiante = new Estudiante
            {
                Calificacion = 930
            };

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            calificacion.ObtenerBeca(estudiante);

            Assert.IsFalse(calificacion.ObtuvoBeca);
        }
        [TestMethod]
        public void SiLaCalificacionEsIgualA950ObtuvoCupo()
        {
            var estudiante = new Estudiante
            {
                Calificacion = 950
            };

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            calificacion.ObtenerBeca(estudiante);

            Assert.IsTrue(calificacion.ObtuvoBeca);
        }
    }
}

