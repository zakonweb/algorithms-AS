def Bubble(TBS, UB):
    wasSwap = False
    for j in range(UB-1,0,-1):
        wasSwap = False
        a = 0
        for i in range(j):
            a = a + 1
            if TBS[i+1] < TBS[i]:
                wasSwap = True
                Temp = TBS[i]
                TBS[i] = TBS[i+1]
                TBS[i+1] = Temp
        if not wasSwap:
            break
    print("No. of loops:", a)


thisArr = []

for i in range(5):
    x = input()
    thisArr.append(x)

Bubble(thisArr, 5)

for i in range(5):
    print(thisArr[i])