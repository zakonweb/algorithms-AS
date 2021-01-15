def isDivisible(x, y):
    if x % y == 0:
        return True
    else:
        return False
    # Return If(x MOD y = 0, True, False)


print(isDivisible(int(input()), int(input())))