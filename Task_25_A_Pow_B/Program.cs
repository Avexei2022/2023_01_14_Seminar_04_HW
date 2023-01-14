// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

class GetNum {
    public int CheckInt() {
        int num;
        Console.Write("Введите число: ");
        int.TryParse(Console.ReadLine(), out num);
        while (num < 1) {
            Console.Write("Число не соответствует условиям задачи, повторите ввод: ");
            int.TryParse(Console.ReadLine(), out num);
        }
        Console.WriteLine();
        return num;
    }
}

class PrintResult {
    public void PrntRslt(int numA, int numB) {
        double result = numA;
        Console.Write($"число {numA} в степени {numB} -> ");
        for (int count = 2; count <= numB ; count++) {
            result = result * numA;
        }
        Console.WriteLine($"{result}.");
        Console.WriteLine(); 
    }
}

class FindDegree {
    static void Main() {
        int numA;
        int numB; 
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход два числа (А и В)
и возводит число А в натуральную степень В.");
        Console.WriteLine();
        GetNum gn = new GetNum();
        PrintResult pr = new PrintResult();
        Console.Write("А -> ");
        numA = gn.CheckInt();
        Console.Write("B -> ");
        numB = gn.CheckInt();        
        pr.PrntRslt(numA, numB);
    }
}
