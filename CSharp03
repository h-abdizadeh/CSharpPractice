using System.Diagnostics.Tracing;
using static System.Console;
using static System.ConsoleColor;
//1
//WriteLine("Hello, World!");
//WriteLine(5 + 12);
//WriteLine(8 - 3);
//WriteLine(3 * 7);
//WriteLine(14 / 4);
//WriteLine(14.0 / 4);
//WriteLine(5 > 3);
//WriteLine(8 < 2);
//WriteLine('h');
//WriteLine('h'+'i');
//WriteLine((char)104);
//WriteLine((char)82 );


//2
//int n = 12;
//int m;
//m = 13;

//float flt = 2.5f;
//double dbl = 2.8;
//decimal dcml = 2.2m;

//string name = "ali";
//char ch = 'a';

//bool result=false;
//bool rslt = 5 > 3;

//3
//int n;
//n = 5;

//var m = 5;
//var x1 = 2.5;
//var x2 = 2.5f;
//var name = "reza";
//var result = 8 < 2;

//var number = 5;
//number = 12;
////number = 12.5;//error

//dynamic temp = 5;
//temp = "reza";
//temp = true;

//object o = true;
//o = 12;

//const double G = 9.8;
////G = 10;//error

//4
//byte num = 128;
////num = -10;//error
////num = 256;//error
//sbyte n = -50;

//short s = -10000;
////s = 50000;//error

//ushort x;
////x = -100;//error
//x = 50000;

//5
//Write("enetr first name : ");
//string? name = ReadLine();

//Write("enter last name : ");
//string? family = ReadLine();

////WriteLine(name+" "+family);
////WriteLine("{0} {1}", name, family);
//WriteLine($"{name} {family}");

//6
//int num1 = int.Parse(ReadLine());
//double.TryParse(ReadLine(), out double num1);
//double num2 = Convert.ToDouble(ReadLine());

//WriteLine(num1 + num2);
//WriteLine(num1 - num2);
//WriteLine(num1 * num2);
//WriteLine(num1 / num2);
//WriteLine(num1 % num2);

//7
//double n = 2.5;
//int m = (int)n;
//Write(m);

//8
//using static System.ConsoleColor;

//BackgroundColor = Green;
//ForegroundColor = DarkBlue;
//Clear();
//SetCursorPosition(50, 5);
//Write("Console Color Design");
//Beep(500, 500);
//Beep(1500, 500);
//Beep(800, 500);
//ReadKey();

//9
//int n = 5;
//WriteLine(n++);
//WriteLine(n);
//Write(++n);


//10
//START:
//var password = "abc123";
//Write("enter password : ");
//var userPass = ReadLine();

//if (password == userPass)
//    //{
//    WriteLine("OK");
////}
//else
//    //{
//    WriteLine("WRONG");
////}
//goto START;

//11
//START:
//Write("enter number : ");
////var number = int.Parse(ReadLine());
//int.TryParse(ReadLine(), out var number);

//WriteLine(number / 2);
//WriteLine(number % 2);

//if (number % 2 is 0)//is <--> ==
//    WriteLine("EVEN");
//else
//    WriteLine("ODD");

//goto START;

//12
//START:
//Write("enter number : ");
//int.TryParse(ReadLine(), out var number);

//var result = number > 0 ? "POS" : "NEG";
//WriteLine(result);

//goto START;

//13
//START:
//Write("enter number : ");
//var num = int.Parse(ReadLine());

//if (num > 0)
//    WriteLine("positive");
//else if (num < 0)
//    WriteLine("negative");
//else
//    WriteLine("zero");

//goto START;

//14
//START:
//Write("enetr color : ");
//var color = ReadLine().ToLower();
///*WriteLine(color.ToLower());*/
////WriteLine(color.ToUpper());

////if (color.ToLower() is "red")
//if (color is "red")
//    WriteLine("STOP");
//else if (color is "green")
//    WriteLine("GO");
//else if (color is "yellow")
//    WriteLine("SLOW");
//else
//    Beep(2000, 3000);

//goto START;

//15
//Write("enter color : ");
//var color = ReadLine().ToLower();

////1
////switch (color)
////{
////    case "red":
////        {
////            WriteLine("STOP");
////        }
////        break;

////    case "green": WriteLine("GO"); break;
////    case "yellow": WriteLine("SLOW"); break;
////    default: WriteLine("ALARM"); break;
////}

////2
//var result = color switch
//{
//    "red" => "STOP",
//    "green" => "GO",
//    "yellow" => "SLOW",
//    _ => "ALARM"
//};

//WriteLine(result);


//16
//Write("enter number : ");
//var n = double.Parse(ReadLine());

//Write("accept project status input 1 : ");
//var project = ReadLine() == "1";//? true : false;

////if (n >= 15 && project)////AND
////if (n >= 15 || project)////OR
//if ((n >= 15 && n<=20) || project)////AND, OR
//    Write("ACCEPT");
//else
//    Write("FAIL");

//16
//try
//{
//    int n = 0;
//    Write("enter number : ");
//    n = int.Parse(ReadLine());

//    WriteLine(n * n);
//}
//catch (Exception exc)
//{
//    //throw;
//    //WriteLine("error");
//    WriteLine(exc.Message);

//}
//finally
//{
//    //after try or catch block
//}

//17
//int[] numbers1 = new int[5];
//int[] numbers2 = { 12, 3, -7, 8, 11 };
//var numbers3 = new int[] { 11, 9, -12, 3 };

//WriteLine(numbers1[2]);
//WriteLine(numbers2[2]);
//WriteLine(numbers3[2]);
//WriteLine(numbers2[5]);

//numbers1[2]=13;
//WriteLine(numbers1[2]);

//WriteLine(numbers2.Length);
//WriteLine(numbers2.Count());
//WriteLine(numbers2.First());
//WriteLine(numbers2.Last());
//WriteLine(numbers2.Min());
//WriteLine(numbers2.Max());
//WriteLine(numbers2.Sum());
//WriteLine(numbers2.Average());
//WriteLine(numbers2.Contains(12));
//WriteLine(numbers2.Contains(20));

//18
//List<string> names1 = new List<string>();
//List<string> names2 =
//    new List<string> { "ali", "amir", "reza", "sadegh" };

//var names3 = new List<string> { "ali", "amir", "reza", "ali", "sadegh" };

//WriteLine(names1.Count);
//WriteLine(names2.Count);
////
//names1.Add("saeed");//Append
//names1.Insert(0, "reza");//Prepend
//names1.AddRange(names2);
//names1.Concat(names3);

//names1.Remove("ali");//value
//names1.RemoveAt(1);//index
////names1.RemoveRange(1, 2);//index,count
////names1.Clear();
//WriteLine(names3.Count());
//WriteLine(names3.Count(n => n == "ali"));
//var tmp = names3.Where(n => n == "ali");
//WriteLine(tmp.Count());
//names1.RemoveAll(n => n == "ali");
////
//WriteLine(names1.Count);


//19
//Queue<string> queue = new Queue<string>();
//Stack<string> stack = new Stack<string>();

//queue.Enqueue("ali");
//queue.Enqueue("amir");

//stack.Push("ali");
//stack.Push("amir");

//WriteLine(queue.Peek());
//WriteLine(stack.Peek());

//var q = queue.Dequeue();
//WriteLine(q);

//var s = stack.Pop();
//WriteLine(s);

//WriteLine(queue.Peek());
//WriteLine(stack.Peek());

//20
//for (int i = 0; i < 100; i++)
//for (int i = 0; i < 100; i+=2)
//for (int i = 0; i < 100; i+=10)
//{
//    Write($"\t{i}");
//}

//21
//var names =
//    new List<string>() { "ali", "amir", "reza", "sadegh", "arman" };

//A : Next()
//START:

//Random r = new Random();//var r = new Random();
////WriteLine(r.Next());
////WriteLine(r.Next(1000));//[0,999]//Next(0,1000)
////WriteLine(r.Next(1000,10000));//[1000,9999]

////int index = r.Next(5);
//int index = r.Next(names.Count);
//WriteLine(names[index]);

//ReadKey();
//goto START;

//B : for(;;)
//for (int i = 1; i <= 3; i++)
//{
//    var index = new Random().Next(names.Count);
//    WriteLine(names[index]);
//    names.RemoveAt(index);
//}


//22
//var names =
//    new List<string>() { "ali", "amir", "reza", "sadegh", "arman" };

//for (int i = 0; i < names.Count; i++)
//{
//    WriteLine(names[i]);
//}

//23 *
//Write("enter number : ");
//uint.TryParse(ReadLine(), out uint n);//uint === int > 0

//var names = new List<string>();
//for (int i = 1; i <= n; i++)
//{
//    AGAIN1:
//    Write($"enter name {i} : ");
//    var name = ReadLine();
//    var valid = name.ToCharArray().All(char.IsDigit);
//    if (string.IsNullOrWhiteSpace(name) || valid)
//        goto AGAIN1;

//    names.Add(name);
//}

//AGAIN2:
//Write("enter winner number : ");
//uint.TryParse(ReadLine(), out uint w);

//if (w > names.Count) goto AGAIN2;

//for (int i = 1; i <= w; i++)
//{
//    int index = new Random().Next(names.Count);
//    BackgroundColor = Yellow;
//    ForegroundColor = Black;
//    WriteLine($"winner is {names[index]}");

//    names.RemoveAt(index);
//}

//ReadKey();


//24
//Write("enter number : ");
//int.TryParse(ReadLine(), out int n);
//string binary = string.Empty;
//while (n > 0)
//{
//    binary = (n % 2) + binary;
//    n = n / 2;//  n/=2;
//}

//WriteLine($"output = {binary}");

//25
//var names =
//    new List<string> { "ali", "amir", "reza", "arman" };

//////for
////for (int i = 0; i < names.Count; i++)
////    WriteLine(names[i]);

//////while
////int n = 0;
////while(n<names.Count)
////    WriteLine(names[n++]);  

////foreach
//foreach (var item in names)
//    WriteLine(item);

//25
//var names =
//    new List<string> { "ali", "amir", "reza", "arman" };


//names.Sort();
///names.Reverse();
//names = names.Where(n => n.Contains('m')).ToList();
//string? name =
//names.FirstOrDefault(n => n.Contains('m'));
//WriteLine(name);

//names = names.Take(3).ToList();

//foreach (var item in names)
//    WriteLine(item);

//26
//using static System.String;

//var names =
//    new List<string> { "ali", "amir", "reza", "arman" };

//Write(Join(", ", names));


//27
//using static System.Threading.Thread;

//var str = "Hello world, CSharp!";

//while (true)
//{
//    foreach (char ch in str)//var ch in str
//    {
//        if (ch == ' ')
//            continue;

//        Write(ch);
//        Sleep(100);
//    }

//    Clear();
//}


//28
//var str = "     Hello world, CSharp!     ";
//WriteLine(str);
//WriteLine(str.Length);
//WriteLine(str.Trim());
//WriteLine(str.Trim().Length);
//WriteLine(str.TrimEnd().Length);
//WriteLine(str.TrimStart().Length);
//WriteLine(str.ToUpper());
//WriteLine(str.ToLower());
//WriteLine(str.Replace('l', '*'));
//WriteLine(str.Replace("Hello", "Hi"));
//WriteLine(str.Contains("or"));
//WriteLine(str.Contains("hello"));
//WriteLine(str.IndexOf("l"));//-1 --> not exists
//WriteLine(str.LastIndexOf("l"));
//WriteLine(str.Count());
//WriteLine(str.Count(s => s is 'l'));
//WriteLine(String.Join(null, str.Reverse()));

//WriteLine(str.Substring(10, 5));
//WriteLine(str.Substring(10));
//WriteLine(str.Trim().Substring(0, 5));

//WriteLine(str.Remove(10));
//WriteLine(str.Remove(10, 5));

//var strChars = str.Trim().ToCharArray();
//WriteLine(String.Join('\n', strChars));

//var strWords = str.Trim().Split(' ');
//WriteLine(String.Join('\n',strWords));

//29
//A
//var str = "     Hello world, CSharp!     ";
//var startIndex = str.Trim().IndexOf("world");
////var length = "world".Length;
//var length = str.Trim().IndexOf(',') - startIndex;

//WriteLine(str.Trim().Substring(startIndex, length));

//B
//str = str.Trim();
//var words = str.Split(' ').ToList();
//var search = "world";
//for(int i = 0; i < words.Count; i++)
//{
//	if (words[i].Contains(search))
//	{
//		WriteLine(words[i]);
//		break;
//	}
//}

//30
//while (true)
//{
//    var input = ReadKey();
//    Clear();
//    //Write(input.KeyChar);

//    var code = (int)input.KeyChar;
//    //Write(code);
//    var output = (char)(code + 10);
//    Write(output);
//}

//31
//using static System.Math;

//Write("enter binary number : ");
//var bin = ReadLine();

//int pow = 0, result = 0;

//foreach (char ch in bin.Reverse())
//{
//    int n = int.Parse(ch.ToString());
//    if (n is not 0)//!=
//        result += (int)Pow(2, pow) * n;
//    pow++;
//}
//WriteLine($"{bin} => {result}");

//32
//using static System.Math;
//WriteLine(PI);
//WriteLine(Max(7, 11));
//WriteLine(Min(7, 11));
//WriteLine(Sqrt(64));
//WriteLine(Round(PI, 3));//>=5 -> +1
//WriteLine(Round(PI));
//WriteLine(Abs(-15));//absolute
//WriteLine(Log2(128));
//WriteLine(Log10(100));
//WriteLine(Sin(90));
//WriteLine(Round(Sin(90)));
//WriteLine(E);

//33 reverse algorithm
using static System.String;

var numbers = new List<int> { 12, 8, -3, 21, 9, 2, 11 };
WriteLine(Join(" ", numbers));

var start = 0;
var end = numbers.Count - 1;

while (start < end)
{
    //1
    //var tmp = numbers[start];
    //numbers[start] = numbers[end];
    //numbers[end] = tmp;

    //2 (a,b)=(b,a)
    (numbers[start], numbers[end]) = (numbers[end], numbers[start]);

    start++;
    end--;
}

WriteLine(Join(" ", numbers));

