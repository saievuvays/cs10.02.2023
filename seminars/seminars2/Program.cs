/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/* Console.Write("Введи трёхзначное число: ");
int num1 = Console.ReadLine();
string str = Convert.ToString(num1);
Console.WriteLine("вторая цифра этого числа -> "+str[1]); */

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/* Console.Write(" Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num1);

if (str.Length < 3){
    Console.WriteLine("третьей цифры нет");
}else {
    Console.WriteLine(str[2]);
} */

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/* while (true){
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 6 || num1 == 7){
    Console.WriteLine("да");
} else{
    Console.WriteLine("нет");
}
} */
