def displayOptions():
    print("1. Add")
    print("2. Subtract")
    print("3. Multiply")
    print("4. Divide")
    print("5. Exit")
    return


def addData(x, y):
    z = x + y
    return z


def subData(x, y):
    z = x - y
    return z


def mulData(x, y):
    z = x * y
    return z


def divData(x, y):
    z = x / y
    return z


choice = 0
while not choice == 5:
    displayOptions()
    choice = 0
    while not 1 <= choice <= 5:
        choice = int(input("Enter choice (1..5) "))

    if choice != 5:
        first = int(input("Enter first value: "))

        second = int(input("Enter second value: "))

        if choice == 1: result = addData(first, second)
        if choice == 2: result = subData(first, second)
        if choice == 3: result = mulData(first, second)
        if choice == 4: result = divData(first, second)

        print("Your result is =", result)