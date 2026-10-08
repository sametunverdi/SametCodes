using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkProcesses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepNumber = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TitleTr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescriptionTr = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AnimationDelay = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkProcesses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WorkProcesses",
                columns: new[] { "Id", "AnimationDelay", "DescriptionEn", "DescriptionTr", "IsActive", "OrderIndex", "StepNumber", "TitleEn", "TitleTr" },
                values: new object[,]
                {
                    { 1, 0.0, "We analyze your needs, target audience, and competitors together.", "İhtiyaçlarınızı, hedef kitlenizi ve rakiplerinizi birlikte analiz ederiz.", true, 0, "01", "Discovery & Planning", "Keşif & Planlama" },
                    { 2, 0.10000000000000001, "I design a corporate and memorable interface specifically for your brand.", "Markanıza özel, kurumsal ve akılda kalıcı arayüzü tasarlarım.", true, 1, "02", "Design", "Tasarım" },
                    { 3, 0.20000000000000001, "I code fast, secure, and SEO-friendly, and perform mobile testing.", "Hızlı, güvenli ve SEO uyumlu şekilde kodlar, mobil testlerini yaparım.", true, 2, "03", "Development", "Geliştirme" },
                    { 4, 0.29999999999999999, "I launch the project and stand by you for support and improvements afterwards.", "Yayına alır, sonrasında destek ve geliştirmeler için yanınızda olurum.", true, 3, "04", "Launch & Support", "Yayın & Destek" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkProcesses");
        }
    }
}
