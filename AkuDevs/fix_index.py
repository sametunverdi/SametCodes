import re

with open('Views/Home/Index.cshtml', 'r', encoding='utf-8') as f:
    text = f.read()

# Replace Testimonials Section
testimonials_pattern = r'<!-- TESTIMONIALS \(YORUMLAR\) -->.*?<!-- COMMENT MODAL -->'
testimonials_replacement = '''<!-- TESTIMONIALS (YORUMLAR) -->
<section id="testimonials" class="pt-32 pb-24 bg-[#c2871b] relative overflow-hidden flex flex-col items-center justify-center">
    <div class="max-w-4xl mx-auto px-4 text-center z-10 mb-8 reveal">
        <span class="inline-block mb-4 px-6 py-1.5 rounded-full border border-white/30 text-white text-xs font-bold uppercase tracking-widest bg-white/10 backdrop-blur-sm shadow-sm">MEMNUNİYET</span>
        <h2 class="text-4xl md:text-5xl font-extrabold mb-4 text-white">Geliştirdiğim Bağlar</h2>
        <p class="text-white/90 text-lg mb-8 max-w-xl mx-auto font-medium">Müşterilerimin projeleriyle kurduğumuz uzun soluklu iş ortaklıkları hakkında ne düşündüklerini dinleyin.</p>
    </div>

    <!-- POKER CARDS CAROUSEL -->
    <div class="relative w-full max-w-3xl mx-auto h-[400px] flex items-center justify-center perspective-[1200px] mt-2">
        @if (ViewBag.Testimonials != null)
        {
            var tests = ((IEnumerable<AkuDevs.Models.Testimonial>)ViewBag.Testimonials).ToList();
            if (tests.Any())
            {
                for (int i = 0; i < tests.Count; i++)
                {
                    <div class="testimonial-card absolute w-[300px] sm:w-[380px] bg-white/95 backdrop-blur-sm rounded-3xl p-8 shadow-2xl transition-all duration-700 ease-out cursor-pointer group" data-index="@i">
                        <div class="flex text-[#eab308] text-sm mb-4">
                            @for (int s = 0; s < tests[i].Rating; s++)
                            {
                                <svg class="w-4 h-4 mr-1" fill="currentColor" viewBox="0 0 20 20"><path d="M9.049 2.927c.3-.921 1.603-.921 1.902 0l1.07 3.292a1 1 0 00.95.69h3.462c.969 0 1.371 1.24.588 1.81l-2.8 2.034a1 1 0 00-.364 1.118l1.07 3.292c.3.921-.755 1.688-1.54 1.118l-2.8-2.034a1 1 0 00-1.175 0l-2.8 2.034c-.784.57-1.838-.197-1.539-1.118l1.07-3.292a1 1 0 00-.364-1.118L2.98 8.72c-.783-.57-.38-1.81.588-1.81h3.461a1 1 0 00.951-.69l1.07-3.292z"/></svg>
                            }
                        </div>
                        <p class="text-[#1a1a1a] font-bold text-lg italic leading-relaxed mb-6 line-clamp-4">"@tests[i].Message"</p>
                        
                        <div class="flex items-center gap-4">
                            <img src="@tests[i].AvatarUrl" alt="@tests[i].FullName" class="w-12 h-12 rounded-full object-cover border-2 border-[#c2871b]/20 p-0.5" />
                            <div>
                                <h4 class="font-black text-[#1a1a1a] text-sm uppercase tracking-wide">@tests[i].FullName</h4>
                                <p class="text-xs text-gray-500 font-medium mt-0.5">@tests[i].Title</p>
                            </div>
                        </div>
                    </div>
                }
            }
        }
    </div>

    <!-- CAROUSEL CONTROLS & ADD COMMENT BUTTON -->
    <div class="flex flex-col items-center gap-6 mt-4 z-20">
        <div class="flex gap-4">
            <button id="prevTest" class="w-12 h-12 rounded-full border border-white/20 bg-white/10 text-white flex items-center justify-center hover:bg-white hover:text-[#c2871b] transition-all shadow-lg backdrop-blur-sm">
                <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M15 19l-7-7 7-7"></path></svg>
            </button>
            <button id="nextTest" class="w-12 h-12 rounded-full border border-white/20 bg-white/10 text-white flex items-center justify-center hover:bg-white hover:text-[#c2871b] transition-all shadow-lg backdrop-blur-sm">
                <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 5l7 7-7 7"></path></svg>
            </button>
        </div>
        <button onclick="openCommentModal()" class="px-8 py-3.5 rounded-full bg-[#111] text-white font-bold hover:bg-black hover:-translate-y-1 transition-all shadow-2xl flex items-center gap-2">
            Siz de Yorum Yapın
            <svg class="w-4 h-4 text-gray-300" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M15.232 5.232l3.536 3.536m-2.036-5.036a2.5 2.5 0 113.536 3.536L6.5 21.036H3v-3.572L16.732 3.732z"/></svg>
        </button>
    </div>
</section>

<!-- ILETISIM -->
<section id="contact" class="py-24 relative overflow-hidden bg-gradient-to-br from-[#8f0000] to-[#550000] flex flex-col items-center justify-center text-center">
    <div class="max-w-4xl mx-auto px-4 z-10 reveal">
        <span class="inline-block mb-6 px-6 py-1.5 rounded-full border border-white/20 text-white text-xs font-bold uppercase tracking-widest bg-black/20 backdrop-blur-sm">İLETİŞİM</span>
        <h2 class="text-4xl md:text-5xl font-extrabold mb-4 text-white">Projenizi Birlikte<br/>Hayata Geçirelim</h2>
        <p class="text-white/80 text-lg mb-10 max-w-xl mx-auto font-medium">Fikrinizi anlatın, size en uygun çözümü ve net bir teklifi hızlıca paylaşayım.</p>
        
        <div class="flex flex-col sm:flex-row justify-center items-center gap-4">
            <a href="mailto:info@akudevs.com" class="px-8 py-3.5 rounded-full bg-[#e5e7eb] text-[#8f0000] font-bold text-lg hover:bg-white hover:scale-105 transition-all shadow-xl">
                E-posta Gönder
            </a>
            <a href="https://wa.me/905555555555" target="_blank" class="px-8 py-3.5 rounded-full bg-[#e5e7eb] text-[#8f0000] font-bold text-lg hover:bg-white hover:scale-105 transition-all shadow-xl flex items-center gap-2">
                WhatsApp ile Yaz
            </a>
        </div>
    </div>
</section>

<!-- COMMENT MODAL -->'''

text = re.sub(testimonials_pattern, testimonials_replacement, text, flags=re.DOTALL)

# Replace Comment Modal
modal_pattern = r'<!-- COMMENT MODAL -->.*?@section Scripts'
modal_replacement = '''<!-- COMMENT MODAL -->
<div id="commentModal" class="fixed inset-0 z-[100] flex items-center justify-center p-4 opacity-0 invisible transition-all duration-300">
    <!-- Backdrop Blur -->
    <div class="absolute inset-0 bg-black/60 backdrop-blur-sm" onclick="closeCommentModal()"></div>
    
    <!-- Modal Content -->
    <div id="commentModalContent" class="bg-[#e5e7eb] rounded-3xl w-full max-w-lg relative z-10 shadow-2xl scale-95 translate-y-4 opacity-0 transition-all duration-500 max-h-[95vh] overflow-y-auto">
        <div class="p-6 pb-2 flex justify-between items-center sticky top-0 z-20">
            <h3 class="text-xl font-black text-[#1a1a1a]">Deneyiminizi Paylaşın</h3>
            <button onclick="closeCommentModal()" class="w-8 h-8 rounded-full bg-gray-200/50 hover:bg-gray-300 text-gray-500 flex items-center justify-center transition-colors">
                <svg class="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12"></path></svg>
            </button>
        </div>

        <form id="commentForm" action="/Home/SubmitTestimonial" method="post" class="px-6 pb-6 space-y-6">
            
            <div class="text-center">
                <label class="block text-[10px] font-extrabold text-gray-500 mb-2 uppercase tracking-widest">PUANINIZ</label>
                <div class="flex justify-center gap-1" id="starRatingContainer"></div>
                <input type="hidden" name="rating" id="selectedRating" value="5">
            </div>

            <div class="flex flex-col sm:flex-row gap-4">
                <div class="flex-1 relative">
                    <label class="block text-[10px] font-extrabold text-gray-500 mb-1.5 uppercase tracking-widest">ADINIZ SOYADINIZ</label>
                    <div class="relative">
                        <svg class="w-4 h-4 absolute left-3 top-1/2 -translate-y-1/2 text-gray-400" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/></svg>
                        <input type="text" name="fullName" required placeholder="İsim Soyisim" class="w-full pl-9 pr-3 py-2.5 rounded-lg bg-gray-200/80 border border-transparent focus:bg-white focus:border-gray-300 transition-all outline-none font-semibold text-[#1a1a1a] text-sm">
                    </div>
                </div>
                <div class="flex-1 relative">
                    <label class="block text-[10px] font-extrabold text-gray-500 mb-1.5 uppercase tracking-widest">UNVANINIZ / ŞİRKET</label>
                    <div class="relative">
                        <svg class="w-4 h-4 absolute left-3 top-1/2 -translate-y-1/2 text-gray-400" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M21 13.255A23.931 23.931 0 0112 15c-3.183 0-6.22-.62-9-1.745M16 6V4a2 2 0 00-2-2h-4a2 2 0 00-2 2v2m4 6h.01M5 20h14a2 2 0 002-2V8a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z"/></svg>
                        <input type="text" name="title" placeholder="Unvan / Şirket" class="w-full pl-9 pr-3 py-2.5 rounded-lg bg-gray-200/80 border border-transparent focus:bg-white focus:border-gray-300 transition-all outline-none font-semibold text-[#1a1a1a] text-sm">
                    </div>
                </div>
            </div>

            <div>
                <label class="block text-[10px] font-extrabold text-gray-500 mb-1.5 uppercase tracking-widest">YORUMUNUZ</label>
                <textarea name="message" required rows="3" placeholder="Proje sürecindeki deneyiminizi bizimle paylaşın..." class="w-full px-3 py-2.5 rounded-lg bg-gray-200/80 border border-transparent focus:bg-white focus:border-gray-300 transition-all outline-none resize-none font-semibold text-[#1a1a1a] text-sm"></textarea>
            </div>

            <div>
                <label class="block text-[10px] font-extrabold text-gray-500 mb-2 uppercase tracking-widest">PROFİL FOTOĞRAFI SEÇİN</label>
                <div class="flex gap-2 overflow-x-auto pb-2 px-1 snap-x no-scrollbar" id="avatarGrid"></div>
                <input type="hidden" name="avatarUrl" id="avatarUrl" value="">
                
                <div class="flex items-center gap-4 my-3">
                    <div class="h-px bg-gray-300 flex-1"></div>
                    <span class="text-[10px] font-bold text-gray-400">VEYA</span>
                    <div class="h-px bg-gray-300 flex-1"></div>
                </div>
                
                <button type="button" class="w-full py-2.5 rounded-full border border-dashed border-gray-400 text-gray-500 font-bold text-xs hover:bg-gray-200 hover:text-gray-700 transition-all flex items-center justify-center gap-2">
                    <svg class="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 16v1a3 3 0 003 3h10a3 3 0 003-3v-1m-4-8l-4-4m0 0L8 8m4-4v12"/></svg>
                    Kendi Fotoğrafını Yükle
                </button>
            </div>

            <div class="flex justify-end pt-2">
                <button type="submit" class="px-8 py-2.5 rounded-full bg-black text-white font-bold text-sm hover:scale-105 transition-all shadow-xl">
                    Gönder
                </button>
            </div>
        </form>
    </div>
</div>

@section Scripts'''
text = re.sub(modal_pattern, modal_replacement, text, flags=re.DOTALL)

with open('Views/Home/Index.cshtml', 'w', encoding='utf-8') as f:
    f.write(text)
