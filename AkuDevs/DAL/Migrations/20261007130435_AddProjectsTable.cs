using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ShowOnHome = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CategoryEn", "CategoryTr", "DescriptionEn", "DescriptionTr", "ImageUrl", "IsActive", "OrderIndex", "ProjectUrl", "ShowOnHome", "TitleEn", "TitleTr" },
                values: new object[,]
                {
                    { 1, "Corporate Web", "Kurumsal Web", "Modern corporate web interface.", "Uluslararası standartlarda, modern ve keskin hatlara sahip kurumsal üretim tesisi web arayüzü.", "https://images.unsplash.com/photo-1486406146926-c627a92ad1ab?auto=format&fit=crop&w=800&q=80", true, 0, "#", true, "Pamir Plastic", "Pamir Plastik" },
                    { 2, "Corporate Web", "Kurumsal Web", "Coming soon.", "Bu alanda yakında yeni bir kurumsal çalışma sergilenecek.", "https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&w=800&q=80", true, 1, "#", true, "New Project", "Yeni Proje" },
                    { 3, "Custom Software", "Özel Yazılım", "Coming soon.", "Bu alanda yakında yeni bir özel yazılım çalışması sergilenecek.", "https://images.unsplash.com/photo-1519389950473-47ba0277781c?auto=format&fit=crop&w=800&q=80", true, 2, "#", true, "Custom Software", "Özel Yazılım" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
