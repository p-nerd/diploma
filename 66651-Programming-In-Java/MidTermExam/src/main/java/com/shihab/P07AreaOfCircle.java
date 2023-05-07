package com.shihab;

import java.util.Scanner;

public class P07AreaOfCircle {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Enter the radius: ");
        double r = s.nextDouble();
        double area = Math.PI * r * r;

        System.out.println("Area of Circle is: " + area);
    }
}
