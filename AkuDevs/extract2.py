import json

with open(r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl', 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('step_index') == 2391 and data.get('type') == 'GENERIC':
                content = data.get('content', '')
                if "Output:\n" in content:
                    file_content = content.split("Output:\n", 1)[1]
                    with open('Views/Home/Index_Extracted_2391.cshtml', 'w', encoding='utf-8') as out:
                        out.write(file_content)
                    print("Extracted successfully!")
        except Exception as e:
            pass
