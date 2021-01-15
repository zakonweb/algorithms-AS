def Addition(a, b):
    x = a + b
    print("Addition", a, "+", b, "=", x)
    input()


def Multiply(m1, m2):
    x = m1 * m2
    return x


choice = 0
while not choice == 5:
    print("1. Add")
    print("2. Subtract")
    print("3. Multiply")
    print("4. Divide")
    print("5. Exit")

    choice = 0
    while not 1 <= choice <= 5:
        choice = int(input("Enter your choice (1..5) : "))

    if choice != 5:
        valA = int(input("Input first value: "))
        valB = int(input("Input second value: "))

    if choice == 1: Addition(valA, valB)
    if choice == 3:
        x = Multiply(valA, valB)
        print("Multiply", valA, "*", valB, "=", x)
        input()