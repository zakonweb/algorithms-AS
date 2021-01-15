ClassID = int(input(""))

if ClassID >= 1 and ClassID <= 50:
    print("1")
else:
    if ClassID >= 51 and ClassID <= 100:
        if ClassID % 2 == 0:
            print("2A")
        else:
            print("2B")