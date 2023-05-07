package com.shihab;

import java.util.Scanner;

public class P12TriangleArea {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.print("Enter base: ");
        int b = s.nextInt();

        System.out.print("Enter height: ");
        int h = s.nextInt();

        double area = 1/2.0 * b * h;

        System.out.println("Area is: " + area);
    }
}
