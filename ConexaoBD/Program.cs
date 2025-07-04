// biblioteca usada dotnet add package Microsoft.EntityFrameworkCore
// biblioteca usada p/ SQL dotnet add package Microsoft.EntityFrameworkCore.SqlServer

using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;

var connBuilder = new SqlConnectionStringBuilder
{
    DataSource = "localhost",
    InitialCatalog = "ConexaoAulaHJ",
    IntegratedSecurity = true,
    TrustServerCertificate = true
};
var stringConnection = connBuilder.ToString();

var optsBuilder = new DbContextOptionsBuilder();
optsBuilder.UseSqlServer(stringConnection);
var options = optsBuilder.Options;

var db = new ExempleDbContext(options);
await db.Database.EnsureDeletedAsync();
await db.Database.EnsureCreatedAsync();

var user = new Usuario
{
    Nome = "Anna Guerra",
    NascData = DateTime.Now,
    Salario = 1m
};
db.Add(user);
await db.SaveChangesAsync();

var query =
    db.Usuarios
    .Where(u => u.NascData.Year == 2025)
    .Where(u => u.Salario > 1)
    .Select(u => u.Nome);
var names = await query.ToListAsync();
foreach (var name in names)
    Console.WriteLine(name);

var compra = new Compra
{
    Produto = "Figurinha",
    Valor = 1m,
    UsuarioID = user.ID
};
db.Add(compra);
await db.SaveChangesAsync();

var variavel = await db.Usuarios
    .Include(u => u.Compras)
    .FirstOrDefaultAsync(u => u.Nome == "Anna Guerra");
db.Remove(variavel);
await db.SaveChangesAsync();

foreach (var comprinha in variavel.Compras)
    Console.WriteLine(comprinha);

// var query2 =
//     from u in db.Usuarios
//     join c in db.Compras
//     on u.ID equals c.UsuarioID
//     select new { Usuario = u.Nome, c.Produto };

// var data = await query2.ToListAsync();
// foreach (var item in data)
//     Console.WriteLine($"{item.Usuario} comprou {item.Produto}");

// PODE SER FEITO DESSE JEITO
//var query2 =
//     from u in db.Usuarios
//     where u.NascData.Year == 2025
//     where u.Salario > 1
//     select u.Nome;

public class ExempleDbContext(DbContextOptions opts) : DbContext(opts)
{
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public DbSet<Compra> Compras => Set<Compra>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Usuario>();

        model.Entity<Compra>()
            .HasOne(c => c.Usuario)
            .WithMany(u => u.Compras)
            .HasForeignKey(c => c.UsuarioID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public class Usuario
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public DateTime NascData { get; set; }
    public ICollection<Compra> Compras { get; set; }
}

public class Compra
{
    public int ID { get; set; }
    public string Produto { get; set; }
    public decimal Valor { get; set; }
    public int UsuarioID { get; set; }
    public Usuario Usuario { get; set; }
}