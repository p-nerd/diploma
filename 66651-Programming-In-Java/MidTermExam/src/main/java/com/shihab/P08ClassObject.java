package com.shihab;

class People {
    public String name;
    public int age;
    public String type;
}


public class P08ClassObject {
    public static void main(String[] args) {
        People p = new People();
        p.name = "Shihab";
        p.age = 20;
        p.type = "Programmer";

        System.out.println("Name: "+ p.name);
        System.out.println("Age: "+ p.age);
        System.out.println("Type: "+ p.type);
    }
}
