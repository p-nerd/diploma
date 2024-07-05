package com.shihabmahamud;

class Human {
    String name;
    public Human(String name) {
        this.name = name;
    }

    public void introduce() {
        System.out.println("Hello my name is " + name);
    }
}

class Employee extends Human {
    String company;
    public Employee(String name, String company) {
        super(name);
        this.company = company;
    }

    public void work() {
        System.out.println(name + " is working at " + company);
    }
}

class Programmer extends Employee {
    String programmingLanguage;

    Programmer(String name, String company, String programmingLanguage) {
        super(name, company);
        this.programmingLanguage = programmingLanguage;
    }

    void code() {
        System.out.println(name + " is coding in " + programmingLanguage);
    }
}

public class P12MultiLevelInheritance {
    public static void main(String[] args) {
        Programmer programmer = new Programmer("Shihab Mahamud", "Finnext", "PHP");

        programmer.introduce();
        programmer.work();
        programmer.code();
    }
}
