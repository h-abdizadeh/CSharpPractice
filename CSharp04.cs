using static System.Console;
using static System.String;
using static System.Array;//25
using static System.ConsoleColor;

//*Console.*/WriteLine("Hello, World!");

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

//22
//string[] names = new string[5];

//A:
//Clear();
//Write("enter index 0 to 4 : ");
//var index = int.Parse(ReadLine());

////if (index < 0 || index > 4) return;
//if (index < 0 || index > 4) goto A;

//Write("enter name : ");
//var name = ReadLine();

//names[index] = name;

//Write(Join("\n", names));

//23
//int[] myArray = { 5, 9, -3, 8, 11 };
//WriteLine(myArray.Length);
//WriteLine(myArray.Max());
//WriteLine(myArray.Min());
//WriteLine(myArray.Sum());
//WriteLine(myArray.Average());
//WriteLine(myArray.First());
//WriteLine(myArray.Last());
//WriteLine(myArray.Contains(11));
//WriteLine(myArray.Contains(2));
//WriteLine(myArray.Rank);
//WriteLine(myArray.Count());
//WriteLine(myArray.Count(n => n > 5));

//24
//int[] myArray = { 5, 9, -3, 8, 11, 9, 8 };
//int[] tmpArray = { 4, 5, 6 };
//WriteLine(Join(" ", myArray.Concat(tmpArray)));
//WriteLine(Join(" ", myArray.Order()));//dotnet 7.0
//WriteLine(Join(" ", myArray.OrderBy(n => n)));
//WriteLine(Join(" ", myArray.OrderByDescending(n => n)));
//WriteLine(Join(" ", myArray.Distinct()));
//WriteLine(Join(" ", myArray.Append(20)));
//WriteLine(Join(" ", myArray.Prepend(10)));
//WriteLine(Join(" ", myArray));
//WriteLine(Join(" ", myArray.Reverse()));
////WriteLine(Join(" ", myArray.Select(n => n > 5)));
//WriteLine(Join(" ", myArray.Where(n => n > 5)));

//25 - using Array
//string[] namesArray = { "amir", "sara", "narges", "reza" };
////Array.Sort(namesArray);
////Sort(namesArray);
////Sort(array: namesArray, index: 1, length: 2);
////Reverse(namesArray);
////Fill(namesArray, "amir");
////Clear(namesArray);
////Resize(ref namesArray, 15);
////Resize(ref namesArray, 2);
////Resize(ref namesArray, namesArray.Length + 1);

//Write(Join(",", namesArray));

//26 - using Array
//string[] namesArray = { "amir", "sara", "narges", "reza" };
//////var result = Exists(namesArray, n => n is "sara");//==
//////var result = Exists(namesArray, n => n is "ali");
//////var result = FindIndex(namesArray, n => n is "narges");
////var result = FindIndex(namesArray, n => n is "ali");//-1

////Write(result);
//var result = FindAll(namesArray, n => n.Contains("e"));
//Write(Join(", ", result));

//27
//string[] namesArray = { "amir", "sara", "narges", "reza" };
//Write("enter name : ");
//var name = ReadLine();

//if (namesArray.Contains(name))
//{
//    var index = FindIndex(namesArray, n => n == name);
//    namesArray[index] = "";// string.Empty;
//}
//else
//{
//    Resize(ref namesArray, namesArray.Length + 1);
//    namesArray[namesArray.Length-1] = name;
//}
//Write(Join(", ", namesArray));

//28
//Range range = 1..10;
//WriteLine(range.Start);
//WriteLine(range.End);

//29
////List<string> list1 = new List<string>();
//var list1 = new List<string>();
//var list2 = new List<int> { 1, 5, 9, 0, -3, 10 };

//WriteLine(list1.Count);
//WriteLine(list2.Count);
//WriteLine(list2[4]);
//list1.Add("farda");
//var tmp =
//    new List<string> { "dotnet", "csharp", "dotnet" };
//list1.AddRange(tmp);
//list1.Insert(1, "console");
//list1.Insert(list1.Count, "practice");
//list2.InsertRange(3, list2);
////list2.RemoveAt(3);//index
////list1.Remove("dotnet");//value
////list1.RemoveAll(a => a == "dotnet");
////list1.RemoveAll(n=>n.Contains("s"));
//list1.RemoveRange(2, 3);//(index,count)
//WriteLine(Join(" ", list1));
//WriteLine(Join(" ", list2));

//30
//start:
//Clear();

//var rnd = new Random();
//WriteLine(rnd.Next());
//WriteLine(rnd.Next(100));//0 -> 99
//WriteLine(rnd.Next(50,100));//50 -> 99
//WriteLine(rnd.NextDouble());
//WriteLine(rnd.NextInt64());
//WriteLine(rnd.NextSingle());
//WriteLine(rnd.Next(1000,10000));


//ReadKey();
//goto start;

//31
//var namesList =
//    new List<string> { "amir", "sara", "narges", "reza" };

//Write("enter name : ");
//var name = ReadLine();

//if (namesList.Contains(name))
//{
//    namesList.Remove(name);
//}
//else
//{
//    namesList.Add(name);
//}

//Write(Join(", ", namesList));


//32
//var namesList =
//    new List<string> { "amir", "sara", "narges", "reza" };

//var rnd = new Random();
//var index = rnd.Next(namesList.Count);//4

//Write(namesList[index]);

//33
//var mylist = new List<int> { 5, 9, 8, 1, -1, 7, 5, 8, 2 };

////binary search
////mylist.Sort();//important in binarysearch
////WriteLine(mylist.BinarySearch(7));
////WriteLine(mylist.BinarySearch(10));

////take
////var result = mylist.Take(3);
////var result = mylist.TakeLast(3);
////var result = mylist.Take(3..6);//range
//var result = mylist.TakeWhile(n => n > 0);
//WriteLine(Join(" ", result));

//34
////queue
//var myQueue = new Queue<int>();
//myQueue.Enqueue(5);
//myQueue.Enqueue(8);
//myQueue.Enqueue(-3);
//WriteLine(myQueue.Dequeue());
//WriteLine(myQueue.Peek());

//Write(Join(" ", myQueue));

//stack
//var myStack = new Stack<int>();
//myStack.Push(5);
//myStack.Push(8);
//myStack.Push(-3);
//WriteLine(myStack.Pop());
//WriteLine(myStack.Peek());

//Write(Join(' ', myStack));

//35 list -> queue
//var queuelist = new List<int>();
////enqueue
//queuelist.Add(10);
//queuelist.Add(5);
//queuelist.Add(7);
//WriteLine(Join(' ', queuelist));

////dequeue
//queuelist.RemoveAt(0);
//WriteLine(Join(' ', queuelist));

////peek
//WriteLine(queuelist[0]);

//36 list -> stack
//var stacklist = new List<int>();
////push
//stacklist.Add(1);
//stacklist.Add(7);
//stacklist.Add(5);
//WriteLine(Join(' ', stacklist));

////pop
//stacklist.RemoveAt(stacklist.Count - 1);
//WriteLine(Join(' ', stacklist));

////peek
//WriteLine(stacklist[stacklist.Count - 1]);

//37 for
////for (int i = 1; i <= 10; i++)
////for (int i = 1; i <= 10; i+=2)
//    Write("farda");

//38
//for (int i = 1; i <= 10;)
//    WriteLine(i++);

//39
//for (; true;)
//{
//    var n = new Random().Next();
//    Write($"{n}\t");

//    if (n % 5 is 0 /*&& n % 7 is 0*/)
//        break;
//}

//40
//for (int i = 10; i <= 98; i += 2)
//    Write($"{i} ");
//for (int i = 10; i <= 98; i++)
//{
//    if (i % 2 is 0)
//        Write($"{i} ");
//}

//41
//Write("enter number : ");
//var n = int.Parse(ReadLine());
//var result = 0;
//for(int i = 1; i <= n; i++)
//{
//    //result = result + i;
//    result += i;
//}
//Write($"sum is : {result}");

//42
////BackgroundColor = Red;
////WriteLine("                                             ");
////BackgroundColor = Black;
//var colorlist =
//    new List<ConsoleColor> { Red, Green, Yellow, White, Gray, Cyan };

////for (int i = 1; i <= 10; i++)
//for (int i = 1; true; i++)
//{
//    var index = new Random().Next(colorlist.Count);
//    BackgroundColor = colorlist[index];
//    WriteLine("                                             ");

//    Thread.Sleep(100);
//    Beep(new Random().Next(250,1500), new Random().Next(100, 1000));
//    if(i==20)
//    {
//        BackgroundColor = Black;
//        Clear();
//        i = 0;
//    }
//}
//BackgroundColor = Black;

//43
//for (; true;)
//{
//    var key = ReadKey();
//    WriteLine((int)key.KeyChar);

//    if (key.KeyChar == 'a')
//        Beep(450, 100);

//    if (key.KeyChar == 'l')
//        Beep(900, 100);

//    if (key.KeyChar == 's')
//        Beep(250, 100);

//    if (key.KeyChar == 'k')
//        Beep(1500, 100);
//}

//44
//ulong a = 0, b = 1;
//Write($"{a} {b} ");
//ulong c = a + b;
//for (int i = 1; i <= 5000000; i++)
//{
//    Write($"{c} ");

//    a = b;
//    b = c;
//    c = a + b;
//}
