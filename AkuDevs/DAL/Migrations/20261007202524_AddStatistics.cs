using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TitleTr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BadgeTr", "DescriptionTr", "TitleRedTr", "TitleWhiteTr" },
                values: new object[] { "Full Stack GeliÅŸtirici", "MarkanÄ±zÄ± dijital dÃ¼nyada Ã¶ne Ã§Ä±karan, modern, hÄ±zlÄ± ve SEO uyumlu web uygulamalarÄ± geliÅŸtiriyorum.", "YÃ¶n Ver", "Dijital DÃ¼nyaya" });

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

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "IsActive", "OrderIndex", "TitleEn", "TitleTr", "Value" },
                values: new object[,]
                {
                    { 1, true, 0, "Successful<br>Projects", "Başarılı<br>Proje", "45+" },
                    { 2, true, 1, "Client<br>Satisfaction", "Müşteri<br>Memnuniyeti", "%100" },
                    { 3, true, 2, "Years of<br>Experience", "Yıllık<br>Deneyim", "5+" },
                    { 4, true, 3, "Continuous<br>Support", "Sürekli<br>Destek", "7/24" }
                });

            migrationBuilder.UpdateData(
                table: "TechStacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "NameTr",
                value: "SQL Server VeritabanÄ±");

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Ä°htiyaÃ§larÄ±nÄ±zÄ±, hedef kitlenizi ve rakiplerinizi birlikte analiz ederiz.", "KeÅŸif & Planlama" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "MarkanÄ±za Ã¶zel, kurumsal ve akÄ±lda kalÄ±cÄ± arayÃ¼zÃ¼ tasarlarÄ±m.", "TasarÄ±m" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "HÄ±zlÄ±, gÃ¼venli ve SEO uyumlu ÅŸekilde kodlar, mobil testlerini yaparÄ±m.", "GeliÅŸtirme" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "YayÄ±na alÄ±r, sonrasÄ±nda destek ve geliÅŸtirmeler iÃ§in yanÄ±nÄ±zda olurum.", "YayÄ±n & Destek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.UpdateData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BadgeTr", "DescriptionTr", "TitleRedTr", "TitleWhiteTr" },
                values: new object[] { "Full Stack Geliştirici", "Markanızı dijital dünyada öne çıkaran, modern, hızlı ve SEO uyumlu web uygulamaları geliştiriyorum.", "Yön Ver", "Dijital Dünyaya" });

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
                keyValue: 4,
                column: "NameTr",
                value: "SQL Server Veritabanı");

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "İhtiyaçlarınızı, hedef kitlenizi ve rakiplerinizi birlikte analiz ederiz.", "Keşif & Planlama" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Markanıza özel, kurumsal ve akılda kalıcı arayüzü tasarlarım.", "Tasarım" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Hızlı, güvenli ve SEO uyumlu şekilde kodlar, mobil testlerini yaparım.", "Geliştirme" });

            migrationBuilder.UpdateData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionTr", "TitleTr" },
                values: new object[] { "Yayına alır, sonrasında destek ve geliştirmeler için yanınızda olurum.", "Yayın & Destek" });
        }
    }
}
