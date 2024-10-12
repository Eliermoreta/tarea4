public class Personaje
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apodo { get; set; }
    public string Raza { get; set; }
    public string FotoUrl { get; set; }
    public int Edad { get; set; }
    public string PoderCaracteristico { get; set; }
    public int MediaItemId { get; set; }
    public MediaItem MediaItem { get; set; }
}