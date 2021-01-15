myArr = [["" for i in range(3)] for j in range(5)]
alreadySorted = False

for row in range(5):
    for col in range(3):
        myArr[row][col] = input()

while not alreadySorted:
    alreadySorted = True
    for row in range(4):
        if myArr[row][0] > myArr[row + 1][0]:
            a = myArr[row][0]
            b = myArr[row][1]
            c = myArr[row][2]

            myArr[row][0] = myArr[row + 1][0]
            myArr[row][1] = myArr[row + 1][1]
            myArr[row][2] = myArr[row + 1][2]

            myArr[row + 1][0] = a
            myArr[row + 1][1] = b
            myArr[row + 1][2] = c
            alreadySorted = False

for row in range(5):
    for col in range(3):
        print(myArr[row][col], end="-")
