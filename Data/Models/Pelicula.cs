using Pelicula.Data.Models.Base;

namespace Pelicula.Data.Models;
public class Pelicula: Model
{
    public string Titulo {get; set;}

    public string? DirectorId {get; set;}

    public string? GeneroId {get; set;}

    public int Puntuación {get; set;}

    public int Raiting {get; set;}
    
    public int Año_Publicacion {get; set;}
}