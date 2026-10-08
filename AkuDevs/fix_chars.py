import os

files = ['Views/Home/Index.cshtml', 'Views/Shared/_Layout.cshtml']

replacements = {
    'Ä±': 'ı',
    'Ä°': 'İ',
    'ÅŸ': 'ş',
    'Åž': 'Ş',
    'Ã¼': 'ü',
    'Ã§': 'ç',
    'Ã‡': 'Ç',
    'Ã¶': 'ö',
    'Ã–': 'Ö',
    'ÄŸ': 'ğ',
    'Äž': 'Ğ'
}

for filepath in files:
    if os.path.exists(filepath):
        with open(filepath, 'r', encoding='utf-8') as f:
            content = f.read()
        
        for k, v in replacements.items():
            content = content.replace(k, v)
            
        with open(filepath, 'w', encoding='utf-8-sig') as f:
            f.write(content)
