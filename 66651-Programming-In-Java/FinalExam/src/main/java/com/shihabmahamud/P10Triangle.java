package com.shihabmahamud;

import java.util.Scanner;

public class P10Triangle {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.print("Enter base: ");
        double b = s.nextDouble();

        System.out.print("Enter height: ");
        double  h = s.nextDouble();

        double area = 1/2.0 * b * h;
        System.out.println("The area of Triangle: " + area);
    }
}
