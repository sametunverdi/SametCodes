using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ServicesAndTechStack_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconSvg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLargeCard = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechStacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechStacks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DescriptionEn", "DescriptionTr", "IconSvg", "ImageUrl", "IsActive", "IsLargeCard", "OrderIndex", "TitleEn", "TitleTr" },
                values: new object[,]
                {
                    { 1, "Custom coded premium interfaces.", "Markanızın ruhunu yansıtan, hazır şablonlardan uzak, tamamen size özel kodlanmış premium arayüzler ve kusursuz kullanıcı deneyimi.", "<svg class=\"w-8 h-8\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M12 2L2 7l10 5 10-5-10-5zM2 17l10 5 10-5M2 12l10 5 10-5\"/></svg>", "https://images.unsplash.com/photo-1498050108023-c5249f4df085?auto=format&fit=crop&w=1200&q=80", true, true, 0, "Custom Web Design", "Özel Web Tasarım" },
                    { 2, "Optimized fast architectures.", "Saniyeler içinde açılan optimize edilmiş yapılar.", "<svg class=\"w-6 h-6\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M13 10V3L4 14h7v7l9-11h-7z\"/></svg>", "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?auto=format&fit=crop&w=800&q=80", true, false, 1, "Speed & Performance", "Hız ve Performans" },
                    { 3, "Leave competitors behind in search engines.", "Arama motorlarında rakiplerinizi geride bırakın.", "<svg class=\"w-6 h-6\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z\"/></svg>", "https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=800&q=80", true, false, 2, "SEO Optimization", "SEO Optimizasyonu" }
                });

            migrationBuilder.InsertData(
                table: "TechStacks",
                columns: new[] { "Id", "IsActive", "Name", "OrderIndex" },
                values: new object[,]
                {
                    { 1, true, "C# ASP.NET Core", 0 },
                    { 2, true, "Tailwind CSS", 1 },
                    { 3, true, "GSAP Animation", 2 },
                    { 4, true, "SQL Server", 3 },
                    { 5, true, "JavaScript", 4 },
                    { 6, true, "MVC Architecture", 5 },
                    { 7, true, "RESTful APIs", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "TechStacks");
        }
    }
}
