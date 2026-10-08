import os
import re

files = [f for f in os.listdir('Views/Home') if f.startswith('Index_Recovered_') or f.startswith('Chunk_')]
lines_map = {}

for f in files:
    with open(os.path.join('Views/Home', f), 'r', encoding='utf-8', errors='ignore') as file:
        content = file.read()
        for line in content.split('\n'):
            m = re.match(r'^(\d+):\s(.*)', line)
            if m:
                lnum = int(m.group(1))
                text = m.group(2)
                lines_map[lnum] = text

with open('Views/Home/Index_Restored.cshtml', 'w', encoding='utf-8') as out:
    for i in range(1, max(lines_map.keys()) + 1):
        if i in lines_map:
            out.write(lines_map[i] + '\n')
        else:
            out.write('\n')
