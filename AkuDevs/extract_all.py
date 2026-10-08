import json

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'
dumps = []

with open(transcript_path, 'r', encoding='utf-8') as f:
    look_for_next = False
    for line in f:
        try:
            data = json.loads(line)
            
            if data.get('type') == 'PLANNER_RESPONSE':
                for tc in data.get('tool_calls', []):
                    if tc.get('name') == 'run_command':
                        cmd = tc.get('args', {}).get('CommandLine', '')
                        if 'Get-Content Views/Home/Index.cshtml' in cmd:
                            look_for_next = True
            
            if look_for_next and data.get('type') == 'TOOL_RESPONSE':
                dumps.append(str(data))
                look_for_next = False
        except:
            pass

with open('all_dumps.txt', 'w', encoding='utf-8') as f:
    for d in dumps:
        if '<!-- TECH STACK' in d or '<!-- SERVICES' in d or '<!-- WORK PROCESS' in d:
            f.write(d)
            f.write('\n\n---NEXT---\n\n')
print('Found chunks with sections:', len(dumps))
