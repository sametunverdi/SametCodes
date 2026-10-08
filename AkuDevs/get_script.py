import json

with open(r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl', 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('step_index') == 2455:
                content = data.get('content', '')
                if '@section Scripts' in content:
                    script_part = content.split('@section Scripts')[1]
                    with open('script_backup.txt', 'w', encoding='utf-8') as out:
                        out.write('@section Scripts' + script_part)
        except Exception:
            pass
