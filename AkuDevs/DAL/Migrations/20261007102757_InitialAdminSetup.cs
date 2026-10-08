using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialAdminSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadgeTr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BadgeEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleWhiteTr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TitleWhiteEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TitleRedTr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TitleRedEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescriptionTr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconSvg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroSections");

            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
