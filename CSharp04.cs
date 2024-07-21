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
//Write("enter number : ");
//int number = int.Parse(ReadLine());

//if (number % 2 == 0)
//{
//    WriteLine("even");
//}
//else
//{
//    WriteLine("odd");
//}

//14
//Write("enter number 1 : ");
//var n=float.Parse(ReadLine());

//Write("enter number 2 : ");
//var m=float.Parse(ReadLine());

//if (n >= 16)
//{
//    var sum = n + m;
//    WriteLine(sum/2);
//}
//else
//{
//    WriteLine(n);
//}

//15
//Write("enter number 1 : ");
//var n = float.Parse(ReadLine());

//Write("enter number 2 : ");
//var m = float.Parse(ReadLine());

//if (n > m)
//    Write(n);
//else
//    Write(m);

//16
//Write("enter character : ");
//var ch = ReadKey();
//WriteLine();
////WriteLine(ch);
////WriteLine(ch.Key);
////WriteLine(ch.KeyChar);
//WriteLine((int)ch.KeyChar);

////var newCh =
////(int)ch.KeyChar > 100 ? (int)ch.KeyChar - 25 : (int)ch.KeyChar;

//var ascii = (int)ch.KeyChar;
//var newCh = ascii > 100 ? ascii - 25 : ascii;

//WriteLine(newCh);
//WriteLine((char)newCh);

//17
//Write("enter light color : ");
//string color = ReadLine().ToLower();//RED >>>>>> red

//WriteLine(color);

//if(color is "red")//==
//{
//    Write("STOP");
//}
//else if(color is "yellow")
//{
//    Write("SLOW");
//}
//else if(color is "green")
//{
//    Write("GO");
//}
//else
//{
//    Write("ALARM");
//    Beep(300, 1000);
//}

//18
//Write("enter number 1 : ");
//var a = int.Parse(ReadLine());

//Write("enter number 2 : ");
//var b = int.Parse(ReadLine());

//Write("enter number 3 : ");
//var c = int.Parse(ReadLine());

////1
////if (a > b)
////    if (a > c) Write(a);
////    else Write(c);
////else
////    if (b > c) Write(b);
////    else  Write(c);

////2 - and
//if (a > b && a > c) Write(a);
//else if (b > a && b > c) Write(b);
//else Write(c);

//19
//Write("enter number 1 : ");
//var a = float.Parse(ReadLine());

//Write("enter number 2 : ");
//var b = float.Parse(ReadLine());

//if (a >= 15 || b >= 15)
//    Write(a + b);
////else
////    Write("failed");


//20
////1
////Write("enter number : ");
//////var n = int.Parse(ReadLine());
////var n = double.Parse(ReadLine());

////Write(n * n);

////2 - try
//try
//{
//    Write("enter number : ");
//    //var n = int.Parse(ReadLine());
//    var n = double.Parse(ReadLine());

//    Write(n * n);
//}
////catch
//catch (Exception error)
//{
//    //throw;
//    //Write("ERROR");
//    //Write(error);
//    ForegroundColor = ConsoleColor.Red;
//    Write(error.Message);
//}
//BackgroundColor=ConsoleColor.White;
////Clear();
//ForegroundColor = ConsoleColor.Black;

//21
//using static System.String;

//int[] numbers1 = new int[5];
//int[] numbers2 = { 5, 7, -11, 8, 3 };
//var numbers3 = new double[5];
////var numbers4 = new int[] { 5, 8, 9, -5, 4 };
//var names1 = new string[5];
//string[] names2 = 
//    { "ali", "amir", "sara", "mahdi", "narges" };

//WriteLine(numbers1[3]);
//WriteLine(numbers2[1]);
//WriteLine(names1[4]);
//WriteLine(names2[0]);
//WriteLine(numbers2);
//WriteLine(Join(',',numbers2));
//WriteLine(Join('-',names2));
//WriteLine(Join(',',numbers1));
//WriteLine(Join(',',names1));
