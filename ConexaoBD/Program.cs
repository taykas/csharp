// biblioteca usada dotnet add package Microsoft.EntityFrameworkCore
// biblioteca usada p/ SQL dotnet add package Microsoft.EntityFrameworkCore.SqlServer
using Microsoft.EntityFrameworkCore;

public class ExempleDbContext(DbContextOptions opts) : Dbcontext(opts)
{

}

public class Usuario
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public DateTime NascData { get; set; }
}