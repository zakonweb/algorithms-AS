def Bubblesort(Array, Length):
    for I in range(Length - 1, 0, -1):  # last element of array does'nt get sorted
        for J in range(I):  # -1
            if Array[J] > Array[J + 1]:  # Compare neighboring elements
                Temp = Array[J]
                Array[J] = Array[J + 1]
                Array[J + 1] = Temp


Array = []
for count in range(10):
    x = int(input())
    Array.append(x)

Bubblesort(Array, 10)

for count in range(10):
    print(Array[count])