def adder():
    print("Fake Adder routine. Press Key.")


def prod():
    print("Fake product routine. Pres Key.")


def subtract():
    print("Fake subtraction routine. Press Key.")


def div():
    print("Fake division routine. Press Key.")


choice = 0
while not choice == 5:
    choice = 0
    while choice < 1 or choice > 5:
        print("1. Addition")
        print("2. Multiplication")
        print("3. Subtraction")
        print("4. Division")
        print("5. Exit")

        choice = int(input())

        if choice == 1: adder()
        if choice == 2: prod()
        if choice == 3: subtract()
        if choice == 4: div()