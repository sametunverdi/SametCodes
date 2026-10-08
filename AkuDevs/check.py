import json
import codecs

transcript_path = r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl'

with codecs.open(transcript_path, 'r', encoding='utf-8', errors='replace') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('type') == 'PLANNER_RESPONSE':
                for tc in data.get('tool_calls', []):
                    if tc.get('name') == 'run_command':
                        print(tc.get('args', {}).get('CommandLine'))
                        print('---')
        except:
            pass
