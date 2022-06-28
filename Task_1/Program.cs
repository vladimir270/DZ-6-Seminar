// Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввел пользователь 


int [] FillArray() // Создание массива пользователем
{
    Console.WriteLine("Введите размер массива");
    int A = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [A];
    for (int i = 0; i < A; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void PrintArray(int[] array) // Метод который выводи на экран массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }
    Console.WriteLine();
}

void Zero (int [] array)  // Метод который считает кол положительных чисел 
{
    int N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            N = N + 1;
        }
       
        else 
        {
            N = N + 0;
        }
    } Console.WriteLine($"Колличество положительных чисел = {N} ");

}

int [] Mas = FillArray();

PrintArray(Mas);

Zero(Mas);
