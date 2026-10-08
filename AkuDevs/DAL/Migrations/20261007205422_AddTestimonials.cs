using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTestimonials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AvatarUrl", "CreatedAt", "FullName", "IsApproved", "Message", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "https://i.pravatar.cc/150?img=11", new DateTime(2026, 9, 27, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1566), "Ahmet Yılmaz", true, "Web sitemiz için aldığımız hizmetten inanılmaz memnun kaldık. Samet Bey projeyi tam zamanında ve sıfır hatayla teslim etti.", 5, "Pamir Plastik, CEO" },
                    { 2, "https://i.pravatar.cc/150?img=32", new DateTime(2026, 10, 2, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1580), "Merve Kaya", true, "Admin paneli o kadar akıcı ki, işlerimizi %50 hızlandırdı. Gerçekten estetik ve hız bir arada sunulmuş.", 5, "Nova Finans, CTO" },
                    { 3, "https://i.pravatar.cc/150?img=15", new DateTime(2026, 10, 5, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1583), "Caner Çelik", true, "Vizyonu çok geniş, sadece kod yazmıyor; projenin büyümesi ve modern durması için harika tasarım fikirleri veriyor.", 4, "Girişimci" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
