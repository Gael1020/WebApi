using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{

    public int? ClienteId {get; set;}

    public DateTime LoanDate {get; set;}

    public DateTime ReturnDate {get; set;}

    public string? Devolucion {get; set;}

    public int? BookId {get; set;}

    public virtual Cliente? Cliente {get; set;} = default!;

    public virtual IList<Book>? Books { get; set; } = default!;
}