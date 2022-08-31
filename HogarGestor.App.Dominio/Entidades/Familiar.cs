namespace HogarGestor.App.Dominio
{
    public class Familiar:Persona
    {
         public int Id { get; set; }
         public string Parentesco { get; set; }
         public string Telefono { get; set; }
         public string Correo { get; set; }
    }
}