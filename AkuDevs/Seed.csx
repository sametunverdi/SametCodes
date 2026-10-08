using AkuDevs.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;

var builder = new DbContextOptionsBuilder<AppDbContext>();
builder.UseSqlServer(""Server=(localdb)\\mssqllocaldb;Database=SametCodesDb;Trusted_Connection=True;MultipleActiveResultSets=true"");
using var db = new AppDbContext(builder.Options);

if(!db.SocialMedias.Any(s => s.PlatformName == ""Email"")) {
    db.SocialMedias.Add(new AkuDevs.Models.SocialMedia { PlatformName = ""Email"", Url = ""mailto:hello@sametcodes.com"", IconSvg = ""<svg></svg>"", IsActive = true, OrderIndex = 4 });
}
if(!db.SocialMedias.Any(s => s.PlatformName == ""WhatsApp"")) {
    db.SocialMedias.Add(new AkuDevs.Models.SocialMedia { PlatformName = ""WhatsApp"", Url = ""https://wa.me/905301234567"", IconSvg = ""<svg></svg>"", IsActive = true, OrderIndex = 5 });
}
db.SaveChanges();
