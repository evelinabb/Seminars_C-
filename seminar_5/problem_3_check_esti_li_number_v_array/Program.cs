// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateNumbersArray()
{
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 1001);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.Write(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int InputData(string message)
{
    Console.Write(message + "> ");
    return int.Parse(Console.ReadLine());
}


bool Check(int[] array, int inputNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == inputNumber)
        {
            return true;
        }
    }
    return false;
}



int[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Massiv: ");
int number = InputData("Vvedite cislo");
if (Check(numbersArray, number))
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}
