package com.shihab;

import java.util.Scanner;

public class P02LargestOfThreeNumber {
    public static void main(String[] args) {
        int a, b, c;

        Scanner s = new Scanner(System.in);

        System.out.println("Enter first number: ");
        a = s.nextInt();

        System.out.println("Enter second number: ");
        b = s.nextInt();

        System.out.println("Enter third number: ");
        c = s.nextInt();

        int largest = a;

        if (b > largest) {
            largest = b;
        }
        if (c > largest) {
            largest = c;
        }

        System.out.println("The largest number: " + largest);
    }
}
