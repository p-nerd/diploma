package com.shihabmahamud;

interface Humen {
    void introduc();
}

class HumenClass implements Humen {
    String name;
    HumenClass(String name) {
        this.name = name;
    }

    public void introduc() {
        System.out.println("Hello, my name is " + name);
    }
}

public class P14Interface {
    public static void main(String[] args) {
        HumenClass h = new HumenClass("SM");

        h.introduc();
    }
}
