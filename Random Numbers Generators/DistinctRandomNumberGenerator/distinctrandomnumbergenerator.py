from random import randint

RT = []
Counter = 1

for i in range(50):
    RT.append(False)

for i in range(50):
    index = randint(0, 49)
    while RT[index]:
        Counter += 1 #Counter = Counter + 1
        index = randint(0, 49)
    RT[index] = True

print("Number of times counter worked is =", Counter)