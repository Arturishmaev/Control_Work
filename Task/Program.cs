// Задача: Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна трем символам
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//при решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


System.Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[n];
System.Console.WriteLine("Введите названия строк: ");

for (int i = 0; i < firstArray.Length; i++)
{
    firstArray[i] = Console.ReadLine();
}

System.Console.WriteLine("Первый массив:");
System.Console.Write("[" + string.Join(", ", firstArray) + "]");


string[] secondArray = new string[firstArray.Length];

for (int i = 0; i < secondArray.Length; i++)
{
    int count = 0;
    if (firstArray[i].Length <= 3)
    {
        secondArray[count] = firstArray[i];
        count++;
    }
}
System.Console.WriteLine("");
System.Console.WriteLine("Массив отсортированый:");
System.Console.Write("[" + string.Join(", ", secondArray) + "]");
