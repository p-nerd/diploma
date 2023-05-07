package com.shihab;

import java.util.Scanner;

public class P01Switch {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        float total;
        System.out.print("Enter the total mark: ");
        total = s.nextFloat();

        String mark = "";

        switch((int) (total / 10)) {
            case 8:
                mark = "A+";
                break;
            case 7:
                mark = "A";
                break;
            case 6:
                mark = "A-";
                break;
            case 5:
                mark = "B";
                break;
            case 4:
                mark = "C";
                break;
            default:
                mark = "Fail";
        }
        System.out.println(mark);
    }
}
