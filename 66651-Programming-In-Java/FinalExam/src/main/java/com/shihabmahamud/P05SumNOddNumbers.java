package com.shihabmahamud;

import java.util.Scanner;

public class P05SumNOddNumbers {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Enter the n: ");
        int n = s.nextInt();

        int sum = 0;

        for (int i = 2; i <= n; i += 2) {
            sum += i;
        }

        System.out.println("The sum is " + sum);
    }
}
