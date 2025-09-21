using System.Collections;
using System.Security.Cryptography;
using static System.Console;
using static System.ConsoleColor;
using static System.String;
//1
///*Console.*/WriteLine("Hello, World!");
//WriteLine("farda");
//WriteLine(4 + 5);
//WriteLine(7 * 3);
//WriteLine(3 - 9);
//WriteLine(8 / 2);
//WriteLine(5 / 3);
//WriteLine(5.0 / 3);
//WriteLine(5 / 3.0 );
//WriteLine(5 / 3.0 );

//2
//WriteLine(8 % 2);
//WriteLine(7 % 2);

//3
//WriteLine(7 > 2);
//WriteLine(5 >= 5);
//WriteLine(5 < 3);
//WriteLine(5 != 6);
//WriteLine(5 == 6);
//WriteLine(!(5 == 6));

//4
//WriteLine(4 + 5);
//WriteLine("4 + 5");
//WriteLine("4" + "5");
//WriteLine("4" + 5);
////WriteLine("4" - "5");//error

//5
//WriteLine('a');
//WriteLine("a" + "b");
//WriteLine('a' + 'b');
////WriteLine('ab');//error
//WriteLine((int)'f');
//WriteLine((char)81);
//WriteLine((char)('a'+'b'));
//WriteLine((char)('!'+'?'));

//6
//int n = 7;
//WriteLine(n);
//WriteLine(n + 12);
//string name;
//name = "farda";
//double d = 2.5;
//char ch = 'a';
//float num1 = 1.5f;
//decimal num2 = 1.5m;
//var n = 2.5d;


//7
//var n = 7;
//var name = "sara";
//var result = n + name;
//WriteLine(result);
//WriteLine("result");

//8
//dynamic n = 7;
//n = "farda";
//n = 2.5f;

//9
//const double p = 3.14;
////p = 3;error

//10 cast
//var n = 2.5;
//int a = (int)n;
//WriteLine(n);
//WriteLine(a);

//object obj = 5;
////WriteLine(obj / 3);
//WriteLine((int)obj / 3);
////WriteLine((double)obj / 3);
////WriteLine((string)obj + 3);

//11 convert
//var n = 2.5;
//float a = Convert.ToSingle(n);//single == float
//int b = Convert.ToInt32(n);//int32 == int
//short c = Convert.ToInt16(n);//int16 == short


//12
//bool b1 = Convert.ToBoolean(2.5);
//WriteLine(b1);
//bool b2 = Convert.ToBoolean(0);
//WriteLine(b2);
//bool b3 = Convert.ToBoolean(-1);
//WriteLine(b3);

//13
//Write("enter age : ");
//var age = int.Parse(ReadLine());
//WriteLine(age + 100);

//14
//Write("enter age");
//var age = int.Parse(ReadLine());
//WriteLine(age * 365);
//WriteLine(age * 12);
//WriteLine(age * 365 * 24);

//15
//Write("enter age : ");
//var age = int.Parse(ReadLine());
//var days = age * 365;
//var months = days / 30;
//var hours = days * 24;
////Write("days : " + days + " months : " + months + " hours : " + hours);
////Write("days : " + days + "\nmonths : " + months + "\nhours : " + hours);
////Write("days : {0} \nmonths : {1} \nhours : {2}", days, months, hours);
//Write($"days : {days} \nmonths : {months} \nhours : {hours}");

//16
//Write("enter your number : ");
//var number = int.Parse(ReadLine());
//Write($"hours : {number / 60} minutes : {number % 60}");

//17
//Write("enter price : ");
//var price = int.Parse(ReadLine());

//Write("enter sellOff : ");
//var selloff = int.Parse(ReadLine());

////1
////var final = price - (selloff * price / 100);
//var final = (100 - selloff) * price / 100;
//Write("final price :  " + final);

//18
//start:
//var password = "abc123";
//Write("password : ");
//var userPass = ReadLine();

//if (userPass == password)
//{
//    WriteLine("Ok");
//}
//else
//{
//    WriteLine("Wrong");
//}
//goto start;

//19
//var n = Convert.ToInt32(ReadLine());
//var a = Convert.ToInt32(ReadLine());
//WriteLine("{0}-{1}:{2}", n, a, n - a);
//WriteLine(n + "+" + a + ":" + (n + a));
//WriteLine($"{n}*{a}:{n * a}");
//WriteLine($"{n}/{a}:{n / a}");

////20
//WriteLine("\"");
//WriteLine("\'");
//WriteLine("\\");

//21
//Write("phone :");
//var a = ReadLine();
//if (a.Length == 11)
//    if (a.All(char.IsDigit))
//        if (a.StartsWith("09"))
//        {
//            Write("valid");
//            Beep(3500, 5000);
//        }

//22
//Write("phone :");
//var a = ReadLine();
//if (a.Length == 11 &&
//    a.All(char.IsDigit) &&
//    a.StartsWith("09"))
//{
//    Write("valid");
//    Beep(3500, 5000);
//}
//else
//    WriteLine("invalid");

//23
//start: 
//WriteLine("CA");
//var CA=float.Parse(ReadLine());
//WriteLine("FS");
//var FS=float.Parse(ReadLine());
//if (CA>=12||FS>=12)
//{
//    WriteLine("pass");
//}
//else
//{
//    WriteLine("fail");
//}
//goto start;

//24
//start:
//Write("number : ");
//var n = int.Parse(ReadLine());

//if (n % 2 == 0)
//    WriteLine("even");
//else
//    WriteLine("odd");

//goto start;

//25
//start:
//Write("number : ");
//var n = int.Parse(ReadLine());

//if (n > 0)
//    WriteLine('+');
//else if (n < 0)
//    WriteLine('-');
//else
//    WriteLine('0');

//goto start;

//26
//start:
//Write("color : ");
//var color = ReadLine().ToLower();
//if (color is "red")//==
//    WriteLine("STOP");
//else if (color is "green")
//    WriteLine("GO");
//else if (color is "yellow")
//    WriteLine("SLOW");
//else
//{
//    WriteLine("ALARM");
//    Beep(500, 100); Beep(800, 200); Beep(500, 500);
//}

//goto start;

//27
//WriteLine("RED".ToLower());
//WriteLine("red".ToUpper());

//28
//using static System.ConsoleColor;

//BackgroundColor = Green;
//ForegroundColor = DarkYellow;
//Clear();
//BackgroundColor = DarkBlue;
//ReadLine();

//29
//start:
//WriteLine("Color : ");
//string Color = ReadLine().ToLower();
//switch (Color)
//{
//    case "red": WriteLine("Stop"); break;
//    case "green": WriteLine("Goo"); break;
//    case "yellow": WriteLine("Slow"); break;
//    default: WriteLine("Alarm"); break;
//}
//goto start;

//30
//start:
//WriteLine("enter price");
//var price = float .Parse(ReadLine());
//var selloff= 0;
//if (price >= 100)
//    selloff = 20;
//else if (price >=50 )
//    selloff = 15;
//else if (price >=10)
//    selloff = 10;
//price = price - price * selloff / 100;
//WriteLine($"price : {price}"); 
//goto start;

//31
//start:

//1
//WriteLine(new Random().Next());
//WriteLine(new Random().Next(1000));//0 to 999
//WriteLine(new Random().Next(1000,10000));//1000 to 9999
//ReadLine();

//2
//var rnd = new Random();
//Write(rnd.Next(1000, 10000) + "\t");

//goto start;


//32
//ConsoleColor[] colors = { Red, Green, Yellow, Blue };

//start:
//var rnd = new Random();
//var index = rnd.Next(4);//0 to 3
//BackgroundColor = colors[index];
//WriteLine();

//goto start;


//33
//int[] numbers1 = { 1, 5, -2, 11, -8 };
//int[] numbers2 = new int[10];

//WriteLine(Join(", ",numbers1));
//WriteLine(Join(", ",numbers2));

//WriteLine(numbers1[3]);
//WriteLine(numbers1.Length);
//WriteLine(numbers2.Length);

//34
//List<int> numbers1 = new List<int> { 10, 11, -3, 6, -12 };
//var numbers1 = new List<int>{ 10, 11, -3, 6, -12 };
//var numbers2 = new List<int>();

//WriteLine(Join(", ", numbers1));
//WriteLine(Join(", ", numbers2));

//WriteLine(numbers1[3]);
//WriteLine(numbers1.Count());
//WriteLine(numbers2.Count());

//35 az ki 
////string[] name1 = { "setayesh", "fatemeh", "amir", "atefe", "rezvan",
////    "baran",
////    "fahime" };
//var name1 =
//   new List<string> { "setayesh", "fatemeh", "amir", "atefe", "rezvan",
//    "baran",
//    "fahime" };
//start:
//var rnd = new Random();
////var i=rnd.Next(name1.Length);
//var i = rnd.Next(name1.Count());
//WriteLine(name1[i]);
//ReadLine();
//goto start;

//36
//int[] numbers = { 8, 11, 4, -3, 6, -11, 10 };
////var numbers =new List<int> { 8, 11, 4, -3, 6, -11, 10 };
//WriteLine(numbers.Max());
//WriteLine(numbers.Min());
//WriteLine(numbers.Sum());
//WriteLine(numbers.Average());

//37
//var names = new List<string>{
//        "setayesh",
//        "fatemeh",
//        "amir",
//        "atefe",
//        "rezvan",
//        "baran",
//        "fahime",
//        "amir"};

//WriteLine(names.First());
//WriteLine(names.Last());
//WriteLine(names.Contains("fatemeh"));
//WriteLine(names.Contains("reza"));
//names.Clear();
//WriteLine(names.Count());
//WriteLine(names.);

//38
//var names = new List<string>{
//        "setayesh",
//        "fatemeh",
//        "amir",
//        "atefe",
//        "rezvan",
//        "baran",
//        "fahime",
//        "amir"};
//Write("enter your name : ");
//var a =ReadLine();
//if    (names.Contains(a))
//    names.Remove(a);
//else 
//    names.Add(a);
//WriteLine(Join(", ", names));
//WriteLine(names);


//38
//var names = new List<string>();
//WriteLine(Join(", ", names));
////1
////names.Add("sara");
//////WriteLine(Join(",", names.Append("amir")));
////names.Insert(0, "amir");
////names.Insert(1, "narges");
////2
//names.AddRange(new List<string> { "ali", "ava" });
//names.InsertRange(1, new List<string> { "maryam", "arad" });

//WriteLine(Join(", ", names));


//39
//var names = new List<string> { "amir", "narges", "sara", "amir" };
//WriteLine(Join(", ", names));
//////1
//////names.Remove("amir");
////names.RemoveAt(3);
//////
/////2
////names.RemoveRange(1, 2);
/////
//WriteLine(Join(", ", names));

//40 lambda
//var numbers =
//    new List<double> { 8, 12.5, 15, 14, 18.5, 2, 3, 7.25, 12 };

////var result = numbers.Where(n => n >= 15);
////var result = numbers.Where(n => n >= 10 && n <= 15);
////var result = numbers.Where(n => n % 2 == 0);
////WriteLine(Join(", ", result));

//var result = numbers.FirstOrDefault(n => n > 10);
//WriteLine(result);

//41
//var names = new List<string> { "amir", "narges", "sara"  };

//Write("Enter:");
//var s=ReadLine();
//var result = names.Where(n => n.Contains(s)).ToList();
//WriteLine(Join(",", result));

//var name2 = new List<string> { "bar", "rez" };
//name2.AddRange(result);
//name2.Sort();
//WriteLine(Join(",", name2));

//42
//var list =
//    new List<int> { 5, 11, 6, 12, 16, 3, 1, 15, 21, 11, 4, 11 };

////1
////var result = list.Where(n => n < 10).Count();
////var result = list.Count(n => n < 10);
////WriteLine(result);
////2
////var result=list.RemoveAll(x => x == 11);
////WriteLine(result);
////WriteLine(Join(", ",list));
////3
//var avg = list.Average();
//WriteLine(avg);
//list.RemoveAll(l => l > avg);
//WriteLine(Join(", ", list));


//43
//var names = new List<string> { "setayesh", "rezvan", "amir" };
//var numbers = new List<string> { "911", "930", "990" };
////Random rnd = new Random();
////var index=rnd.Next(names.Count);
//var index = new Random().Next(names.Count);
//WriteLine(numbers[index]);
//WriteLine(names[index]);

//44
//var names = new List<string>{
//        "setayesh",
//        "fatemeh",
//        "atefe",
//        "rezvan",
//        "baran",
//        "fahime",
//        "amir"};
//Start:
//var rnd=new Random();
//var index=rnd.Next(names.Count);
//WriteLine(names[index]);
//names.RemoveAt(index);
//goto  Start;    

//45
////for (int i = 1; i<=100; i++)
//for (int i = 2; i <= 100; i += 2)
//{
//    Write(i + "\t");
//}

//46
//for (int n = 1; n <= 100; n++)
//{
//    if (n % 2 == 0)
//        Write(n + "\t");
//}

//47
//var names = new List<string>{
//        "setayesh",
//        "fatemeh",
//        "atefe",
//        "rezvan",
//        "baran",
//        "fahime",
//        "amir"};
//var len = names.Count;
//for (int i = 0; i < len; i++)
//{
//    var index = new Random().Next(names.Count);
//    WriteLine(names[index]);
//    names.RemoveAt(index);
//}

//48
//for(;true ; )
//while (true)
//{
//    var i = new Random().NextSingle();//float
//    Write(i + "\t");
//}

//49
//var names = new List<string> { "baran", "rezvan", "atefeh", "nazanin" };
//while (0 < names.Count)
//{
//    var rnd = new Random();
//    var index = rnd.Next(names.Count);
//    WriteLine(names[index]);
//    names.RemoveAt(index);
//}

//50
//for (int i = 100; i > 0; i--)
//{
//    Write(i + "\t");
//}

//51
//for (int i = 0; i < 5; i++)
//{
//    var n = new Random().Next(1000, 10000);
//    if (n % 2 == 0)
//        WriteLine(n);
//}

//52
//for (int i = 0; i < 5; i++)
//{
//rnd:
//    var n = new Random().Next(1000, 10000);
//    if (n % 2 == 0)
//        WriteLine(n);
//    else
//        goto rnd;
//}

//53
//for (int i = 0; i < 5; i++)
//{
//      //1=> 00000001, ~1=> 11111110 
//    var n = new Random().Next(1000, 10000) & ~1;
//    WriteLine(n);
//}

//54
//int i = 0;
//while (i < 5)
//{
//    var n=new Random().Next(1000,10000);
//    if(n%2==0)
//    {
//        WriteLine(n);
//        i++;
//    }
//}

//55
//var target = new Random().Next(1, 101);
//var guess = 0;

//while (guess != target)
//{
//    Write("guess : ");
//    guess = int.Parse(ReadLine());

//    if (guess < target)
//        WriteLine("go up");
//    else if (guess > target)
//        WriteLine("go down");
//    else /*if (guess == target)*/
//        WriteLine("win");
//}

//56
//Write("row : ");
//var n = int.Parse(ReadLine());
//Write("column : ");
//var m = int.Parse(ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= m; j++)
//    {
//        Write(i * j + "\t");
//    }
//    WriteLine();
//}

//57
//var target = new Random().Next(1, 101);
//var guess = 0;

//for (int i=1; i<=5; i++)
//{
//    Write("guess : ");
//    guess = int.Parse(ReadLine());

//    if (guess < target)
//        WriteLine("go up");
//    else if (guess > target)
//        WriteLine("go down");
//    else if (guess == target)
//    {
//        WriteLine("win");
//        break;
//    }
//}
//if (guess != target)
//    WriteLine($"lose, target : {target}");


//58
//for (int i = 1; i < 10; i++)
//{
//    //if (i == 5)
//    if (i % 2 == 0)
//        //break;
//        continue;

//    WriteLine(i);
//}

//59
//BackgroundColor = Green;
//SetCursorPosition(20, 5);//(left=character, top=line)
//Write("  ");

//ReadLine();

//60
//var count = 0;
//List<int>numbers = new List<int> { 7, 3, 11, -2, 8, 9, 5};
//for (int i = 0; i < numbers.Count; i++)
//{
//    for (int j = i+1; j < numbers.Count; j++)
//    {
//        if (numbers[i] > numbers[j])
//        {
//            int temp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = temp;

//        }
//        count++;
//    }
//}
//WriteLine(count);
//Write(Join(" ", numbers));


//61
//WriteLine("enter number : ");
//int number=int.Parse(ReadLine());
//while (number > 0)
//{
//    WriteLine(number % 10);
//    number = number / 10;
//}

//62
//WriteLine("Enter your word : ");
//var word = ReadLine();
//for (int i = 0; i < word?.Length; i++)
//{
//    if( i % 2 == 0)
//    {
//        Write(char.ToUpper(word[i]));
//        //Write(word[i].ToString().ToUpper());
//    }
//    else
//    {
//        Write(char.ToLower(word[i]));
//        //Write(word[i].ToString().ToLower());
//    }
//}

//63
//var list1 = new List<int> { 1, 5, 7, -3, 11, 9 };
//var arr1 = new int[] { 1, 5, 7, -3, 11, 9 };
//var str1 = "hello csharp";

//1
//foreach(var item in list1)
//{
//    WriteLine(item);
//}

//2
//foreach (var i in arr1)
//{
//    if (i > 7)
//        WriteLine(i);
//}

//3
//foreach(var ch in str1)
//{
//    Write((char)(ch+15));
//}

//64
//var str = "     hello world, Csharp     ";
//WriteLine(str);
//WriteLine(str.Length);
//WriteLine(str.Trim());
//WriteLine(str.Trim().Length);
//WriteLine(str.ToUpper());
//WriteLine(str.ToLower());
//WriteLine(str.Replace('o', '*'));
//WriteLine(str.Replace("hello", "hi"));
//WriteLine(str.Contains("hello"));
//WriteLine(str.Contains("hi"));
//WriteLine(str.IndexOf("o"));
//WriteLine(str.LastIndexOf("o"));
//WriteLine(str.IndexOf("world"));
//WriteLine(str.Trim().Substring(0, 5));

//var words=str.Trim().Split(' ');
//Write(Join("\n", words));
//

//65
//start:
//Write("enter number : ");
//var n = ReadKey();

//WriteLine();
//WriteLine(n);
//WriteLine(n.Key);
//WriteLine(n.KeyChar);
//WriteLine((int)n.KeyChar);

//goto start;

//66
//string number = "";
//while (number.Length < 11)
//{
//    Write($"phone : {number}");
//    var n=ReadKey();
//    if(n.KeyChar>=48 && n.KeyChar <= 58)
//    {
//        number += n.KeyChar;
//    }
//    Clear();
//}

//WriteLine(number);
//WriteLine("end");


//67
//Write("number : ");
//var n = int.Parse(ReadLine());

//var result = n % 2 == 0 ? "even" : "odd";
//Write(result);

//68
//Write("color : ");
//var color = ReadLine()?.ToLower();

//var result = (color) switch
//{
//    "red" => "stop",
//    "green" => "go",
//    "yellow" => "slow",
//    _ => "alarm"
//};

//Write(result);

//69
//Write("number : ");
////var n = int.Parse(ReadLine());
////var n = float.Parse(ReadLine());
//float.TryParse(ReadLine(), out var n);

//Write(n*n);

//70 binary search

//var number = new List<int> { 12, 8, -2, 5, 3 };
////number = number.OrderBy(x => x).ToList();
//number.Sort();
//WriteLine(Join("  ", number));

//WriteLine("enter your number:");
//var usernum = int.Parse(ReadLine());

//int low = 0;
//int high = number.Count - 1;
//while (low <= high)
//{
//    int mid = (low + high) / 2;

//    if (usernum == number[mid])
//    {
//        WriteLine($"number found in : {mid} index");
//        return;
//    }
//    else if (usernum < number[mid])
//        high = mid - 1;
//    else
//        low = mid + 1;
//}
//WriteLine("number did not fond");

//71
//var numbers = new List<int> { 12, 8, -2, 5, 3 };
//numbers.Sort();
//WriteLine(Join(" ", numbers));

//Write("search number : ");
//var search = int.Parse(ReadLine());
//var result = numbers.BinarySearch(search);

//if (result >= 0) 
//    Write($"number found in : {result} index");
//else
//    Write("not found");



//72
//Write("number : ");

//try
//{
//    var n = int.Parse(ReadLine());
//    WriteLine(100 / n);
//}
//catch (Exception error)
//{
//    //throw;
//    //WriteLine("error");
//    //WriteLine(error);
//    WriteLine(error.Message);
//}

//Write("end");

//73
//Write("write: ");
//var s = ReadLine();
//WriteLine(s?.Trim().Split(',')[0]);

////74
//var str = "Hello World, Csharp";
//foreach (var Ch in str)
//{
//    if (Ch == ',')
//        break;
//    else
//        Write(Ch);
//}

//75
//var str = "Hello World, Csharp";
//var index = str.IndexOf(',');
//Write(str.Substring(0, index));

//76
//WriteLine(Math.Pow(2, 5));
//WriteLine(Math.Sqrt(64));
//WriteLine(Math.Max(5, 7));
//WriteLine(Math.Min(5, 7));
//WriteLine(Math.PI);
//WriteLine(Math.E);
//WriteLine(Math.Abs(-5));
//WriteLine(Math.Sin(90));
//WriteLine(Math.Cos(90));
//WriteLine(Math.Log2(256));
//WriteLine(Math.Log10(10000));
//WriteLine(Math.Round(12.234324,2));
//WriteLine(Math.Round(12.235324,2));
//WriteLine(Math.Round(12.237324,2));
//WriteLine(Math.Round(12.237324));
//WriteLine(Math.Floor(13.813131231123123m));

//77
//var str = "hello world, csharp or python";
//var word = "or";

//var index = 0;
//while (index < str.Length)
//{
//    var i = str.IndexOf(word);
//    if (i >= 0)
//        //for (int n = 0; n < word.Length; n++)
//        {
//            BackgroundColor = Green;
//            Write(str[index]);
//            index++;
//        }
//    else
//    {
//        BackgroundColor = Black;
//        Write(str[index]);
//        index++;
//    }
//}
