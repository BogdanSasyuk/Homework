
Console.Write("Введите число в десятичной системе: ");
var decNum = int.Parse(Console.ReadLine());
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
   