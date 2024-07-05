package com.shihabmahamud;

class Hi3 implements Runnable {
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

class Hello3 implements Runnable  {
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

public class P17ThreadSynchronization {
    public static void main(String[] args) throws InterruptedException {
        Hi3 hi = new Hi3();
        Hello3 hello = new Hello3();

        Thread t1 = new Thread(hi);
        Thread t2 = new Thread(hello);

        t1.start();
        t2.start();

        t1.join();
        t2.join();

        System.out.println("Here");
    }
}
