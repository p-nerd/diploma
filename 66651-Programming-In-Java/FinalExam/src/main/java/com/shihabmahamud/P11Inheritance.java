package com.shihabmahamud;

class Animal {
    String name;
    public void cat() {
        System.out.println("I am cat");
    }
}

class Dog extends Animal {
    public void display() {
        System.out.println("My name is " + name);
    }
}

public class P11Inheritance {
    public static void main(String[] args) {
        Dog dog = new Dog();

        dog.name = "Tommy";
        dog.display();

        dog.cat();
    }
}
