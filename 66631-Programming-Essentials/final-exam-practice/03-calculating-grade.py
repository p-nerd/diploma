mark = int(input("Enter Mark: "))
grade = ""

if mark > 100:
    grade = "Invalid Mark"
elif mark >= 80:
    grade = "A+"
elif mark >= 75:
    grade = "A"
elif mark >= 70:
    grade = "A-"
elif mark >= 65:
    grade = "B+"
elif mark >= 60:
    grade = "B"
elif mark >= 55:
    grade = "B-"
elif mark >= 50:
    grade = "C+"
elif mark >= 45:
    grade = "C"
elif mark >= 40:
    grade = "D"
elif mark >= 0:
    grade = "F"
else:
    grade = "Invalid Mark"

print("The Grade is", grade)
