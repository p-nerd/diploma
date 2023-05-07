package com.shihab;

public class P06FibonacciSeries {
    public static void main(String[] args) {
        int a = 0, b = 1;

        System.out.println(a);
        System.out.println(b);
        for (int i = 2; i <= 10; i++) {
            int tmp = a;
            a = b;
            b = tmp + b;

            System.out.println(b);
        }
    }
}
