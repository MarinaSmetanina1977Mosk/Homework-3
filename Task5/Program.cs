// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(SumNumerals(number));
//
//int SumNumerals(int number)// объявляем функцию и вводим число
//{
//    int sum = 0;// вводим сумму с типом возвращаемго значения int
//    for (int i = 1; i <= number; i++)
//    {
//       sum += i;
//   }
//    return sum;
//}
Console.Write("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
int counter = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;
for (int i = 0; i < counter; i++){
advance = numberN - numberN % 10;
result = result + (numberN - advance);
numberN = numberN / 10;
}
return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
