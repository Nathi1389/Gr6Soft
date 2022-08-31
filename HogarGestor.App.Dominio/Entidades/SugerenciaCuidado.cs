namespace HogarGestor.App.Dominio
{
    public class SugerenciaCuidado
    {
         public int Id { get; set; }
         public DateTime FechaHora { get; set; }
         ///Texto con la sugerencia
         public string Descripcion { get; set; }
         
    }
}