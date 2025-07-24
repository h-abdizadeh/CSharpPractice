using System.Runtime.InteropServices;
using static System.Console;
using static System.Convert;
using static System.String;

// 1
//WriteLine("Hello, World!");
//WriteLine(5 + 7);
//WriteLine(7 - 3);
//WriteLine(4 * 6);
//WriteLine(8 / 2);
//WriteLine(7 / 4);
//WriteLine(7.0 / 4);
//WriteLine(7 / 4.0);
//WriteLine(7.25 / 4.18);

// 2
//WriteLine("5+4");
//WriteLine("5" + "4");
//WriteLine(5 + 4);

// 3
//WriteLine(8 / 2);
//WriteLine(8 % 2);
//WriteLine(7 / 2);
//WriteLine(7 % 2);

// 4
//WriteLine(5 > 2);
//WriteLine(8 <= 8);
//WriteLine(9 < 5);
//WriteLine(9 == 5);
//WriteLine(9 != 5);
//WriteLine("m" == "M");
//WriteLine('m' == 'M');

// 5
////WriteLine('amir');//error
//WriteLine('a');
//WriteLine((int)'a');
//WriteLine((int)'A');
//WriteLine((int)'#');
//WriteLine((int)'?');
//WriteLine((char)120);

// 6
//Write("mondesi");
//Write("farda");

//7
//string name = "farda";
//int age = 15;
//double number = 15.5;
//char ch = '*';
//WriteLine("name");
//WriteLine(name);
//WriteLine(age + number);
//WriteLine(name + age);
//WriteLine(name + ch);

//8
//float num1 = 12.5f;
//decimal num2 = 12.5m;
////byte b = -1;//error
//sbyte b = -1;
////short s = 50000;//error
//ushort s = 50000;

//9
//var n = "csharp";
//var a = 15.5;
//var b = 15.5f;

////b = "farda";//error
////b = 12.75;//error
//b = 2.5f;

//10
//dynamic n = "farda";
//n = 12.5;
//n = 1.5f;

//11
//Write("input 1 : ");
//var a = ReadLine();

//Write("input 2 : ");
//var b = ReadLine();

//Write(a + b);

//12
//Write("input 1 : ");
//var a = float.Parse(ReadLine());

//Write("input 2 : ");
//var b = float.Parse(ReadLine());

//WriteLine(a + b);
//WriteLine(a - b);
//WriteLine(a * b);
//WriteLine(a / b);

//13
//Write("input : ");
//var n = int.Parse(ReadLine());
//var h = n / 60;
//var m = n % 60;
//Write(h + " hour" + m + " minute");
//Write("{0} hour {1} minute", h, m);
//Write($"{h} hour {m} minute");
//Write($"{n / 60} hour {n % 60} minute");

//14
//Write("input 1 : ");
//var a = int.Parse(ReadLine());
//Write("input 2 : ");
//var b = int.Parse(ReadLine());
//Write("input 3 : ");
//var c = int.Parse(ReadLine());
////1
//Write(a + b + c / 3);// c/3 + a+b
//Write((a + b + c) / 3);a+b+c / 3
////2
//var sum = a + b + c;
//Write(sum / 3);

//15 cast
//double d = 2.5;
//int i;
////i = d;//error

////i =int.Parse(d);//error ...Parse(string)
//i = (int)d;
//Write(i);
//d = i;

//16
//float a = 2.5f;
//double b;
//b = a;

//a = (float)b;

//17
//decimal n = 3.12345678901234567890m;
////double d = (double)n;
//double d = Convert.ToDouble(n);
//WriteLine(d);
//WriteLine(Convert.ToInt32(n));
//WriteLine(ToInt32(d));

//18
//var password = "abc123";

//Write("enter password : ");
//var userPass = ReadLine();

//if (userPass == password)
//{
//    BackgroundColor = ConsoleColor.Green;
//    Clear();
//    Write("OK");
//}
//else
//{
//    BackgroundColor = ConsoleColor.Red;
//    Clear();
//    Write("WRONG");
//}

//19
//Write("input : ");
////var n=int.Parse(ReadLine());
//int.TryParse(ReadLine(), out var n);

////if (n % 2 != 0)
//if (n % 2 is not 0)
//    Write("odd");
//else
//    Write("even");

//20
//Write("input : ");
//int.TryParse(ReadLine(), out var n);

//var result = n % 2 != 0 ? "odd" : "even";
//Write(result);

//21
//Write("input : ");
//int.TryParse(ReadLine(), out var n);
//var result = n < 0 ? '-' : '+';
//Write(result);

//22
//Write("input : ");
//int.TryParse(ReadLine(), out var n);

////if (n < 0)
////    Write('-');
////else if (n>0)
////    Write('+');
////else
////    Write(0);

//var result = n < 0 ? '-' : n > 0 ? '+' : 0;
//Write(result);

//23
//Write("input : ");
//int.TryParse(ReadLine(), out var n);

//if (n < 10)
//    Write("one");
//else if (n < 100)
//    Write("two");
//else if (n < 1000)
//    Write("three");
//else
//    Write("four or more");

//24
//Write("input : ");
//int.TryParse(ReadLine(), out var n);

//if (n < 10 && n > -10)
//    Write("one");
//else if (n < 100 && n > -100)
//    Write("two");
//else if (n < 1000 && n > -1000)
//    Write("three");
//else
//    Write("four or more");

//25
//Write("input : ");
//long.TryParse(ReadLine(), out var n);

//WriteLine(n);
//Write(Math.Abs(n).ToString().Length);

//26
//START:
//WriteLine("\n--------------------------------");
//Write("input color [red, green, yellow] : ");
//var color = ReadLine();
//if (color is "red")//==
//    Write("stop");
//else if (color is "green")
//    Write("go");
//else if (color is "yellow")
//    Write("slow");
//else
//{
//    Write("alarm");
//    Beep(500, 1000);
//}
//goto START;

//27
//BackgroundColor = ConsoleColor.DarkBlue;
//var str = "     Mohandesi Farda     ";
//WriteLine(str);
//WriteLine(str.Length);
//WriteLine(str.Trim());
//WriteLine(str.ToUpper());
//WriteLine(str.ToLower());


//28
//start:
//Write("enter color : ");
//var color = ReadLine().ToLower();

//if (color is "red")
//    BackgroundColor = ConsoleColor.DarkRed;
//else if (color is "blue")
//    BackgroundColor = ConsoleColor.DarkBlue;
//else if (color is "green")
//    BackgroundColor = ConsoleColor.DarkGreen;
//else
//    BackgroundColor = ConsoleColor.DarkYellow;

//WriteLine(color);
//goto start;

//29
////BackgroundColor = ConsoleColor.Blue;
//ForegroundColor = ConsoleColor.Blue;
//ReadLine();

//30
//Write("input color [red, green, yellow] : ");
//var color = ReadLine().ToLower();

//switch (color)
//{
//    case "red": Write("stop"); break;
//    case "green": Write("go"); break;
//    case "yellow": Write("slow"); break;

//    default:
//        {
//            Write("alarm");
//            Beep(500, 1000);
//        }
//        break;
//}

//31
//Write("input color [red, green, yellow] : ");
//var color = ReadLine().ToLower();

//var result = color switch
//{
//    "red" => "stop",
//    "green" => "go",
//    "yellow" => "slow",
//    _ => "alarm"
//};

//Write(result);
////if (result=="alarm")
//if (result.Contains("alarm"))
//    Beep(500, 1000);

//32
////Write("enter number : ");
////var n = float.Parse(ReadLine());
////Write(n * n);
//try
//{
//    Write("enter number : ");
//    var n = int.Parse(ReadLine());
//    Write(2/ n);
//}
//catch (Exception error)
//{
//    //throw;
//    //Write("error");
//    //Write(error);
//    Write(error.Message);

//}

//33 Array
//using static System.String;
////int n1;
////int n2 = 5;

//int[] arr1 = new int[10];
//int[] arr2 = { 3, -4, 6, 11, 9, 8 };

//WriteLine(string.Join(", ", arr1));
//WriteLine(string.Join(" ", arr2));
////1
//////arr1[3] = 5;
//////Write("number : ");
//////arr1[0] = int.Parse(ReadLine());
////arr1[1] = 7;
////arr1[1] = 18;
////WriteLine(Join(", ", arr1));

////2
//////WriteLine(arr2[2]);
//////arr2[0] = 5;
////arr2[1] = arr2[4];
////WriteLine(Join(" ", arr2));


//34
//int[] numbers = { 12, 5, -4, 3, 9, 8 };
//WriteLine(numbers.Length);
//WriteLine(numbers.Max());
//WriteLine(numbers.Min());
//WriteLine(numbers.Sum());
//WriteLine(numbers.Average());

//35
//int[] num1 = new int[5];
//int[] num2 = { 3, 7, -4, 11, 9 };
//var num3 = new int[5];
//var num4 = new int[] { 3, 7, -4, 11, 9 };

//36
//string[] names = { "amir", "narjes", "benyamin", "mahan", "mehdi" };
////1
////WriteLine(names.Length);
////WriteLine(names.First());   
////WriteLine(names.Last());
////WriteLine(names[0].Length);
////2
//WriteLine(names.Contains("amir"));
//WriteLine(names.Contains("sarah"));
//WriteLine(names.Count());

//37
////using static System.String;
//int[] numbers = { 2, 3, 5, 2, 6, 7, 5, 3, 3, 11, 5, 2 };
////WriteLine(numbers.Length);
////WriteLine(numbers.Count());
////WriteLine(numbers.Count(n => n == 2));
////WriteLine(numbers.Count(num => num % 2 == 1));
////WriteLine(numbers.First(x => x == 5));
////WriteLine(numbers.FirstOrDefault(x => x == 5));
////WriteLine(numbers.Distinct().Count());
////WriteLine(Join(" ", numbers));
////WriteLine(Join(" ", numbers.Distinct()));
//WriteLine(numbers.Any(n => n % 7 == 0));
//WriteLine(numbers.All(n => n % 7 == 0));
//WriteLine(numbers.All(n => n > 1));

//38
//int[] numbers = { 2, 3, 5, 2, 6, 7, 5, 3, 3, 11, 5, 2 };
//WriteLine(Join(" ", numbers));
////var result = numbers.Where(n => n % 2 is 0);
////var result = numbers.Take(5);
////var result = numbers.TakeLast(5);
////var result = numbers.TakeWhile(x => x>=2 && x<=5 );
////var result = numbers.Reverse();
//var result = numbers.Select(x => x == 3);
//WriteLine(Join(" ", result));

//39
//int[] arr1 = { 1, 2, 3, 4, 5 };
//int[] arr2 = { 6, 7, 8 };
//WriteLine(Join(" ", arr1.Concat(arr2)));
//arr2.CopyTo(arr1, 0);
//WriteLine(Join(" ",arr1));
//WriteLine(Join(" ",arr1.Append(10)));


//40
//string[] names = 
//    { "narjes", "benyamin", "amir", "mahan", "mahdi" };

//1
//Array.Sort(names);
//Array.Clear(names);
//Array.Reverse(names);
//Write(Join(" ", names));

//2
//WriteLine(Array.Exists(names, n => n == "amir"));
//WriteLine(Array.Exists(names, n => n == "sara"));
//WriteLine(Array.IndexOf(names, "amir"));
//WriteLine(Array.IndexOf(names, "sara"));
//WriteLine(Array.FindIndex(names, n => n == "amir"));
//WriteLine(Array.FindIndex(names, n => n == "sara"));

//3
//WriteLine(Join(" ", names.Where(n => n.Contains("i"))));
//WriteLine(Join(" ", Array.FindIndex(names,n => n.Contains("i"))));
//WriteLine(Join(" ", Array.FindAll(names,n => n.Contains("i"))));

//41
//var names1 = new List<string>();
//var names2 =
//    new List<string>()
//    { "narjes", "benyamin", "amir", "mahan", "mahdi", "amir" };

//WriteLine(Join(" ", names1));
//WriteLine(Join(" ", names2));

//names1.Add("reza");
//names1.Add("sara");
//names1.Insert(0, "amir");
////names1.Clear();
////names1.AddRange(names2);
////names1.InsertRange(1, names2);
////names2.Remove("amir");
////names2.Remove("sara");
////names2.RemoveAll(n => n == "amir");
//names2.RemoveAt(5);
////WriteLine(Join(" ,", names1.Append("ava")));
//WriteLine(Join(" ,", names1));
//WriteLine(Join(" ,", names2));

//42
//var names =
//    new List<string>()
//    { "narjes", "benyamin", "amir", "mahan", "mahdi", "amir" };

//Write("enter name : ");
//var n = ReadLine();
//if (names.Contains(n))
//    names.Remove(n);
//else
//    names.Add(n);

//Write(Join(" ", names));

//43
//var rnd = new Random();
////WriteLine(new Random().Next());
//WriteLine(rnd.Next());
//WriteLine(rnd.Next(500));//0 : 499
//WriteLine(rnd.Next(100,500));//100 : 499
//WriteLine(rnd.Next(-100,-10));//-100 : -11


//44
//var names1 =
//    new List<string>() { "narjes", "benyamin", "amir", "mahan", "mahdi" };
//string[] names2 = { "narjes", "benyamin", "amir", "mahan", "mahdi" };

////var i = new Random().Next(5);
//var i = new Random().Next(names1.Count());
////WriteLine(names1[i]);
//WriteLine(names1.ElementAt(i));
//WriteLine(names2[i]);

//WriteLine(names2[new Random().Next(names2.Length)]);

//45
//start:
//var target = new Random().Next(1, 7);
//Write("enter guess : ");
//var guess = int.Parse(ReadLine());

////if (target == guess)
////if (target is guess)
//if (target.Equals(guess))
//    WriteLine("win");
//else
//    WriteLine(target);

//goto start;

//46
//var m = 4;
//object n = 4;
//WriteLine("4".Equals(n));
//WriteLine(4.Equals(n));
////WriteLine(4==n);//error


//47
////for(int i = 1; i < 100; i++)
//for(int i = 1; i < 100; i+=2)
//{
//    Write(i + "\t");
//}

//48
//for (int i = 1; i < 100; i++)
//{
//    if (i % 2 is 0)
//        Write(i + "\t");
//}

//49
//for (int i = 1; i < 10; i++)
//{
//    WriteLine(new Random().Next(1000, 10000) + "\t");
//}

//50
//var names =
//    new List<string>() { "narjes", "benyamin", "amir", "mahan", "mahdi" };
//for (int i = 0; i < 5; i++)
//{
//    var index = new Random().Next(0, names.Count());
//    WriteLine(names[index]);
//    names.RemoveAt(index);
//}

//51
//using static System.ConsoleColor;
//ConsoleColor[] colors = { Red, Green, Blue, White, Yellow, Cyan };

//while (true)
//{
//    var color = colors[new Random().Next(0, colors.Length)];
//    BackgroundColor = color;
//    var f=new Random().Next(500,5000 );
//    var t=new Random().Next(100,500 );
//    Beep(f,t);  
//    WriteLine();
//    Clear();
//}

//52
//var target = new Random().Next(1, 101);//1 : 100
//var guess = 0;

//while (guess != target)
//{
//    Write("guess [1 to 100] : ");
//    int.TryParse(ReadLine(), out guess);

//    if (guess > target)
//        WriteLine("go down");
//    else if (guess < target)
//        WriteLine("go up");
//    else if (guess == target)
//        WriteLine("you win");
//}

//53
//var target = new Random().Next(1, 101);
//var guess = 0;
//for (int i = 0; i < 5; i++)
//{
//    WriteLine("enter 1,100");
//    int.TryParse(ReadLine(), out guess);
//    if (guess > target)
//        WriteLine("go down");
//    else if (guess < target)
//        WriteLine("go up");
//    else if (guess == target)
//        break;

//}
//if (guess != target)
//    WriteLine("bakht target "+target);
//else
//    WriteLine("bord");

//54
//string[] names = { "narjes", "benyamin", "amir", "mahan", "mahdi" };

////for (int i = 0; i < names.Length; i++)
////{
////    Write(names[i] + "\t");
////}

//foreach(var item in names)
//{
//    Write(item + "\t");
//}


//55
//BackgroundColor = ConsoleColor.DarkBlue;
//var str = "     hello world, C#     ";
//WriteLine(str);
//WriteLine(str.Length);
//WriteLine(str.Trim());
//WriteLine(str.Trim().Length);
//WriteLine(str.TrimEnd());
//WriteLine(str.TrimStart());
//WriteLine(str.ToLower());
//WriteLine(str.ToUpper());
//WriteLine(str.Replace(" ", "*"));
//WriteLine(str.Replace("hello", "hi"));
//WriteLine(str.Substring(8));
//WriteLine(str.Substring(8, 5));
//WriteLine(str.Remove(8));
//WriteLine(str.Remove(8, 5));
//WriteLine(str.IndexOf(','));
//WriteLine(str.IndexOf("world"));
//WriteLine(str.IndexOf("python"));
////var result = str.Trim().Split(' ');
////var result = str.Trim().Split('o');
//var result = str.Trim().ToCharArray();
//WriteLine(Join("\n", result));


//BackgroundColor = ConsoleColor.Black;


//56
//Write("phone : ");
//var phone = ReadLine();
//if (phone?.Length == 11)
//    if (phone.Substring(0, 2) == "09")
//        if (phone.All(char.IsDigit))
//            Write("valid phone");
//        else
//            Write("all char is not digit");
//    else
//        Write("no start with 09");
//else
//    Write("must be 11 char");

//57
Write("phone : ");
var phone = ReadLine();
if (phone?.Length == 11 &&
    phone.StartsWith("09") &&
    phone.All(char.IsDigit))
    Write("valid phone");
else
    Write("not valid");
