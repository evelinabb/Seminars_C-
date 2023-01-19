//Напишите программу, которая будет выдавать название дня недели 
//по заданному номеру. 3 -> Среда 5 -> Пятница

Console.Write("Введите номер дня недели > ");
int dayofweek = Convert.ToInt32(Console.ReadLine());

if (dayofweek < 8 && dayofweek > 0)
{
    string[] weeks = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
    Console.WriteLine(weeks[dayofweek - 1]);
}
else
    Console.WriteLine("Это не день недели");
