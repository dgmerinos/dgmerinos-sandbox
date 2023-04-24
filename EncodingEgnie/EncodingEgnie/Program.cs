// See https://aka.ms/new-console-template for more information
using System.Text;

string Message = "ABC00Ñ4451";
Encoding iso = Encoding.GetEncoding("ISO-8859-1");

Encoding utf8 = Encoding.UTF8;
byte[] utfBytes = utf8.GetBytes(Message);
Console.WriteLine(Convert.ToHexString(utfBytes));
Console.WriteLine("-----------");
byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
2

Console.WriteLine(Message);
Console.WriteLine(Convert.ToHexString(isoBytes));


