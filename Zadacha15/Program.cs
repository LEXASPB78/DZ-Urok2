// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Week (int dayNumber) {
    if (dayNumber > 7 || dayNumber < 1){
Console.WriteLine("Введите день недели от 1 до 7");
    }
        else if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine("Выходной");
        }
            else Console.WriteLine("Не выходной");
}
Week(dayNumber);
