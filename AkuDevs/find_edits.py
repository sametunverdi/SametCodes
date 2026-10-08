import json
with open(r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl', 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('type') == 'PLANNER_RESPONSE' and 'tool_calls' in data:
                for tc in data['tool_calls']:
                    if tc.get('name') in ['replace_file_content', 'write_to_file']:
                        args = tc.get('args', {})
                        if 'Index.cshtml' in args.get('TargetFile', ''):
                            print(f"Step {data.get('step_index')}: {tc.get('name')} - {args.get('Description', 'No desc')}")
        except:
            pass
