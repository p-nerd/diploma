package com.shihabmahamud;

public class P07MethodOverloading {
    public static int sum(int a, int b) {
        return a + b;
    }
    public static int sum(int a, int b, int c) {
        return a + b + c;
    }

    public static void main(String[] args) {
        int s1 = sum(1, 3);
        int s2 = sum(5, 3, 3);

        System.out.println(s1);
        System.out.println(s2);
    }
}
