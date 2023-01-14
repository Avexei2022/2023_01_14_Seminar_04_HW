// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class GetNum {
    public int CheckInt() {
        int num;
        Console.Write("Введите размер массива (по заданию 8): ");
        int.TryParse(Console.ReadLine(), out num);
        while (num < 1) {
            Console.Write("Число не соответствует условиям задачи, повторите ввод: ");
            int.TryParse(Console.ReadLine(), out num);
        }
        Console.WriteLine();
        return num;
    }
}

class GetArray {
    public int[] GetIntArray(int size) {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = new Random().Next(1, 100);
        }
        return arr;
    } 
}

class PrintArray {
    static void Main() {
        GetNum gn = new GetNum();
        GetArray ga = new GetArray();
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход размер массива
формирует его случайными числами и выводит на экран.");
        Console.WriteLine();
        int[] array = ga.GetIntArray(gn.CheckInt());
        Console.WriteLine($"{String.Join(", ", array)} -> [ {String.Join(", ", array)} ] ");
        Console.WriteLine();
    }
}
