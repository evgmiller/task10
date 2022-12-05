// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите число: ");
int number =  int.Parse(Console.ReadLine()!);
string Number= Convert.ToString(number);
int [] array= new int[Number.Length];
int i;
for (i=0; i<Number.Length; i++)
{
    array[i]= Convert.ToInt32(Number[i].ToString());
}
Console.Write(array[1]);