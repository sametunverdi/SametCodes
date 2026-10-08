using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FinalEncodingFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HeroSections",
                columns: new[] { "Id", "BadgeEn", "BadgeTr", "DescriptionEn", "DescriptionTr", "TitleRedEn", "TitleRedTr", "TitleWhiteEn", "TitleWhiteTr" },
                values: new object[] { 1, "Full Stack Developer", "Full Stack Geliştirici", "I develop modern, fast, and SEO-friendly web applications that make your brand stand out in the digital world.", "Markanızı dijital dünyada öne çıkaran, modern, hızlı ve SEO uyumlu web uygulamaları geliştiriyorum.", "Give Direction", "Yön Ver", "To the Digital World", "Dijital Dünyaya" });

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
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Secure, fast, and maintainable server-side development with MVC architecture.", "Güvenli, hızlı ve bakımı kolay MVC mimarisi ile sunucu tarafı geliştirme." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Mobile-first, consistent, and compact modern interfaces.", "Mobil öncelikli, tutarlı ve küçük boyutlu modern arayüzler." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Fluid animations that bring the page to life without compromising performance.", "Sayfayı canlandıran, performansı bozmayan akıcı animasyonlar." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Solid infrastructure with structured data models and fast queries.", "Düzenli veri modeli ve hızlı sorgularla sağlam altyapı." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Visibility in search engines with semantic HTML, meta structure, and speed.", "Anlamlı HTML, meta yapısı ve hız ile arama motorlarında görünürlük." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "Flawless experience across all screens from mobile to desktop.", "Telefondan masaüstüne her ekranda kusursuz deneyim." });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "IconSvg", "IsActive", "OrderIndex", "PlatformName", "Url" },
                values: new object[,]
                {
                    { 1, "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M12 2C6.477 2 2 6.484 2 12.017c0 4.425 2.865 8.18 6.839 9.504.5.092.682-.217.682-.483 0-.237-.008-.868-.013-1.703-2.782.605-3.369-1.343-3.369-1.343-.454-1.158-1.11-1.466-1.11-1.466-.908-.62.069-.608.069-.608 1.003.07 1.531 1.032 1.531 1.032.892 1.53 2.341 1.088 2.91.832.092-.647.35-1.088.636-1.338-2.22-.253-4.555-1.113-4.555-4.951 0-1.093.39-1.988 1.029-2.688-.103-.253-.446-1.272.098-2.65 0 0 .84-.27 2.75 1.026A9.564 9.564 0 0112 6.844c.85.004 1.705.115 2.504.337 1.909-1.296 2.747-1.027 2.747-1.027.546 1.379.202 2.398.1 2.651.64.7 1.028 1.595 1.028 2.688 0 3.848-2.339 4.695-4.566 4.943.359.309.678.92.678 1.855 0 1.338-.012 2.419-.012 2.747 0 .268.18.58.688.482A10.019 10.019 0 0022 12.017C22 6.484 17.522 2 12 2z\"></path></svg>", true, 0, "GitHub", "https://github.com" },
                    { 2, "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M19 0h-14c-2.761 0-5 2.239-5 5v14c0 2.761 2.239 5 5 5h14c2.762 0 5-2.239 5-5v-14c0-2.761-2.238-5-5-5zm-11 19h-3v-11h3v11zm-1.5-12.268c-.966 0-1.75-.79-1.75-1.764s.784-1.764 1.75-1.764 1.75.79 1.75 1.764-.783 1.764-1.75 1.764zm13.5 12.268h-3v-5.604c0-3.368-4-3.113-4 0v5.604h-3v-11h3v1.765c1.396-2.586 7-2.777 7 2.476v6.759z\"></path></svg>", true, 1, "LinkedIn", "https://linkedin.com" },
                    { 3, "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path d=\"M23.953 4.57a10 10 0 01-2.825.775 4.958 4.958 0 002.163-2.723c-.951.555-2.005.959-3.127 1.184a4.92 4.92 0 00-8.384 4.482C7.69 8.095 4.067 6.13 1.64 3.162a4.822 4.822 0 00-.666 2.475c0 1.71.87 3.213 2.188 4.096a4.904 4.904 0 01-2.228-.616v.06a4.923 4.923 0 003.946 4.827 4.996 4.996 0 01-2.212.085 4.936 4.936 0 004.604 3.417 9.867 9.867 0 01-6.102 2.105c-.39 0-.779-.023-1.17-.067a13.995 13.995 0 007.557 2.209c9.053 0 13.998-7.496 13.998-13.985 0-.21 0-.42-.015-.63A9.935 9.935 0 0024 4.59z\"></path></svg>", true, 2, "Twitter", "https://twitter.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3);

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
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "GÃ¼venli, hÄ±zlÄ± ve bakÄ±mÄ± kolay MVC mimarisi ile sunucu tarafÄ± geliÅŸtirme." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "Mobil Ã¶ncelikli, tutarlÄ± ve kÃ¼Ã§Ã¼k boyutlu modern arayÃ¼zler." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "SayfayÄ± canlandÄ±ran, performansÄ± bozmayan akÄ±cÄ± animasyonlar." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "DÃ¼zenli veri modeli ve hÄ±zlÄ± sorgularla saÄŸlam altyapÄ±." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "AnlamlÄ± HTML, meta yapÄ±sÄ± ve hÄ±z ile arama motorlarÄ±nda gÃ¶rÃ¼nÃ¼rlÃ¼k." });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionEn", "DescriptionTr" },
                values: new object[] { "", "Telefondan masaÃ¼stÃ¼ne her ekranda kusursuz deneyim." });
        }
    }
}
