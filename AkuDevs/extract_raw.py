import json

found = False
with open(r'C:\Users\Samet\.gemini\antigravity\brain\73987e31-9aa7-47e3-8e4b-b41a9d82fbdc\.system_generated\logs\transcript_full.jsonl', 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('type') == 'GENERIC':
                content = data.get('content', '')
                if 'class="relative min-h-screen w-full flex items-center justify-center overflow-hidden"' in content:
                    print(f"Found in step {data.get('step_index')}")
                    if "Total Lines:" not in content and "Output:\n" in content:
                        print("It looks like raw output!")
                        file_content = content.split("Output:\n", 1)[1]
                        with open('Views/Home/Index_Raw_Full.cshtml', 'w', encoding='utf-8') as out:
                            out.write(file_content)
                        found = True
        except Exception as e:
            pass
