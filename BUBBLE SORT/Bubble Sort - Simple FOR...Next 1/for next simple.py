didWork = False
n = [2, 1, 3, 5, 6, 7, 8]
x=0

for b in range(6):
    didWork = False

    for c in range(6):
        x = x + 1

        if n[c] > n[c+1]:
            temp = n[c]
            n[c] = n[c+1]
            n[c+1] = temp

            didWork = True
    if didWork == False: break

for c in range(7):
    print(n[c])

print("")
print("Counter worked", x, "times.")