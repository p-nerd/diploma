a = int(input())
b = int(input())
c = int(input())

if a < b:
    if a < c:
        print("Smallest value is ", a)
    else:
        print("Smallest value is ", c)
else:
    if b < c:
        print("Smallest value is ", b)
    else:
        print("Smallest value is ", c)
