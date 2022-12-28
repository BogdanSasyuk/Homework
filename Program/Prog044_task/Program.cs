// Доп. задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число в десятичной системе: ");
var decNum = Convert.ToInt32(Console.ReadLine());
var binNum = DecToBin(decNum);

string DecToBin(int decNum)
{
    var binNum = string.Empty;
    while (decNum > 0)
    {
        binNum = (decNum % 2) + binNum;
        decNum /= 2;
    }
    return binNum;
}
Console.WriteLine("{0} => {1}", decNum, binNum);
   