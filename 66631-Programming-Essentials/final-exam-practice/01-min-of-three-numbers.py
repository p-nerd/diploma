a = int(input("Enter first number: "))
b = int(input("Enter first number: "))
c = int(input("Enter first number: "))

smallest = 0

if a < b and a < c:
    smallest = a
elif b < a and b < c:
    smallest = b
elif c < a and c < b:
    smallest = c

print(smallest, "is the smallest of three numbers.")
