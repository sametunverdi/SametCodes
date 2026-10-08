using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TechStackRichFields3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DescriptionTr",
                value: "UluslararasÄ± standartlarda, modern ve keskin hatlara sahip kurumsal Ã¼retim tesisi web arayÃ¼zÃ¼.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionTr",
                value: "Bu alanda yakÄ±nda yeni bir kurumsal Ã§alÄ±ÅŸma sergilenecek.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryTr", "DescriptionTr", "TitleTr" },
                values: new object[] { "Ã–zel YazÄ±lÄ±m", "Bu alanda yakÄ±nda yeni bir Ã¶zel yazÄ±lÄ±m Ã§alÄ±ÅŸmasÄ± sergilenecek.", "Ã–zel YazÄ±lÄ±m" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "MarkanÄ±zÄ±n ruhunu yansÄ±tan, hazÄ±r ÅŸablonlardan uzak, tamamen size Ã¶zel kodlanmÄ±ÅŸ premium arayÃ¼zler ve kusursuz kullanÄ±cÄ± deneyimi.", "Ã–zel Web TasarÄ±m" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Saniyeler iÃ§inde aÃ§Ä±lan optimize edilmiÅŸ yapÄ±lar.", "HÄ±z ve Performans" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "DescriptionTr",
                value: "Arama motorlarÄ±nda rakiplerinizi geride bÄ±rakÄ±n.");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DescriptionTr",
                value: "Uluslararası standartlarda, modern ve keskin hatlara sahip kurumsal üretim tesisi web arayüzü.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionTr",
                value: "Bu alanda yakında yeni bir kurumsal çalışma sergilenecek.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryTr", "DescriptionTr", "TitleTr" },
                values: new object[] { "Özel Yazılım", "Bu alanda yakında yeni bir özel yazılım çalışması sergilenecek.", "Özel Yazılım" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Markanızın ruhunu yansıtan, hazır şablonlardan uzak, tamamen size özel kodlanmış premium arayüzler ve kusursuz kullanıcı deneyimi.", "Özel Web Tasarım" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Saniyeler içinde açılan optimize edilmiş yapılar.", "Hız ve Performans" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "DescriptionTr",
                value: "Arama motorlarında rakiplerinizi geride bırakın.");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "C# ASP.NET Core");
        }
    }
}
