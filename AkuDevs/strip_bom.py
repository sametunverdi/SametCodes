import os

files = ['Views/Home/Index.cshtml', 'Views/Shared/_Layout.cshtml']

for filepath in files:
    if os.path.exists(filepath):
        # utf-8-sig reads the file and automatically strips the BOM if it exists
        with open(filepath, 'r', encoding='utf-8-sig') as f:
            content = f.read()
            
        # utf-8 writes it without BOM
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
