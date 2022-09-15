def area_of_rectangle(length, width):
    rectangle_area = length * width
    return rectangle_area


length = int(input("Enter the value of length: "))
width = int(input("Enter the value of width: "))

area = area_of_rectangle(length, width)

print("Area of Rectangle is = ", area)
