from random import randint, random

while True:
    # a = random() # You can not generate random integer numbers without a limit but you can generate random float numbers
    # print(a)

    # a = randint(0, 6)  # It is necessary to tell both the LB and UB with randint()
    #print(a)  # The Ub is included in randint unlike vb's Next()

    a = randint(5, 11)
    print(a)

    input()