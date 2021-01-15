def isEmailValid(Email):
    atCounter = 0
    for a in Email:
        if a == "@": atCounter = atCounter + 1

    if atCounter > 1 or Email[0:1] == "@" or Email.find("@") > len(Email) - 3:
        return False
    else:
        return True

print(isEmailValid(input()))