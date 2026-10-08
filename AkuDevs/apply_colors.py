import re
import os

with open('Views/Home/Index.cshtml', 'r', encoding='utf-8') as f:
    text = f.read()

# 1. Hero Darkness
text = text.replace('opacity-40', 'opacity-60')
text = text.replace('from-black/80 via-black/40', 'from-black/40 via-black/20')

# 2. Contact Section Red
text = text.replace('from-[#8f0000] to-[#550000]', 'from-[#ef4444] to-[#dc2626]')
text = text.replace('text-[#8f0000]', 'text-[#dc2626]')

# 3. Testimonials Gradient
text = text.replace('bg-[#d97706]', 'bg-gradient-to-br from-[#fcd34d] to-[#f59e0b]')
text = text.replace('text-[#d97706]', 'text-[#f59e0b]')
text = text.replace('border-[#d97706]', 'border-[#f59e0b]')

with open('Views/Home/Index.cshtml', 'w', encoding='utf-8') as f:
    f.write(text)
