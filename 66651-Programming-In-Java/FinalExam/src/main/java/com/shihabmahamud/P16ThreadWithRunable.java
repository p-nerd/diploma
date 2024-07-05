package com.shihabmahamud;

class Hi2 implements Runnable {
    public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println("Hi");
            try {
                Thread.sleep(1000);
            } catch (Exception e) {
                
            }
        }
    }
}

class Hello2 implements Runnable  {
    public void run() {
        for (int i = 0; i < 5; i++) {
            System.out.println("Hello");
            try {
                Thread.sleep(1000);
            } catch (Exception e) {

            }
        }
    }
}

public class P16ThreadWithRunable {
    public static void main(String[] args) {
        Hi2 hi = new Hi2();
        Hello2 hello = new Hello2();

        Thread t1 = new Thread(hi);
        Thread t2 = new Thread(hello);

        t1.start();
        t2.start();
    }
}
