using AkuDevs.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AkuDevs.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TechStack> TechStacks { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<WorkProcess> WorkProcesses { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<AboutFeature> AboutFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AboutFeature>().HasData(
                new AboutFeature { Id = 1, Title = "Hız & Performans", Description = "Yavaş siteler müşteri kaybettirir. Geliştirdiğim her proje, Google Lighthouse skorlarında zirveye oynamak üzere milisaniyelik seviyede optimize edilir.", IconSvg = "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M13 10V3L4 14h7v7l9-11h-7z\"/></svg>", ColorClass = "red", OrderIndex = 1 },
                new AboutFeature { Id = 2, Title = "Temiz Kod (Clean Code)", Description = "Spagetti koda karşıyım. Mimariyi öylesine sağlam ve modüler kurarım ki, yarın başkası devralsa bile sistemi bir kitap okur gibi anlar.", IconSvg = "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10 20l4-16m4 4l4 4-4 4M6 16l-4-4 4-4\"/></svg>", ColorClass = "amber", OrderIndex = 2 },
                new AboutFeature { Id = 3, Title = "Şeffaf İletişim", Description = "Sürecin her anında nerede olduğumuzu bilirsiniz. Sürpriz maliyetler veya gizli mazeretler yoktur, sadece net tarihler ve şeffaf sonuçlar vardır.", IconSvg = "<svg class=\"w-10 h-10\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.5\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M17 8h2a2 2 0 012 2v6a2 2 0 01-2 2h-2v4l-4-4H9a1.994 1.994 0 01-1.414-.586m0 0L11 14h4a2 2 0 002-2V6a2 2 0 00-2-2H5a2 2 0 00-2 2v6a2 2 0 002 2h2v4l.586-.586z\"/></svg>", ColorClass = "blue", OrderIndex = 3 }
            );

            // Seed Data for TechStacks (Marquee)
            modelBuilder.Entity<TechStack>().HasData(
                new TechStack { Id = 1, NameTr = "C# ASP.NET Core", NameEn = "C# ASP.NET Core", OrderIndex = 0 },
                new TechStack { Id = 2, NameTr = "Tailwind CSS", NameEn = "Tailwind CSS", OrderIndex = 1 },
                new TechStack { Id = 3, NameTr = "GSAP Animasyon", NameEn = "GSAP Animation", OrderIndex = 2 },
                new TechStack { Id = 4, NameTr = "SQL Server Veritabanı", NameEn = "SQL Server Database", OrderIndex = 3 },
                new TechStack { Id = 5, NameTr = "JavaScript", NameEn = "JavaScript", OrderIndex = 4 },
                new TechStack { Id = 6, NameTr = "MVC Mimarisi", NameEn = "MVC Architecture", OrderIndex = 5 },
                new TechStack { Id = 7, NameTr = "RESTful API'ler", NameEn = "RESTful APIs", OrderIndex = 6 }
            );

            // Seed Data for Skills (Grid)
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, TitleTr = "ASP.NET Core", TitleEn = "ASP.NET Core", IconText = "C#", ColorHex = "#4f46e5", DescriptionTr = "Güvenli, hızlı ve bakımı kolay MVC mimarisi ile sunucu tarafı geliştirme.", DescriptionEn = "Secure, fast, and maintainable server-side development with MVC architecture.", OrderIndex = 0 },
                new Skill { Id = 2, TitleTr = "Tailwind CSS", TitleEn = "Tailwind CSS", IconText = "CSS", ColorHex = "#0ea5e9", DescriptionTr = "Mobil öncelikli, tutarlı ve küçük boyutlu modern arayüzler.", DescriptionEn = "Mobile-first, consistent, and compact modern interfaces.", OrderIndex = 1 },
                new Skill { Id = 3, TitleTr = "JavaScript & GSAP", TitleEn = "JavaScript & GSAP", IconText = "JS", ColorHex = "#fbbf24", DescriptionTr = "Sayfayı canlandıran, performansı bozmayan akıcı animasyonlar.", DescriptionEn = "Fluid animations that bring the page to life without compromising performance.", OrderIndex = 2 },
                new Skill { Id = 4, TitleTr = "SQL Server", TitleEn = "SQL Server", IconText = "SQL", ColorHex = "#2563eb", DescriptionTr = "Düzenli veri modeli ve hızlı sorgularla sağlam altyapı.", DescriptionEn = "Solid infrastructure with structured data models and fast queries.", OrderIndex = 3 },
                new Skill { Id = 5, TitleTr = "Teknik SEO", TitleEn = "Technical SEO", IconText = "SEO", ColorHex = "#10b981", DescriptionTr = "Anlamlı HTML, meta yapısı ve hız ile arama motorlarında görünürlük.", DescriptionEn = "Visibility in search engines with semantic HTML, meta structure, and speed.", OrderIndex = 4 },
                new Skill { Id = 6, TitleTr = "Mobil Uyumluluk", TitleEn = "Mobile UX", IconText = "UX", ColorHex = "#f97316", DescriptionTr = "Telefondan masaüstüne her ekranda kusursuz deneyim.", DescriptionEn = "Flawless experience across all screens from mobile to desktop.", OrderIndex = 5 }
            );

            // Seed Data for Projects
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, TitleTr = "Pamir Plastik", TitleEn = "Pamir Plastic", CategoryTr = "Kurumsal Web", CategoryEn = "Corporate Web", DescriptionTr = "Uluslararası standartlarda, modern ve keskin hatlara sahip kurumsal üretim tesisi web arayüzü.", DescriptionEn = "Modern corporate web interface.", ImageUrl = "https://images.unsplash.com/photo-1486406146926-c627a92ad1ab?auto=format&fit=crop&w=800&q=80", ProjectUrl = "#", IsActive = true, ShowOnHome = true, OrderIndex = 0 },
                new Project { Id = 2, TitleTr = "Yeni Proje", TitleEn = "New Project", CategoryTr = "Kurumsal Web", CategoryEn = "Corporate Web", DescriptionTr = "Bu alanda yakında yeni bir kurumsal çalışma sergilenecek.", DescriptionEn = "Coming soon.", ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&w=800&q=80", ProjectUrl = "#", IsActive = true, ShowOnHome = true, OrderIndex = 1 },
                new Project { Id = 3, TitleTr = "Özel Yazılım", TitleEn = "Custom Software", CategoryTr = "Özel Yazılım", CategoryEn = "Custom Software", DescriptionTr = "Bu alanda yakında yeni bir özel yazılım çalışması sergilenecek.", DescriptionEn = "Coming soon.", ImageUrl = "https://images.unsplash.com/photo-1519389950473-47ba0277781c?auto=format&fit=crop&w=800&q=80", ProjectUrl = "#", IsActive = true, ShowOnHome = true, OrderIndex = 2 }
            );

            // Seed Data for Services
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, TitleTr = "Özel Web Tasarım", TitleEn = "Custom Web Design", DescriptionTr = "Markanızın ruhunu yansıtan, hazır şablonlardan uzak, tamamen size özel kodlanmış premium arayüzler ve kusursuz kullanıcı deneyimi.", DescriptionEn = "Custom coded premium interfaces.", ImageUrl = "https://images.unsplash.com/photo-1498050108023-c5249f4df085?auto=format&fit=crop&w=1200&q=80", IconSvg = "<svg class=\"w-8 h-8\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M12 2L2 7l10 5 10-5-10-5zM2 17l10 5 10-5M2 12l10 5 10-5\"/></svg>", IsLargeCard = true, OrderIndex = 0 },
                new Service { Id = 2, TitleTr = "Hız ve Performans", TitleEn = "Speed & Performance", DescriptionTr = "Saniyeler içinde açılan optimize edilmiş yapılar.", DescriptionEn = "Optimized fast architectures.", ImageUrl = "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?auto=format&fit=crop&w=800&q=80", IconSvg = "<svg class=\"w-6 h-6\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M13 10V3L4 14h7v7l9-11h-7z\"/></svg>", IsLargeCard = false, OrderIndex = 1 },
                new Service { Id = 3, TitleTr = "SEO Optimizasyonu", TitleEn = "SEO Optimization", DescriptionTr = "Arama motorlarında rakiplerinizi geride bırakın.", DescriptionEn = "Leave competitors behind in search engines.", ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=800&q=80", IconSvg = "<svg class=\"w-6 h-6\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" viewBox=\"0 0 24 24\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z\"/></svg>", IsLargeCard = false, OrderIndex = 2 }
            );

            // Seed Data for Hero Sections
            modelBuilder.Entity<HeroSection>().HasData(
                new HeroSection
                {
                    Id = 1,
                    BadgeTr = "Full Stack Geliştirici",
                    BadgeEn = "Full Stack Developer",
                    TitleWhiteTr = "Dijital Dünyaya",
                    TitleWhiteEn = "To the Digital World",
                    TitleRedTr = "Yön Ver",
                    TitleRedEn = "Give Direction",
                    DescriptionTr = "Markanızı dijital dünyada öne çıkaran, modern, hızlı ve SEO uyumlu web uygulamaları geliştiriyorum.",
                    DescriptionEn = "I develop modern, fast, and SEO-friendly web applications that make your brand stand out in the digital world."
                }
            );

            // Seed Data for Social Medias
            modelBuilder.Entity<SocialMedia>().HasData(
                new SocialMedia { Id = 1, PlatformName = "GitHub", Url = "https://github.com", IconSvg = "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M12 2C6.477 2 2 6.484 2 12.017c0 4.425 2.865 8.18 6.839 9.504.5.092.682-.217.682-.483 0-.237-.008-.868-.013-1.703-2.782.605-3.369-1.343-3.369-1.343-.454-1.158-1.11-1.466-1.11-1.466-.908-.62.069-.608.069-.608 1.003.07 1.531 1.032 1.531 1.032.892 1.53 2.341 1.088 2.91.832.092-.647.35-1.088.636-1.338-2.22-.253-4.555-1.113-4.555-4.951 0-1.093.39-1.988 1.029-2.688-.103-.253-.446-1.272.098-2.65 0 0 .84-.27 2.75 1.026A9.564 9.564 0 0112 6.844c.85.004 1.705.115 2.504.337 1.909-1.296 2.747-1.027 2.747-1.027.546 1.379.202 2.398.1 2.651.64.7 1.028 1.595 1.028 2.688 0 3.848-2.339 4.695-4.566 4.943.359.309.678.92.678 1.855 0 1.338-.012 2.419-.012 2.747 0 .268.18.58.688.482A10.019 10.019 0 0022 12.017C22 6.484 17.522 2 12 2z\"></path></svg>", IsActive = true, OrderIndex = 0 },
                new SocialMedia { Id = 2, PlatformName = "LinkedIn", Url = "https://linkedin.com", IconSvg = "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M19 0h-14c-2.761 0-5 2.239-5 5v14c0 2.761 2.239 5 5 5h14c2.762 0 5-2.239 5-5v-14c0-2.761-2.238-5-5-5zm-11 19h-3v-11h3v11zm-1.5-12.268c-.966 0-1.75-.79-1.75-1.764s.784-1.764 1.75-1.764 1.75.79 1.75 1.764-.783 1.764-1.75 1.764zm13.5 12.268h-3v-5.604c0-3.368-4-3.113-4 0v5.604h-3v-11h3v1.765c1.396-2.586 7-2.777 7 2.476v6.759z\"></path></svg>", IsActive = true, OrderIndex = 1 },
                new SocialMedia { Id = 3, PlatformName = "Twitter", Url = "https://twitter.com", IconSvg = "<svg class=\"w-5 h-5\" fill=\"currentColor\" viewBox=\"0 0 24 24\"><path d=\"M23.953 4.57a10 10 0 01-2.825.775 4.958 4.958 0 002.163-2.723c-.951.555-2.005.959-3.127 1.184a4.92 4.92 0 00-8.384 4.482C7.69 8.095 4.067 6.13 1.64 3.162a4.822 4.822 0 00-.666 2.475c0 1.71.87 3.213 2.188 4.096a4.904 4.904 0 01-2.228-.616v.06a4.923 4.923 0 003.946 4.827 4.996 4.996 0 01-2.212.085 4.936 4.936 0 004.604 3.417 9.867 9.867 0 01-6.102 2.105c-.39 0-.779-.023-1.17-.067a13.995 13.995 0 007.557 2.209c9.053 0 13.998-7.496 13.998-13.985 0-.21 0-.42-.015-.63A9.935 9.935 0 0024 4.59z\"></path></svg>", IsActive = true, OrderIndex = 2 }
            );

            // Seed Data for Work Processes
            modelBuilder.Entity<WorkProcess>().HasData(
                new WorkProcess { Id = 1, StepNumber = "01", TitleTr = "Keşif & Planlama", TitleEn = "Discovery & Planning", DescriptionTr = "İhtiyaçlarınızı, hedef kitlenizi ve rakiplerinizi birlikte analiz ederiz.", DescriptionEn = "We analyze your needs, target audience, and competitors together.", AnimationDelay = 0.0, OrderIndex = 0 },
                new WorkProcess { Id = 2, StepNumber = "02", TitleTr = "Tasarım", TitleEn = "Design", DescriptionTr = "Markanıza özel, kurumsal ve akılda kalıcı arayüzü tasarlarım.", DescriptionEn = "I design a corporate and memorable interface specifically for your brand.", AnimationDelay = 0.1, OrderIndex = 1 },
                new WorkProcess { Id = 3, StepNumber = "03", TitleTr = "Geliştirme", TitleEn = "Development", DescriptionTr = "Hızlı, güvenli ve SEO uyumlu şekilde kodlar, mobil testlerini yaparım.", DescriptionEn = "I code fast, secure, and SEO-friendly, and perform mobile testing.", AnimationDelay = 0.2, OrderIndex = 2 },
                new WorkProcess { Id = 4, StepNumber = "04", TitleTr = "Yayın & Destek", TitleEn = "Launch & Support", DescriptionTr = "Yayına alır, sonrasında destek ve geliştirmeler için yanınızda olurum.", DescriptionEn = "I launch the project and stand by you for support and improvements afterwards.", AnimationDelay = 0.3, OrderIndex = 3 }
            );

            // Seed Data for Statistics
            modelBuilder.Entity<Statistic>().HasData(
                new Statistic { Id = 1, Value = "45+", TitleTr = "Başarılı<br>Proje", TitleEn = "Successful<br>Projects", OrderIndex = 0 },
                new Statistic { Id = 2, Value = "%100", TitleTr = "Müşteri<br>Memnuniyeti", TitleEn = "Client<br>Satisfaction", OrderIndex = 1 },
                new Statistic { Id = 3, Value = "5+", TitleTr = "Yıllık<br>Deneyim", TitleEn = "Years of<br>Experience", OrderIndex = 2 },
                new Statistic { Id = 4, Value = "7/24", TitleTr = "Sürekli<br>Destek", TitleEn = "Continuous<br>Support", OrderIndex = 3 }
            );

            // Seed Data for Testimonials
            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial { Id = 1, FullName = "Ahmet Yılmaz", Title = "Pamir Plastik, CEO", Message = "Web sitemiz için aldığımız hizmetten inanılmaz memnun kaldık. Samet Bey projeyi tam zamanında ve sıfır hatayla teslim etti.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=11", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-10) },
                new Testimonial { Id = 2, FullName = "Merve Kaya", Title = "Nova Finans, CTO", Message = "Admin paneli o kadar akıcı ki, işlerimizi %50 hızlandırdı. Gerçekten estetik ve hız bir arada sunulmuş.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=32", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-5) },
                new Testimonial { Id = 3, FullName = "Caner Polat", Title = "Polat Lojistik, Kurucu", Message = "SEO uyumlu yapısı sayesinde Google'da ilk sayfaya çıktık. Emekleri için teşekkürler.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=60", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-2) },
                new Testimonial { Id = 104, FullName = "Zeynep Demir", Title = "Demir Mimarlık", Message = "Harika bir vizyon ve mükemmel iletişim. Tüm süreç boyunca bizi bilgilendirdi ve beklentilerimizi aştı.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=5", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-15) },
                new Testimonial { Id = 105, FullName = "Emre Can", Title = "StartUp Co, Kurucu Ortak", Message = "Projemizin altyapısı çok sağlam oldu. Gelecekteki güncellemeler için de Samet'le çalışacağız.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=8", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-20) },
                new Testimonial { Id = 106, FullName = "Ayşe Nur", Title = "Nur Medya", Message = "Tasarım çok modern ve göz alıcı. Mobil uyumluluk konusunda hiçbir sıkıntı yaşamadık.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=9", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-22) },
                new Testimonial { Id = 107, FullName = "Burak Çelik", Title = "Çelik İnşaat", Message = "Eski sitemiz çok yavaştı. Yeni tasarım ve altyapı ile sitenin açılma hızı 10 kat arttı.", Rating = 4, AvatarUrl = "https://i.pravatar.cc/150?img=12", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-25) },
                new Testimonial { Id = 108, FullName = "Selin Aydın", Title = "Aydın E-Ticaret", Message = "Süreç çok profesyonel ilerledi. İsteklerimizin hepsini eksiksiz ve hızlı bir şekilde yerine getirdi.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=20", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-30) },
                new Testimonial { Id = 109, FullName = "Kaan Yılmaz", Title = "Yılmaz Yazılım", Message = "Temiz kod, harika mimari. Teknik SEO konusunda da çok bilgili.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=33", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-35) },
                new Testimonial { Id = 110, FullName = "Fatma Koç", Title = "Koç Danışmanlık", Message = "Web sitemizin yeni hali müşterilerimizden çok güzel geri dönüşler alıyor. Teşekkür ederiz.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=41", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-40) },
                new Testimonial { Id = 111, FullName = "Mustafa Şahin", Title = "Şahin Lojistik", Message = "Sıfır hata ile teslimat. İşini gerçekten severek ve özenerek yapıyor.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=50", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-45) },
                new Testimonial { Id = 112, FullName = "Elif Özkan", Title = "Özkan Ajans", Message = "Beklentilerimizin çok üstünde bir iş çıkardı. Bütün ekibe güven veriyor.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=52", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-50) },
                new Testimonial { Id = 113, FullName = "Cem Erdoğan", Title = "Erdoğan Holding", Message = "Uzun vadeli iş ortağımız oldu. Kurumsal projemizde en büyük destekçimiz.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=55", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-55) }
            );
        }
    }
}


