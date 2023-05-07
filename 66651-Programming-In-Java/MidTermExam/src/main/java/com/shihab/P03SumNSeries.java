package com.shihab;

import java.util.Scanner;

public class P03SumNSeries {
    public static void main(String[] args) {
        int n;

        Scanner s = new Scanner(System.in);

        System.out.print("Enter the n: ");
        n = s.nextInt();

        int sum = 0;

        for (int i = 2; i < n; i += 2) {
            sum += i;
        }

        System.out.println("The sum is = " + sum);
    }
}
