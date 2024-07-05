package com.shihabmahamud;


class Employee2 {
    String name;
    String company;
    public Employee2(String name, String company) {
        this.name = name;
        this.company = company;
    }

    public void work() {
        System.out.println(name + " is working at " + company);
    }
}

class Programmer2 extends Employee2 {
    String programmingLanguage;

    Programmer2(String name, String company, String programmingLanguage) {
        super(name, company);
        this.programmingLanguage = programmingLanguage;
    }

    @Override
    public void work() {
        System.out.println(name + " is working at " + company + " with " + programmingLanguage + " programming language");
    }

    void code() {
        System.out.println(name + " is coding in " + programmingLanguage);
    }
}

public class P13OverriddenMethod {
    public static void main(String[] args) {
        Programmer2 programmer = new Programmer2("Shihab Mahamud", "Finnext", "PHP");

        programmer.work();
        programmer.code();
    }
}
