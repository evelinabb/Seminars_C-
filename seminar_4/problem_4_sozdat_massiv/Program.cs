// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;

}

void PrintArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
}

int[] massiv = CreateArray(8);
PrintArray(massiv);