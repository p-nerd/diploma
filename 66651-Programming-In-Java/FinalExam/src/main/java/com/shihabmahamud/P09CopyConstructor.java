package com.shihabmahamud;

public class P09CopyConstructor {
    int a;
    int b;

    public P09CopyConstructor(int a, int b) {
        this.a = a;
        this.b = b;
    }

    public P09CopyConstructor(P09CopyConstructor o) {
        this.a = o.a;
        this.b = o.b;
    }

    public int sum() {
        return a + b;
    }

    public static void main(String[] args) {
        P09CopyConstructor cal = new P09CopyConstructor(2, 3);
        System.out.println(cal.sum());

        P09CopyConstructor cal2 = new P09CopyConstructor(cal);
        System.out.println(cal2.sum());
    }
}
