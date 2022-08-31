// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string ReversString(string str)
{
     string result = String.Empty;
    string newstr = str;
    for (int i = 0; i < str.Length; i++)
    {
        result += str[str.Length - 1 - i]; 
    }     
    return result;
 }
var input = Console.ReadLine();
string str = ReversString(input);
Console.WriteLine(str);
if(input == str)
{
Console.WriteLine("палиндром"); 
}
 else
 {
   Console.WriteLine("Не палиндром"); 
 }
