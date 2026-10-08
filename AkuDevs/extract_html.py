import json

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'

with open('all_outputs.txt', 'w', encoding='utf-8') as out:
    with open(transcript_path, 'r', encoding='utf-8') as f:
        for line in f:
            try:
                data = json.loads(line)
                if data.get('type') == 'TOOL_RESPONSE' or 'output' in str(data):
                    out_text = data.get('output', str(data))
                    if 'class=' in out_text and 'section' in out_text:
                        out.write(out_text)
                        out.write('\n\n---CHUNK---\n\n')
            except:
                pass
