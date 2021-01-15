myList = []
NoMoreSwaps = False

for index in range(7):
    x = int(input("Enter a number: "))
    myList.append(x)

MaxIndex = 7
n = MaxIndex - 1
while not NoMoreSwaps:
    NoMoreSwaps = True
    for j in range(n):
        if myList[j] > myList[j+1]:
            Temp = myList[j]
            myList[j] = myList[j+1]
            myList[j+1] = Temp
            NoMoreSwaps = False
    n = n - 1
for index in range(7):
    print(myList[index],end=" ")