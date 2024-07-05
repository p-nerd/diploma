package com.shihabmahamud;

public class P08Constructor {
    int a;
    int b;

    public P08Constructor(int a, int b) {
        this.a = a;
        this.b = b;
    }

    public int sum() {
        return a + b;
    }

    public static void main(String[] args) {
        P08Constructor cal = new P08Constructor(2, 3);
        System.out.println(cal.sum());
    }
}
