namespace CalificacionBeca
{
    public class Calificacion
    {
        public Calificacion(int notaMinimaBeca)
        {
            ParaBeca = notaMinimaBeca;
        }
        public int ParaBeca { get; set; }
        public bool ObtuvoBeca { get; set; }


        public void ObtenerBeca(IEstudiante estudiante)
        {
            ObtuvoBeca = estudiante.Calificacion >= ParaBeca;
        }
    }
}