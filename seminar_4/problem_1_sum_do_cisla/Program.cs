// Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int SumNumbers(int number)
{
    
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int SumGaussNumber (int number)
{
    return (int)(number+1)*(number/2);
}


int number = Prompt("Vvedite cislo");
Console.WriteLine($"Summa cisel ot 1 do {number} = {SumNumbers(number)}");
Console.WriteLine($"Summa cisel ot 1 do {number} po Gaussu = {SumNumbers(number)}");

