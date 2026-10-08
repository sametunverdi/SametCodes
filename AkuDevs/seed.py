import re

with open('DAL/AppDbContext.cs', 'r', encoding='utf-8') as f:
    text = f.read()

pattern = r'new Testimonial \{ Id = 1.*?new Testimonial \{ Id = 3.*?\}'
new_data = '''new Testimonial { Id = 1, FullName = "Ahmet Yılmaz", Title = "Pamir Plastik, CEO", Message = "Web sitemiz için aldığımız hizmetten inanılmaz memnun kaldık. Samet Bey projeyi tam zamanında ve sıfır hatayla teslim etti.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=11", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-10) },
                new Testimonial { Id = 2, FullName = "Merve Kaya", Title = "Nova Finans, CTO", Message = "Admin paneli o kadar akıcı ki, işlerimizi %50 hızlandırdı. Gerçekten estetik ve hız bir arada sunulmuş.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=32", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-5) },
                new Testimonial { Id = 3, FullName = "Caner Polat", Title = "Polat Lojistik, Kurucu", Message = "SEO uyumlu yapısı sayesinde Google'da ilk sayfaya çıktık. Emekleri için teşekkürler.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=60", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-2) },
                new Testimonial { Id = 4, FullName = "Zeynep Demir", Title = "Demir Mimarlık", Message = "Harika bir vizyon ve mükemmel iletişim. Tüm süreç boyunca bizi bilgilendirdi ve beklentilerimizi aştı.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=5", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-15) },
                new Testimonial { Id = 5, FullName = "Emre Can", Title = "StartUp Co, Kurucu Ortak", Message = "Projemizin altyapısı çok sağlam oldu. Gelecekteki güncellemeler için de Samet'le çalışacağız.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=8", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-20) },
                new Testimonial { Id = 6, FullName = "Ayşe Nur", Title = "Nur Medya", Message = "Tasarım çok modern ve göz alıcı. Mobil uyumluluk konusunda hiçbir sıkıntı yaşamadık.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=9", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-22) },
                new Testimonial { Id = 7, FullName = "Burak Çelik", Title = "Çelik İnşaat", Message = "Eski sitemiz çok yavaştı. Yeni tasarım ve altyapı ile sitenin açılma hızı 10 kat arttı.", Rating = 4, AvatarUrl = "https://i.pravatar.cc/150?img=12", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-25) },
                new Testimonial { Id = 8, FullName = "Selin Aydın", Title = "Aydın E-Ticaret", Message = "Süreç çok profesyonel ilerledi. İsteklerimizin hepsini eksiksiz ve hızlı bir şekilde yerine getirdi.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=20", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-30) },
                new Testimonial { Id = 9, FullName = "Kaan Yılmaz", Title = "Yılmaz Yazılım", Message = "Temiz kod, harika mimari. Teknik SEO konusunda da çok bilgili.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=33", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-35) },
                new Testimonial { Id = 10, FullName = "Fatma Koç", Title = "Koç Danışmanlık", Message = "Web sitemizin yeni hali müşterilerimizden çok güzel geri dönüşler alıyor. Teşekkür ederiz.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=41", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-40) },
                new Testimonial { Id = 11, FullName = "Mustafa Şahin", Title = "Şahin Lojistik", Message = "Sıfır hata ile teslimat. İşini gerçekten severek ve özenerek yapıyor.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=50", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-45) },
                new Testimonial { Id = 12, FullName = "Elif Özkan", Title = "Özkan Ajans", Message = "Beklentilerimizin çok üstünde bir iş çıkardı. Bütün ekibe güven veriyor.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=52", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-50) },
                new Testimonial { Id = 13, FullName = "Cem Erdoğan", Title = "Erdoğan Holding", Message = "Uzun vadeli iş ortağımız oldu. Kurumsal projemizde en büyük destekçimiz.", Rating = 5, AvatarUrl = "https://i.pravatar.cc/150?img=55", IsApproved = true, CreatedAt = DateTime.Now.AddDays(-55) }'''

text = re.sub(pattern, new_data, text, flags=re.DOTALL)

with open('DAL/AppDbContext.cs', 'w', encoding='utf-8') as f:
    f.write(text)
