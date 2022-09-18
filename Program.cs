// Задача 2. Написать программу, которая принимает
// на вход 2 числа и выдает какое из них наибольшее,
// а какое наименьшее.

Console.WriteLine("Введите два числа : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("{0} наибольшее число", a);
}
else
{
    Console.WriteLine("{0} наибольшее число ", b);
}

