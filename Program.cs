//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("введите первое число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите второе число");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1>num2){
//Console.WriteLine(num1 + "больше чем" + num2);

//}else{
//    Console.WriteLine(num2 + "больше чем" + num2);
//}

//Задача 4:Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/* Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (num1 > num2){
    result = num1;
}
if (num1 > num3){
    result = num1;
}
if (num2 > num1){
    result = num2;
}
if (num2 > num3){
    result = num2;
}
if (num3 > num1){
    result = num3;
}
if (num3 > num2){
    result = num3;
}

Console.WriteLine("Результат " + result); */


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


/* Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2==0){
    Console.WriteLine(num + "четное");

} */

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}

if (not)
{
Console.WriteLine("Нет чётных чисел!");
}