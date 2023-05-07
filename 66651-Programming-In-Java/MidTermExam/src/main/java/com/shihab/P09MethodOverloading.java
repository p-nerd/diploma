package com.shihab;

public class P09MethodOverloading {
    public static int sum(int a, int b) {
        return a + b;
    }
    public static int sum(int a, int b, int c) {
        return a + b + c;
    }

    public static void main(String[] args) {
        int s1 = sum(1, 2);
        int s2 = sum(1, 2, 3);

        System.out.println(s1);
        System.out.println(s2);
    }
}
