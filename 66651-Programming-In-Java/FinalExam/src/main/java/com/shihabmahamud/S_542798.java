package com.shihabmahamud;

public class S_542798 {
    public static boolean isPrime(int num)
    {
        if (num <= 1) {
            return false;
        }

        for (int i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }

        return true;
    }

    public static void main(String[] args) {
        int sum = 0;

        for (int i = 1; i <= 10; i++) {
            if (isPrime(i)) {
                System.out.println(i + " is prime");
                sum += i;
            }
        }

        System.out.println("The sum is " + sum);
    }
}
