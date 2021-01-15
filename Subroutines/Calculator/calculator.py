def ADD(v1, v2):
    n = v1 + v2
    return n


def SUBT(v1, v2):
    n = v1 - v2
    return n


def DIVI(v1, v2):
    n = v1 / v2
    return n


def MUL(v1, v2):
    n = v1 * v2
    return n



X = int(input("Enter first value: "))

Y = int(input("Enter second value: "))

print("Press 1 to ADD.")
print("Press 2 to SUB.")
print("Press 3 to MUL.")
print("Press 4 to DIV.")
print("Press 5 to Exit.")
op = int(input())

if op == 1:
    myAns = ADD(X, Y)

if op == 2:
    myAns = SUBT(X, Y)

if op == 4:
    myAns = DIVI(X, Y)

if op == 3:
    myAns = MUL(X, Y)

print("Answer is =", myAns)
