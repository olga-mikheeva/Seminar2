// Написать программу которая выводит случайно трехзначное число и удаляет вторую цифру этого числа
// 123 -> 13
// 523 -> 53


//523 % 10 = 3
//523 / 100 = 5
//5 * 10 + 3 = 53 (чтобы получить из количества дестятков сами десятки умножим 1 на 10 и прибавим количество единиц, их три)

int DelSecondDigit(int number)

{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int result = (firstDigit * 10 + secondDigit);
    return result;
}
int randNumber = new Random().Next(100, 1000);


Console.WriteLine($"{randNumber} -> {DelSecondDigit(randNumber)}");