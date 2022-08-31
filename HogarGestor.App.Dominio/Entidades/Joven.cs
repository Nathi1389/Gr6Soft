namespace HogarGestor.App.Dominio

{

    public class Joven:Persona
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Familiar familiar { get; set; }
        public Medico Nutricionista { get; set; }
        public Medico Pediatra { get; set; }
        public Historia historia { get; set; }
        public  System.Collections.Generic.List<PatronCrecimiento> PatronesCrecimientos { get; set; }
        }
}