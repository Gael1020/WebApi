using WebApi.Models.Base;

namespace WebApi.Models;

public class Cliente: Model
{
    public string? Name {get; set;}

    public string? LastName {get; set;}

    public string? Direccion {get; set;}

    public string? Telefono {get; set;}
    
    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;
}