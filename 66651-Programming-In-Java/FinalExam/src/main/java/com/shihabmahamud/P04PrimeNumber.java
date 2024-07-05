package com.shihabmahamud;

public class P04PrimeNumber {
    public static boolean isPrime(int n) {
        for (int i = 2; i < n; i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }


    public static void main(String[] args) {
        for (int i = 1; i <= 100; i++) {
            boolean flag = isPrime(i);
            if (flag){
                System.out.println("Number " + i + " is Prime");
            }
        }
    }
}
