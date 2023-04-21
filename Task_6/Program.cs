//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//Пример:
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine()!);

if (number%2 == 0)
{
    Console.Write("An even number" );
}
else
{
    Console.Write("An odd number");
}