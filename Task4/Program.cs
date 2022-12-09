// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Random randome = new Random();//Штука, позволяющая получить рандомные числа
int[] numerals = new int [8]; //Создали массив на 8 значений
Console.WriteLine(OutputArray(randome));//Вывели результат работ
string OutputArray(Random random)//Функция, позволяющая вывести массив случайных чисел
{
    int[]numerals = new int[8];//Создали массив на 8 значений
    for (int i = 0; i < numerals.Length; i ++)//Цикл по заолнению массива 1 и 0
{
    numerals[i] = randome.Next(0,2);//Запись в ячейку массива рандомного числа от 0 до 1
}
string output;//Создали текст для вывода
return output = string.Join(",", numerals);//Соединили массив в строку, элементы разделены запятой
}
