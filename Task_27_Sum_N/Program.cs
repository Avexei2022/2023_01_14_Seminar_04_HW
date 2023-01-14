// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
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
    public void PrntRslt(int num) {
        int result = 0;
        Console.Write($"Сумма цифр в числе {num} -> ");
        for (int num_div = num; num_div >= 1; num_div/=10) {
            result = result + num_div % 10;
        }
        Console.WriteLine($"{result}.");
        Console.WriteLine(); 
    }
}

class FindSum {
    static void Main() {
        int num;
        Console.Clear();
        Console.WriteLine(@"Программа, принимает на вход число
и выдаёт сумму цифр в числе.");
        Console.WriteLine();
        GetNum gn = new GetNum();
        PrintResult pr = new PrintResult();
        pr.PrntRslt(gn.CheckInt());
    }
}