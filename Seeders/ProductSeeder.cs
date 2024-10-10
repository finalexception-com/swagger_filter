
// using Bogus;
// using Microsoft.EntityFrameworkCore;
// using Product_manager.models;

// namespace Product_manager.Seeders;
// public class ProductSeeder
// {
//     public static void Seed(ModelBuilder modelBuilder)
//     {
//         var categories = GenerateCategories(); // O cargar desde la base de datos
//         if (!categories.Any())
//         {
//             throw new Exception("La lista de categorías está vacía.");
//         }

//         var products = GenerateProducts(10, categories); // Generar productos con categorías válidas
//         modelBuilder.Entity<Product>().HasData(products);
//     }

//     public static IEnumerable<Product> GenerateProducts(int count, List<Category> categories)
//     {
//         var faker = new Faker<Product>()
//             .RuleFor(a => a.Id, f => f.IndexFaker + 1)
//             .RuleFor(a => a.Name, f => f.Commerce.ProductName())
//             .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
//             .RuleFor(a => a.Price, f => double.Parse(f.Commerce.Price()))
//             .RuleFor(a => a.Stock, f => f.Random.Int(0, 100))
//             .RuleFor(a => a.CategoryId, f => f.PickRandom(categories).Id); // Verificar que hay categorías
//         return faker.Generate(count);
//     }

//     public static List<Category> GenerateCategories()
//     {
//         var faker = new Faker<Category>()
//             .RuleFor(c => c.Id, f => f.IndexFaker + 1)
//             .RuleFor(c => c.Name, f => f.Commerce.Categories(1).First());
//         return faker.Generate(5); // Genera 5 categorías de ejemplo
//     }
// }