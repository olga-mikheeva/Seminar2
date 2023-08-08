// Напишите программу которая будет принимать на вход 2 числа и выводить является ли второе число кратным первому.
// Если число2 не кратно числу1 то программа выводит остаток от деления.

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool Multiplicity(int firstNum, int secondNum)
{
    if(firstNum % secondNum == 0)
        return true;
    else 
        return false;
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool check = Multiplicity(firstNum, secondNum);
Console.WriteLine(check);



