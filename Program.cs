//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

void FndNumber(string CurrentNumber)
{
    Console.WriteLine("Задача 13");
    if (CurrentNumber.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Третья цифра: " + CurrentNumber[2]);   
    }
}
Console.WriteLine("_________________ ");
string Number = "1235";
FndNumber(Number);
Console.WriteLine("_________________ ");
string Number2 = "22";
FndNumber(Number2);
Console.WriteLine("_________________ ");
string Number3 = "866";
FndNumber(Number3);
Console.WriteLine("_________________ ");



//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int day = 1;
ChooseDay();
day = 6;
ChooseDay();
Console.WriteLine();
Console.WriteLine();
void ChooseDay()
{
    Console.WriteLine("_________________ ");
    Console.WriteLine("Задача 15");
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной день!!!");
    }
    else
    {
       Console.WriteLine("Это рабочий день"); 
    }
}