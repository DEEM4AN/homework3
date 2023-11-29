using System;
// public class Task1 {
//     public static void Main(string [] args) {
    
//     int size = 10;
//     Random rnd = new Random();
//     int[] array = new int[size];
    
//     for (int i = 0; i < size; i++) 
//     {   
//         array[i] = rnd.Next(1, 100);
//     }
//     Console.WriteLine("количество чисел от 20 до 90: " + numberSegments(array));
//     foreach (var item in array)
//     {
//         Console.Write(item + " ");
//     }

//     }
//      public static int numberSegments (int [] arr) {
//         int k = 0;
//         for(int i = 0; i < arr.Length; i++) {
//             if (arr[i] >= 20 && arr[i] <= 90) {
//                 k++;
//             }
//         }
//         return k;
//     }
// }

// public class Task2 {
//     public static void Main(string [] args) {
//         int size = 10;
//         int[] array = new int[size];
//         Random rnd = new Random();
//         int k = 0;
//         for (int i = 0; i < size; i++)
//         {
//             array[i] = rnd.Next(1, 100);
//             if (array[i] % 2 == 0) {
//                 k++;
//             }
//         }

//         Console.WriteLine("количество чётных чисел равно " + k);
//         foreach (var item in array)
//         {
//             Console.Write(item + " ");
//         }
//     }
// }

public class Task3 {
    public static void Main (string[] args) {
        double[] array = {1.5, 4.7, 3.9, 2.34, 9.31};
        double min = 99999999;
        double max = 0;
        double diff = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) {
                min = array[i];
            } else if (array[i] > max) {
                max = array[i];
            }
        }
        diff = max - min;

        Console.WriteLine("Разница между самым большим и самым маленьким числом: " + diff);
    }
}
