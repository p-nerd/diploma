package com.shihabmahamud;

import java.util.Scanner;

public class P01Circle {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.print("Enter the radius: ");
        double r = in.nextDouble();

        double area = Math.PI * r * r;

        System.out.println("Area of Circle is: " + area);
    }
}
