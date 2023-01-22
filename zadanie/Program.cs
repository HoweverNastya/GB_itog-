//Задача: Написать программу, которая из имеющегося массива  строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Примеры:
// ["привет", "2", "мир", ":-)"] -> ["2", ":-)"]

Console.WriteLine("Введите слова или цифры или символы через пробел: ");
string inputText = Console.ReadLine(); 
string[] stringArray1 = inputText.Split(' ');
string[] stringArray2 = new string[stringArray1.Length];

// string[] stringArray1 = new string[5] {"privet", "22", "hi", ")))", "bonjour"}; //- если самому задать массив
// string[] stringArray2 = new string[stringArray1.Length];

void CheckArray(string[] stringArray1, string[] stringArray2)
{
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
        if (stringArray1[i].Length <= 3)
        {
            stringArray2[count] = stringArray1[i];
            count++;
        }
    }
}
    
void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

CheckArray(stringArray1, stringArray2);
PrintArray(stringArray2);
