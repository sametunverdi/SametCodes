using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorHex",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "DescriptionTr",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "IconText",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "TechStacks");

            migrationBuilder.RenameColumn(
                name: "TitleTr",
                table: "TechStacks",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "IsActive", "OrderIndex", "TitleEn", "TitleTr" },
                values: new object[,]
                {
                    { 1, "#4f46e5", "", "Güvenli, hızlı ve bakımı kolay MVC mimarisi ile sunucu tarafı geliştirme.", "C#", true, 0, "ASP.NET Core", "ASP.NET Core" },
                    { 2, "#0ea5e9", "", "Mobil öncelikli, tutarlı ve küçük boyutlu modern arayüzler.", "CSS", true, 1, "Tailwind CSS", "Tailwind CSS" },
                    { 3, "#fbbf24", "", "Sayfayı canlandıran, performansı bozmayan akıcı animasyonlar.", "JS", true, 2, "JavaScript & GSAP", "JavaScript & GSAP" },
                    { 4, "#2563eb", "", "Düzenli veri modeli ve hızlı sorgularla sağlam altyapı.", "SQL", true, 3, "SQL Server", "SQL Server" },
                    { 5, "#10b981", "", "Anlamlı HTML, meta yapısı ve hız ile arama motorlarında görünürlük.", "SEO", true, 4, "Technical SEO", "Teknik SEO" },
                    { 6, "#f97316", "", "Telefondan masaüstüne her ekranda kusursuz deneyim.", "UX", true, 5, "Mobile UX", "Mobil Uyumluluk" }
                });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "C# ASP.NET Core");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TechStacks",
                newName: "TitleTr");

            migrationBuilder.AddColumn<string>(
                name: "ColorHex",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionTr",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconText",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn", "TitleTr" },
                values: new object[] { "#4f46e5", "", "Güvenli, hızlı...", "C#", "ASP.NET Core", "ASP.NET Core" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#0ea5e9", "", "Mobil öncelikli...", "CSS", "Tailwind CSS" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#fbbf24", "", "Akıcı animasyonlar...", "GSAP", "GSAP Animation" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#2563eb", "", "Hızlı sorgular...", "SQL", "SQL Server" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#fbbf24", "", "Web sayfaları...", "JS", "JavaScript" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#8b5cf6", "", "Temiz kod...", "MVC", "MVC Architecture" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColorHex", "DescriptionEn", "DescriptionTr", "IconText", "TitleEn" },
                values: new object[] { "#10b981", "", "Hızlı API'lar...", "API", "RESTful APIs" });
        }
    }
}
