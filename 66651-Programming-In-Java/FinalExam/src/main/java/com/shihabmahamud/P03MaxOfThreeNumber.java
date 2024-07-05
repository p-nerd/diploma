package com.shihabmahamud;

import java.util.Scanner;

public class P03MaxOfThreeNumber {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.print("Enter number 1: ");
        int num1 = in.nextInt();

        System.out.print("Enter number 2: ");
        int num2 = in.nextInt();

        System.out.print("Enter number 3: ");
        int num3 = in.nextInt();

        if (num1 < num2) {
            if (num3 < num2) {
                System.out.println(num2 + " is largest");
            } else {
                System.out.println(num3 + " is largest");
            }
        } else {
            if (num3 < num1) {
                System.out.println(num1 + " is largest");
            } else {
                System.out.println(num3 + " is largest");
            }
        }
    }
}
