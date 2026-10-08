using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TechStackNames2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TechStacks",
                newName: "NameTr");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
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
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "DescriptionTr",
                value: "GÃ¼venli, hÄ±zlÄ± ve bakÄ±mÄ± kolay MVC mimarisi ile sunucu tarafÄ± geliÅŸtirme.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionTr",
                value: "Mobil Ã¶ncelikli, tutarlÄ± ve kÃ¼Ã§Ã¼k boyutlu modern arayÃ¼zler.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "DescriptionTr",
                value: "SayfayÄ± canlandÄ±ran, performansÄ± bozmayan akÄ±cÄ± animasyonlar.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "DescriptionTr",
                value: "DÃ¼zenli veri modeli ve hÄ±zlÄ± sorgularla saÄŸlam altyapÄ±.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "DescriptionTr",
                value: "AnlamlÄ± HTML, meta yapÄ±sÄ± ve hÄ±z ile arama motorlarÄ±nda gÃ¶rÃ¼nÃ¼rlÃ¼k.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "DescriptionTr",
                value: "Telefondan masaÃ¼stÃ¼ne her ekranda kusursuz deneyim.");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "NameEn",
                value: "C# ASP.NET Core");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "NameEn",
                value: "Tailwind CSS");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "GSAP Animation", "GSAP Animasyon" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "SQL Server Database", "SQL Server Veritabanı" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameEn",
                value: "JavaScript");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "MVC Architecture", "MVC Mimarisi" });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "RESTful APIs", "RESTful API'ler" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "TechStacks");

            migrationBuilder.RenameColumn(
                name: "NameTr",
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
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "DescriptionTr",
                value: "Güvenli, hızlı ve bakımı kolay MVC mimarisi ile sunucu tarafı geliştirme.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionTr",
                value: "Mobil öncelikli, tutarlı ve küçük boyutlu modern arayüzler.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "DescriptionTr",
                value: "Sayfayı canlandıran, performansı bozmayan akıcı animasyonlar.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "DescriptionTr",
                value: "Düzenli veri modeli ve hızlı sorgularla sağlam altyapı.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "DescriptionTr",
                value: "Anlamlı HTML, meta yapısı ve hız ile arama motorlarında görünürlük.");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "DescriptionTr",
                value: "Telefondan masaüstüne her ekranda kusursuz deneyim.");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "GSAP Animation");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "SQL Server");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "MVC Architecture");

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "RESTful APIs");
        }
    }
}
