package com.shihabmahamud;

public class S_542798X {
    public static boolean isPrime(int num)
    {
        if (num <= 1) {
            return false;
        }

        for (int i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }

        return true;
    }

    public static void main(String[] args) {
        int []arr = new int[10];

        for (int i = 1, j = 0; i <= 10; i++, j++) {
            if (isPrime(i)) {
                System.out.println(i + " is prime");
                arr[j] = i;
            }
        }

        int start = 0;
        int end = arr.length - 1;
        while (start < end) {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }

        System.out.println("Reversed arr:");
        for (int num : arr) {
            if (num != 0) {
                System.out.print(num + " ");
            }
        }
    }
}
