

using Bogus;
using Microsoft.EntityFrameworkCore;
using Product_manager.models;

namespace Product_manager.Seeders;
public class ClientSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var categories = GenerateClients(10);
        modelBuilder.Entity<Client>().HasData(categories);
    }

    public static IEnumerable<Client> GenerateClients(int count)
    {
        var faker = new Faker<Client>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1) // ID incremental
            .RuleFor(a => a.FullName, f => f.Person.FullName) // Nombre completo
            .RuleFor(a => a.Direction, f => f.Address.FullAddress()) // Dirección completa
            .RuleFor(a => a.PhoneNumber, f => f.Phone.PhoneNumber()); // Número de teléfono
        return faker.Generate(count); // Genera 'count' clientes
    }

}
