import json

with open('recovered_dump.txt', 'r', encoding='utf-8') as f:
    s = f.read()

# s is a JSON dumped string of the data object.
data = json.loads(s)
# The output is likely in data['output']
output = data.get('output', '')

with open('Views/Home/Index.cshtml', 'w', encoding='utf-8') as f:
    f.write(output)

print('File written!')
