using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using CalificacionBeca;

namespace PruebaMockingMarisol
{
    [TestClass]
    public class CalificacionTest
    {
        [TestMethod]
        public void SiLaCalificacionEsMayorA950ObtieneCupo()
        {
            var estudiante = MockRepository.GenerateStub<IEstudiante>();
            estudiante.Calificacion = 960;

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            
            calificacion.ObtenerBeca(estudiante);

            Assert.IsTrue(calificacion.ObtuvoBeca);
        }

        [TestMethod]
        public void SiLaCalificacionDelEstudianteEsMayorACalificacionParaBecaEntoncesObtieneBeca()
        {
            var estudiante = MockRepository.GenerateStub<IEstudiante>();
            estudiante.Calificacion = 920;

            var notaMinimaBeca = 900;
            var calificacion = new Calificacion(notaMinimaBeca);
           
            calificacion.ObtenerBeca(estudiante);

            Assert.IsTrue(calificacion.ObtuvoBeca);
            
        }
        [TestMethod]
        public void SiLaCalificacionEsMenorA950NoObtieneCupo()
        {
            var estudiante = MockRepository.GenerateStub<IEstudiante>();
            estudiante.Calificacion = 930;

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            
            calificacion.ObtenerBeca(estudiante);

            Assert.IsFalse(calificacion.ObtuvoBeca);
        }
        [TestMethod]
        public void SiLaCalificacionEsIgualA950ObtuvoCupo()
        {
            var estudiante = MockRepository.GenerateStub<IEstudiante>();
            estudiante.Calificacion = 950;

            var notaMinimaBeca = 950;
            var calificacion = new Calificacion(notaMinimaBeca);
            
            calificacion.ObtenerBeca(estudiante);

            Assert.IsTrue(calificacion.ObtuvoBeca);
        }
    }
}
