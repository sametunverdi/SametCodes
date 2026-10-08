import json
import codecs

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'
best_content = ''
max_len = 0

with codecs.open(transcript_path, 'r', encoding='utf-8', errors='replace') as f:
    for line in f:
        try:
            data = json.loads(line)
            # check the whole stringified json object
            s = json.dumps(data)
            if '<!-- HERO -->' in s and '<!-- TESTIMONIALS' in s and 'bg-[#0a0505]' in s:
                if len(s) > max_len:
                    max_len = len(s)
                    best_content = s
        except:
            pass

print('Found length:', max_len)
if max_len > 0:
    with open('recovered_dump.txt', 'w', encoding='utf-8') as out:
        out.write(best_content)
