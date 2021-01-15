def EggsIntoBoxes(NumberOfEggs):

    NumberOfBoxes = NumberOfEggs // 6
    EggsLeftOver = NumberOfEggs % 6
    return [NumberOfBoxes, EggsLeftOver]


NOE = int(input("Enter Number of Eggs: "))
list1 = EggsIntoBoxes(NOE)

print("Number of eggs:", NOE)
print("Number of full boxes:", list1[0])
print("Number of eggs left over: ", list1[1])
