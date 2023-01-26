// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел 
// из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.


// int numberA = new Random().Next(1, 10); //1 2 3 4 ... 9
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);

// void FillArray (int[] collection)
// {
//     int length = collection.Length

// } 


Random rnd = new Random();
int number = rnd.Next(10, 100);

int[] numbers = splitNumbers(number);
int max = maxNum(numbers);
Console.WriteLine(number);
Console.WriteLine(max);

int[] splitNumbers(int num)
{
    int[] pairNumbers = new int[2];
    int num1 = num / 10;
    int num2 = num % 10;
    pairNumbers[0] = num1;
    pairNumbers[1] = num2;
    return pairNumbers;
}

int maxNum(int[] nums)
{
    int max = nums[0];
    if (nums[1] > max)
    {
        max = nums[1];
    }
    return max;
}



// void FillArray (int[] collection)
// {
//     int[] array = newitn [10];
//     Random rnd = new Random();
//     int number = rnd.Next(10, 100);

// }


// Random rnd = new Random();
// int number = rnd.Next(10, 100);

// int[] numbers = splitNumbers(number);
// int max = maxNum(numbers);
// Console.WriteLine(number);
// Console.WriteLine(max);


// int[] splitNumbers(int num)
// {
//     int[] pairNumbers = new int[2];
//     int num1 = num / 10;
//     int num2 = num % 10;
//     pairNumbers[0] = num1;
//     pairNumbers[1] = num2;
//     return pairNumbers;
// }

// int maxNum(int[] nums)
// {
//     int max = nums[0];
//     if (nums[1] > max)
//     {
//         max = nums[1];
//     }
//     return max;
// }