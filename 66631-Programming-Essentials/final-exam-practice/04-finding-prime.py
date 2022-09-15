def is_prime(n: int) -> bool:
    if n == 1:
        return False
    if n == 2:
        return True
    for x in range(3, n):
        if n % x == 0:
            return False
    return True


primes_list = []

for i in range(1, 101):
    if is_prime(i) == True:
        primes_list.append(i)

print("The primes are ", primes_list)
