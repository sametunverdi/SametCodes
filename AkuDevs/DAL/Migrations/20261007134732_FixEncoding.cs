using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkuDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixEncoding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
