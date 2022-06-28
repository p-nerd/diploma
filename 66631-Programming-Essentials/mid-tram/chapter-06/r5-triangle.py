import math
a = int(input())
b = int(input())
c = int(input())

if (a + b) > c and (b + c) > a and (c + a) > b:
    s = (a + b + c) / 2
    area = math.sqrt(s * (s - a) * (s - b) * (s - c))
    print(area)
else:
    print("Triangle is not Possible")
    