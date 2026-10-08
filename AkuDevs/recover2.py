import json

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'
best_content = ''
max_len = 0

with open(transcript_path, 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if 'tool_calls' in data:
                for tc in data['tool_calls']:
                    pass
            # Tool responses are often stored as step type TOOL_RESPONSE or SYSTEM
            if data.get('type') == 'TOOL_RESPONSE' or 'output' in str(data):
                content_str = str(data)
                if '<!-- HERO -->' in content_str and '<!-- PROJELER L' in content_str:
                    # just an example, looking for big chunks
                    pass
                    
            # Let's just find the largest output containing "UpdateTestimonials" and "Hero"
            s = json.dumps(data)
            if 'updateTestimonials()' in s and 'hero-content' in s:
                if len(s) > max_len:
                    max_len = len(s)
                    best_content = s
        except Exception as e:
            pass

print('Found length:', max_len)
if max_len > 0:
    with open('recovered_dump.txt', 'w', encoding='utf-8') as out:
        out.write(best_content)
