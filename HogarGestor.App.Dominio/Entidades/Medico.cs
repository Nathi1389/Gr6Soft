namespace HogarGestor.App.Dominio
{
    public class Medico:Persona
    {
        ///Identificacion del Medico
        public int Id { get; set; }
        ///Nombre Especialidad medica
        public string Especialidad { get; set; }
        ///Código único del médico
        public string Codigo { get; set; }
        /// Número Tarjeta Profesional
        public string TarjetaProfesional { get; set; }
    }

}