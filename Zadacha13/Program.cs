// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

string number1 = Convert.ToString(number);

if (number1.Length > 2) {
    Console.WriteLine("Третье число " + number1[2]);
}
else {
    Console.WriteLine("Третье число отсуствует");
}
