import sys


def choicesDisplay():
    print("0. Quit program.\n1. Choose 1 for the program option 1.\n2. Choose 2 for the program option 2.\n3. Choose 3 for the program option 3.")


def Choice1():
    print("Procedure 1 is called for choice 1")


def Choice2():
    print("Procedure 2 is called for choice 2")


def Choice3():
    print("Procedure 3 is called for choice 3")


choice = 4
while not choice == 0:  # Repeatedly show menu until user opts to get out by pressing 0
    choicesDisplay()
    choice = 4
    while not 0 <= choice <= 3:  # Choice input validation
        choice = int(input("Enter your choice (0...3): "))
        if choice < 0 or choice > 3:
            print("Invalid choice. Enter between 0..3")
            input()
    if choice == 0:
        sys.exit()
    elif choice == 1:
        Choice1()
        input()
    elif choice == 2:
        Choice2()
        input()
    elif choice == 3:
        Choice3()
        input()
    else:
        print("Invalid choice. Enter between 0..3")