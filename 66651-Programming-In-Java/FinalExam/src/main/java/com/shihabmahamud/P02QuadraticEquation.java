package com.shihabmahamud;

import java.util.Scanner;

public class P02QuadraticEquation {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.print("Enter the value of a: ");
        double a = in.nextDouble();

        System.out.print("Enter the value of b: ");
        double b = in.nextDouble();

        System.out.print("Enter the value of c: ");
        double c = in.nextDouble();

        double d = b * b - 4.0 * a * c;

        if (d > 0.0) {
            double r1 = (-b) + Math.pow(d, 0.5) / (2.0 * a);
            double r2 = (-b) - Math.pow(d, 0.5) / (2.0 * a);

            System.out.println("The roots are " + r1 + " and " + r2);
        } else if (d == 0.0) {
            double r1 = -b / (2.0 * a);

            System.out.println("The root is " + r1);
        } else {
            System.out.println("Roots is not real.");
        }
    }
}
