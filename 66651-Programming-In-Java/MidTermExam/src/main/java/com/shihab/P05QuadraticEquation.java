package com.shihab;

import java.util.Scanner;

public class P05QuadraticEquation {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Enter the value of a: ");
        double a = s.nextDouble();

        System.out.println("Enter the value of b: ");
        double b = s.nextDouble();

        System.out.println("Enter the value of c: ");
        double c = s.nextDouble();

        double d = b * b - 4.0 * a * c;

        if (d == 0.0) {
            double r1 = -b / (2.0 * a);

            System.out.println("The root is " + r1);
        }
        else if (d > 0.0) {
            double r1 = (-b) + Math.pow(d, 0.5) / (2.0 * a);
            double r2 = (-b) - Math.pow(d, 0.5) / (2.0 * a);

            System.out.println("The roots are " + r1 + " and " + r2);
        }
        else {
            System.out.println("Roots are not real.");
        }

    }
}
