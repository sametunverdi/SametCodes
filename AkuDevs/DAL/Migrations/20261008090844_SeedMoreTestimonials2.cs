using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreTestimonials2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconSvg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutFeatures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutFeatures",
                columns: new[] { "Id", "ColorClass", "Description", "IconSvg", "IsActive", "OrderIndex", "Title" },
                values: new object[,]
                {
                    { 1, "red", "Yavaş siteler müşteri kaybettirir. Geliştirdiğim her proje, Google Lighthouse skorlarında zirveye oynamak üzere milisaniyelik seviyede optimize edilir.", "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M13 10V3L4 14h7v7l9-11h-7z\"/></svg>", true, 1, "Hız & Performans" },
                    { 2, "amber", "Spagetti koda karşıyım. Mimariyi öylesine sağlam ve modüler kurarım ki, yarın başkası devralsa bile sistemi bir kitap okur gibi anlar.", "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10 20l4-16m4 4l4 4-4 4M6 16l-4-4 4-4\"/></svg>", true, 2, "Temiz Kod (Clean Code)" },
                    { 3, "blue", "Sürecin her anında nerede olduğumuzu bilirsiniz. Sürpriz maliyetler veya gizli mazeretler yoktur, sadece net tarihler ve şeffaf sonuçlar vardır.", "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M17 8h2a2 2 0 012 2v6a2 2 0 01-2 2h-2v4l-4-4H9a1.994 1.994 0 01-1.414-.586m0 0L11 14h4a2 2 0 002-2V6a2 2 0 00-2-2H5a2 2 0 00-2 2v6a2 2 0 002 2h2v4l.586-.586z\"/></svg>", true, 3, "Şeffaf İletişim" }
                });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 28, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 10, 3, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "CreatedAt", "FullName", "Message", "Rating", "Title" },
                values: new object[] { "https://i.pravatar.cc/150?img=60", new DateTime(2026, 10, 6, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3612), "Caner Polat", "SEO uyumlu yapısı sayesinde Google'da ilk sayfaya çıktık. Emekleri için teşekkürler.", 5, "Polat Lojistik, Kurucu" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AvatarUrl", "CreatedAt", "FullName", "IsApproved", "Message", "Rating", "Title" },
                values: new object[,]
                {
                    { 104, "https://i.pravatar.cc/150?img=5", new DateTime(2026, 9, 23, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3614), "Zeynep Demir", true, "Harika bir vizyon ve mükemmel iletişim. Tüm süreç boyunca bizi bilgilendirdi ve beklentilerimizi aştı.", 5, "Demir Mimarlık" },
                    { 105, "https://i.pravatar.cc/150?img=8", new DateTime(2026, 9, 18, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3616), "Emre Can", true, "Projemizin altyapısı çok sağlam oldu. Gelecekteki güncellemeler için de Samet'le çalışacağız.", 5, "StartUp Co, Kurucu Ortak" },
                    { 106, "https://i.pravatar.cc/150?img=9", new DateTime(2026, 9, 16, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3618), "Ayşe Nur", true, "Tasarım çok modern ve göz alıcı. Mobil uyumluluk konusunda hiçbir sıkıntı yaşamadık.", 5, "Nur Medya" },
                    { 107, "https://i.pravatar.cc/150?img=12", new DateTime(2026, 9, 13, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3620), "Burak Çelik", true, "Eski sitemiz çok yavaştı. Yeni tasarım ve altyapı ile sitenin açılma hızı 10 kat arttı.", 4, "Çelik İnşaat" },
                    { 108, "https://i.pravatar.cc/150?img=20", new DateTime(2026, 9, 8, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3622), "Selin Aydın", true, "Süreç çok profesyonel ilerledi. İsteklerimizin hepsini eksiksiz ve hızlı bir şekilde yerine getirdi.", 5, "Aydın E-Ticaret" },
                    { 109, "https://i.pravatar.cc/150?img=33", new DateTime(2026, 9, 3, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3625), "Kaan Yılmaz", true, "Temiz kod, harika mimari. Teknik SEO konusunda da çok bilgili.", 5, "Yılmaz Yazılım" },
                    { 110, "https://i.pravatar.cc/150?img=41", new DateTime(2026, 8, 29, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3626), "Fatma Koç", true, "Web sitemizin yeni hali müşterilerimizden çok güzel geri dönüşler alıyor. Teşekkür ederiz.", 5, "Koç Danışmanlık" },
                    { 111, "https://i.pravatar.cc/150?img=50", new DateTime(2026, 8, 24, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3630), "Mustafa Şahin", true, "Sıfır hata ile teslimat. İşini gerçekten severek ve özenerek yapıyor.", 5, "Şahin Lojistik" },
                    { 112, "https://i.pravatar.cc/150?img=52", new DateTime(2026, 8, 19, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3632), "Elif Özkan", true, "Beklentilerimizin çok üstünde bir iş çıkardı. Bütün ekibe güven veriyor.", 5, "Özkan Ajans" },
                    { 113, "https://i.pravatar.cc/150?img=55", new DateTime(2026, 8, 14, 12, 8, 44, 293, DateTimeKind.Local).AddTicks(3634), "Cem Erdoğan", true, "Uzun vadeli iş ortağımız oldu. Kurumsal projemizde en büyük destekçimiz.", 5, "Erdoğan Holding" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutFeatures");

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 27, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 10, 2, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "CreatedAt", "FullName", "Message", "Rating", "Title" },
                values: new object[] { "https://i.pravatar.cc/150?img=15", new DateTime(2026, 10, 5, 23, 54, 21, 364, DateTimeKind.Local).AddTicks(1583), "Caner Çelik", "Vizyonu çok geniş, sadece kod yazmıyor; projenin büyümesi ve modern durması için harika tasarım fikirleri veriyor.", 4, "Girişimci" });
        }
    }
}
