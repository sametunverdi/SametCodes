import json
import re

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'
best_content = ''
max_len = 0

with open(transcript_path, 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if 'content' in data:
                c = data['content']
                if '<!-- HERO -->' in c and '<!-- TECH STACK -->' in c:
                    if len(c) > max_len:
                        max_len = len(c)
                        best_content = c
            
            # also check tool outputs
            if 'tool_calls' in data:
                pass
                
        except:
            pass

print('Found length:', max_len)
