// Напишите программу которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool Test(int number)
{
return number % 7 == 0 && number % 23 == 0;
}
int num = InputNum("Введите число: ");

Console.WriteLine(Test(num));
