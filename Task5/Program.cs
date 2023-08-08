// Напишите программу которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void IsSquare(int a, int b)
{
    if( a * a == b)
    {
        Console.WriteLine("Да");
    }
   else
    {
        Console.WriteLine("Нет");
    }
}
int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");
IsSquare(firstNum, secondNum);