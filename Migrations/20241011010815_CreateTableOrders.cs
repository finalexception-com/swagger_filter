using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Product_manager.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_day = table.Column<DateOnly>(type: "date", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    client_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_direction = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "order_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_products_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_products_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "description", "name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Owen" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "description", "name" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sharon" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "description", "name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Neil" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Jill" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "description", "name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Iris" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "description", "name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Josh" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "description", "name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Alberta" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "description", "name" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Dixie" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "description", "name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "Leigh" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "description", "name" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Randy" });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "direction", "full_name", "phone_number" },
                values: new object[,]
                {
                    { 1, "673 Kuhic Creek, Rauberg, Saint Barthelemy", "Leland Emard", "962-290-6883 x998" },
                    { 2, "298 Lindsay Corners, Mackenziehaven, Germany", "Candice Nienow", "763.906.8476 x77079" },
                    { 3, "83443 Floy Turnpike, Morarville, Czech Republic", "Daniel Thiel", "(814) 251-2295" },
                    { 4, "51188 Ahmed Isle, East Maviston, Jersey", "Santos Kshlerin", "405.246.5452 x7937" },
                    { 5, "4777 Heaney Turnpike, Feilborough, Aruba", "Courtney Klocko", "1-548-201-2532 x5361" },
                    { 6, "920 Olson Views, Port Joellefurt, Botswana", "Clara Hilll", "418-618-1993 x1904" },
                    { 7, "833 Kemmer Hollow, West Minervaberg, Bosnia and Herzegovina", "Joshua Breitenberg", "(508) 663-8490" },
                    { 8, "7792 Shemar Rest, Lake Skylarbury, Kiribati", "Ellen Hayes", "(415) 438-7275 x6772" },
                    { 9, "295 Labadie Run, West Percyshire, Brunei Darussalam", "Ricardo Huels", "904.832.5993" },
                    { 10, "901 Jabari Centers, Jaspershire, Gambia", "Richard Romaguera", "331.233.5385 x5390" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "category_id", "name", "price", "stock" },
                values: new object[] { 3, "Handmade Frozen Chicken", 964.64999999999998, 23 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Wooden Table", 870.88, 84 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Plastic Bike", 390.51999999999998, 73 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name", "price", "stock" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Rubber Table", 237.75999999999999, 61 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "category_id", "name", "price", "stock" },
                values: new object[] { 3, "Tasty Rubber Ball", 788.87, 24 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Steel Keyboard", 978.10000000000002, 34 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Rubber Sausages", 377.18000000000001, 38 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Concrete Pants", 340.61000000000001, 36 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "The Football Is Good For Training And Recreational Purposes", "Small Soft Chair", 60.829999999999998, 34 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Rubber Chicken", 996.52999999999997, 100 });

            migrationBuilder.CreateIndex(
                name: "IX_order_products_OrderId",
                table: "order_products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_products_ProductId",
                table: "order_products",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_products");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "description", "name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rogelio" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "description", "name" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Jesse" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "description", "name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gertrude" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Alfredo" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "description", "name" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Mercedes" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "description", "name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cecilia" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "description", "name" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "Sidney" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "description", "name" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Luz" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "description", "name" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Enrique" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "description", "name" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Jeffrey" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "category_id", "name", "price", "stock" },
                values: new object[] { 4, "Licensed Fresh Tuna", 8.3800000000000008, 62 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Wooden Gloves", 247.34, 98 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Licensed Plastic Shoes", 379.93000000000001, 88 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name", "price", "stock" },
                values: new object[] { "The Football Is Good For Training And Recreational Purposes", "Unbranded Frozen Keyboard", 435.95999999999998, 83 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "category_id", "name", "price", "stock" },
                values: new object[] { 5, "Sleek Wooden Chicken", 349.61000000000001, 6 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Fresh Ball", 326.38, 5 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Rubber Mouse", 924.14999999999998, 84 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Concrete Sausages", 607.79999999999995, 23 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Soft Chips", 994.74000000000001, 89 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "category_id", "description", "name", "price", "stock" },
                values: new object[] { 2, "The Football Is Good For Training And Recreational Purposes", "Refined Frozen Bacon", 850.30999999999995, 79 });
        }
    }
}
