chars = dict()
nl, tab ,sp = 0, 0, 0

with open("jquery.js") as jq:
    for line in jq:
        for char in line:
            if char == '\t':
                tab += 1
                continue
            if char == ' ':
                sp += 1
                continue
            if char == '\n':
                nl += 1
                continue

            if char in chars:
                chars[char] += 1
            else:
                chars[char] = 1

for item in sorted(chars.items(), key=lambda a: a[1], reverse=1):
    print(f"{item[0]}: {item[1]}")
print(f"space: {sp}, tab: {tab}, newline: {nl}")
input()
