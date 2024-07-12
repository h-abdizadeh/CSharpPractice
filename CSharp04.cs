using static System.Console;

//See https://aka.ms/new-console-template for more information
///*Console.*/WriteLine("Hello, World!");

//1
//WriteLine(5 + 3);
//WriteLine("5+3");
//WriteLine("5" + "3");
//WriteLine(5 + "3");
//WriteLine(7 - 3);
//WriteLine(8 * 2);
//WriteLine(10 / 5);
//WriteLine(7 / 3);
//WriteLine(7.0 / 3);
//WriteLine(7 / 3.0);
//WriteLine(10 % 5);
//WriteLine(7 % 3);

//2
//WriteLine(5 > 2);
//WriteLine(8 < 5);
//WriteLine(5 >= 5);
//WriteLine(5 >= 6);
//WriteLine("ali" == "ali");
//WriteLine("ali" == "Ali");
//WriteLine(5 != 7);

//3
//WriteLine("c" + "sharp");
//WriteLine("c" + "s");
//WriteLine('c' + 's');
//WriteLine('-' + '=');
//WriteLine((char)('-' + '='));
//WriteLine((char)36);
//WriteLine((int)'?');
//WriteLine((int)'7');

//4
//string name = "farda";
//int number = 18;
//char ch = 'a';
//double d = 2.5;
//WriteLine(name + number);

//bool result = number > 10;
//WriteLine(result);

//float flt = 3.5f;
//decimal dcml = 7.25m;

//5
//int n;
//n = 4 + 5;
//var number = 12;
////number = "farda";//error
//var name = "farda";
//var result = number > n;
//WriteLine(result);

//6
//dynamic n = 15;
//WriteLine(n+5);
//n = "farda";
//WriteLine(n+5);

//7
//const string password = "abc123";
////password = "asdas";//error
//Write("enter password : ");
//string userPass = ReadLine();

//WriteLine(password == userPass);

//8
//Write("enter number : ");
////var num = ReadLine();//string
//int num = int.Parse(ReadLine());
//WriteLine(num + num);

//9
//int n = 5;
////n = 2.5;//error
//n = (int)2.5;
//WriteLine(n);

//int a = 7, b = 3;
//WriteLine(a/b);
//WriteLine((float)a / b);
//WriteLine(a/(double)b);

//10
//Write("enter number 1 : ");
//var a = double.Parse(ReadLine());

//Write("enter number 2 : ");
//var b = Convert.ToDouble(ReadLine());

////WriteLine(a + b);
////WriteLine(a + "+" + b + "=" + a + b);
////WriteLine(a + "+" + b + "=" + (a + b));
//WriteLine($"{a} + {b} = {a + b}");
//WriteLine(a - b);
//WriteLine(a * b);
//WriteLine(a / b);


//11
//using static System.Math;
//WriteLine(Max(7, 3));
//WriteLine(Min(7, 3));
//WriteLine(Pow(2, 5));
//WriteLine(Sqrt(64));
//WriteLine(Round(2.54215848, 3));
//WriteLine(Round(2.54265848, 3));
//WriteLine(Sin(90));
//WriteLine(Cos(90));
//WriteLine(Tan(90));
//WriteLine(Abs(-5));
//WriteLine(Log2(64));
//WriteLine(Log10(1000));
//WriteLine(PI);
//WriteLine(E);

//12
//var password = "abc123";

//Write("enter password : ");
//var userPass = ReadLine();

//if (password == userPass)
//{
//    WriteLine("OK");
//}
//else
//{
//    WriteLine("ERROR");
//}

//13
Write("enter number : ");
int number = int.Parse(ReadLine());

if (number % 2 == 0)
{
    WriteLine("even");
}
else
{
    WriteLine("odd");
}
