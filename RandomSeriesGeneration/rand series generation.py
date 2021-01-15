from random import randint


def testRandom(UB):
    ABC = []
    c = 1
    for i in range(UB):
        ABC.append(False)

    for i in range(UB):
        n = randint(0, UB-1)
        while ABC[n]:
            c = c + 1
            n = randint(0, UB-1)
        ABC[n] = True
    print("Total count for the generation of", UB, "numbers =", c)\

testRandom(50)