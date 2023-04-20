"""
function to add from 1 upto nth number received as parameter
"""

def addNumbers(val): # Time complexity O(n)
    x = 0
    for i in range(1,val+1):
        x = x + i
    return x

def addNumbers2(val): 
    x = val
    return int(x * (x + 1) / 2) # Time complexity O(1)

n = int(input("Enter number to add upto: "))
print(f"Resuly of addition from 1 to {n} is {addNumbers2(n)}.")
