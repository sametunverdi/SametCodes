import re

with open('script_backup.txt', 'r', encoding='utf-8') as f:
    text = f.read()

# Remove line numbers from view_file output format
text = re.sub(r'^\d+:\s', '', text, flags=re.MULTILINE)

# Fix mojibake
text = text.replace('', 'i') # Just basic replacement for now, we will fix alerts manually

with open('script_backup_clean.txt', 'w', encoding='utf-8') as f:
    f.write(text)
