using System.Collections;
using System.Speech.Synthesis;
using static System.Console;

//1
//Write("enter number : ");
//double a = double.Parse(ReadLine());
//Write("enter number : ");
//double b = Convert.ToDouble(ReadLine());

//WriteLine("{0} + {1} = {2}", a, b, a + b);
//WriteLine("{0} - {1} = {2}", a, b, a - b);
//WriteLine("{0} * {1} = {2}", a, b, a * b);
//WriteLine("{0} / {1} = {2}", a, b, a / b);

//2
//string password = "abc123";
//var password = "abc123";
//Write("enter password : ");
//var userPass = ReadLine();

//if (password == userPass)
//{
//    BackgroundColor = ConsoleColor.Green;
//    ForegroundColor = ConsoleColor.Black;
//    Clear();
//    Write("yes");
//}
//else
//{
//    BackgroundColor = ConsoleColor.DarkRed;
//    ForegroundColor = ConsoleColor.DarkYellow;
//    Clear();
//    Write("wrong");
//}

//3
//Write("enter number : ");
//int n =int.Parse(ReadLine());

//if (n>=0)
//{
//    Write("+");
//}
//else
//{
//    Write("-");

//}

//4
//START:
//Clear();
//Write("enter color : ");
//var color = ReadLine().ToLower();

////WriteLine(color.ToLower());
////WriteLine(color.ToUpper());
////WriteLine(color);

//if (color == "red")
//    WriteLine("STOP<>");
//else if (color == "green")
//    WriteLine("GO->");
//else if (color == "yellow")
//    WriteLine("SLOW!");
//else
//    Beep(400, 500);

//ReadKey();
//goto START;

//5
//START:
//Write("enter number : ");

//int n=int.Parse(ReadLine());

//if (n < 10)
//    Write(1);
//else if(n<100)
//    Write(2);
//else if(n<1000)
//    Write(3);
//else
//    Write("OUT OF RANGE");

//ReadKey();
//goto START;

//6
//START:
//Write("enter number : ");
//int a = int.Parse(ReadLine());
////a = a / 10;
//a /= 10;
//if (a < 1 && a > -1)
//    WriteLine(1);
//else if (a < 10 && a > -10)
//    WriteLine(2);
//else if (a < 100 && a > -100)
//    WriteLine(3);
//else
//    WriteLine("invalid");

//ReadKey();
//goto START;

//7
//int a = int.Parse(ReadLine());
////if (a < 0) a *= -1;
////a = a < 0 ? a * -1 : a;
//a *= a < 0 ? -1 : 1;
//WriteLine(a.ToString().Length);


//8
//Write("enter number : ");
//int n=int.Parse(ReadLine());

////OR
//if (n >= 10 || n <= -10)
//    WriteLine("Ok");
//else
//    WriteLine("NO");

////AND
//if (n < 10 && n > -10)
//    WriteLine("NO");
//else
//    WriteLine("OK");

//9
//START:
//try
//{
//    BackgroundColor = ConsoleColor.Blue;
//    ForegroundColor = ConsoleColor.White;
//    Write("enter number : ");
//    int n = int.Parse(ReadLine());
//    WriteLine(n * n);
//}
//catch (Exception error)
//{
//    WriteLine(error.Message,
//              BackgroundColor=ConsoleColor.Red,
//              ForegroundColor=ConsoleColor.Black);

//    //WriteLine(error.Message);
//    //WriteLine(error);
//    //WriteLine("error");
//	//throw;
//}

//goto START;


//10
//int[] numbers = new int[5];
//string[] names = 
//    { "ali", "reza", "sara", "maryam", "amir" };
//WriteLine(numbers[2]);
//numbers[2] = 5;
//WriteLine(numbers[2]);
//WriteLine(names[3]);
//names[3] = "narges";
//WriteLine(names[3]);
//WriteLine(names[0]);
//WriteLine(names[4]);
//names[0]=names[4];
//WriteLine(names[0]);
//WriteLine(names[4]);
//WriteLine(names[5]);//outside the bound
//WriteLine(names.Length);
//WriteLine(names[names.Length-1]);

//11
//START:
//Write("enter text : ");
//var text = ReadLine();
//WriteLine(text.Length);

//goto START;


//11
//START:
//string[] names =
//    { "ali", "reza", "sara", "maryam", "amir" };

//Write("enter index 0 -> {0} : ", names.Length - 1);
//int i = int.Parse(ReadLine());
//Write("enter index 0 -> {0} : ", names.Length - 1);
//int j = int.Parse(ReadLine());

//int n = names.Length;
//if (i>=0 && i<n && j>=0 && j<n)
//{
//    WriteLine("{0}->{1} {2}->{3}",
//                i, names[i], j, names[j]);

//    var temp=names[i];
//    names[i]=names[j];
//    names[j]=temp;

//    WriteLine("{0}->{1} {2}->{3}",
//                i, names[i], j, names[j]);
//}
//else
//{
//    WriteLine("index outside the bound");
//}

//goto START;


//12
//var names1 = new List<string>();
//List<string> names1 = new List<string>();
//List<string> names2 =
//  new List<string> { "ali", "sara", "reza", "ali" };

//WriteLine(names2[1]);
//WriteLine(names2.ElementAt(2));
////WriteLine(names1.Count);
//WriteLine(names2.Count);
////names2.Add("maryam");
//names2.Insert(1, "sina");
//var temp = new List<string> { "arman", "maryam" };
//names2.AddRange(temp);
////names2.RemoveAt(1);
////names2.Remove("ali");
//names2.RemoveRange(1, 2);
//names2.RemoveAll(n => n == "ali");
//WriteLine(names2.Count);
//WriteLine(names2.Where(n => n == "ali").Count());

//12+1
//START:
//var names1 = new List<string>();
//var names2 =
//    new List<string> { "ali", "sara", "reza", "ali" };

//Write("enter name : ");
//var name = ReadLine();

//WriteLine(names2.Count);
//WriteLine(names1.Count);

//if(names2.Remove(name))
//    names1.Add(name);

//WriteLine(names2.Count);
//WriteLine(names1.Count);

//ReadKey();
//goto START;

//14
//for (int i = 1; i < 100; i++)
//{
//    if (i % 2 == 0)
//        Write("{0}, ", i);
//}

//15
//var names =
//    new List<string> { "ali", "sara", "reza", "ali" };

//for (int n = 0; n < names.Count; n++)
//{
//    WriteLine(names[n]);
//}

//16
//var names =
//    new List<string>
//    { "ali", "sara","ali", "reza", "ali" };

//for (int i = 0; i < names.Distinct().Count(); i++)
//{
//    var n = names
//            .Where(x => x == names[i])
//            .Count();

//    WriteLine("{0} -> {1}", names[i], n);
//}

//17
//Write("enter number : ");
//var n = int.Parse(ReadLine());

//int sum =0;
//for (int i = 1; i < n; i++)
//{
//    sum=sum+i;
//    //sum += i;
//}
//WriteLine(sum);

//18
//START:
//Random r = new Random();
////WriteLine(r.Next());
////WriteLine(r.Next(100));//Next(0,100)
//WriteLine(r.Next(10,100));

//ReadKey();
//goto START;

//////////////////////////////////////// 19 ////////////////////////////////////////////
//START:
//var names = new List<string>()
//{
//    "mobin",
//    "maryam",
//    "sara",
//    "shabnam",
//    "arshia",
//    "ali reza",
//    "ali asghar",
//    "farzin",
//    "shayan"
//};

//var index = new Random().Next(names.Count);
//WriteLine(names[index]);

//ReadKey();
//goto START;
//////////////////////////////////////// 19 ////////////////////////////////////////////

//20
//START:
//var names = new List<string>()
//{
//    "mobin",
//    "maryam",
//    "sara",
//    "shabnam",
//    "arshia",
//    "ali reza",
//    "ali asghar",
//    "farzin",
//    "shayan"
//};
//Write("enter number : ");
//var n = int.Parse(ReadLine());

//for(int i = 1; i <= n; i++)
//{
//    var index = new Random().Next(names.Count);
//    WriteLine(names[index]);
//    names.RemoveAt(index);
//}

////ReadKey();
//goto START;

//21
//int i = 1;

//while (i<10)
//{
//    //Write("{0}, ", i++);
//    Write("{0}, ", ++i);
//    //i++;    
//}

//Start:
//Write("enter number : ");
//int n = int.Parse(ReadLine());

//1
//while (n > 0)
//{
//    WriteLine(n % 10);
//    n = n / 10;
//}

//2
//var nStr = n.ToString();
//var nStrArr = nStr.ToCharArray();

//for (int i = 0; i < nStrArr.Length; i++)
//{
//    WriteLine(nStrArr[i]);
//}

//goto Start;

//22
//ulong
//int a = 0;
//int b = 1;
//Write("{0}, {1}, ", a, b);
//for (int i = 0; i < 10; i++)
//{
//    int c = a + b;
//    Write("{0}, ", c);
//    a = b;
//    b = c;
//}

//23
//int a = 0;
//int b = 1;
//Write("{0}, {1}, ", a, b);
//int c = a + b;
//while (c < 1000)
//{
//    Write("{0}, ", c);
//    a = b;
//    b = c;
//    c = a + b;
//}


//24
//int number = new Random().Next(1, 101);

//Start:
//Write("enter guess between 1 , 100 : ");
//int guess = int.Parse(ReadLine());

//if (guess > number)
//    WriteLine("down");
//else if (guess < number)
//    WriteLine("up");
//else
//{
//    WriteLine("winner");
//    goto End;
//}

//goto Start;

//End:
//WriteLine("end");

//25
//int number = new Random().Next(1, 101);
//int guess = 0;
//int turn = 5;
//var voice = new SpeechSynthesizer();
//voice.SetOutputToDefaultAudioDevice();
//while (number != guess && turn > 0)
//{
//    Write("enter guess between 1 , 100 turn {0} : ",turn);
//    guess = int.Parse(ReadLine());


//    if (guess > number)
//        //WriteLine("down");
//        voice.Speak("please go down");
//    else if (guess < number)
//        //WriteLine("up");
//        voice.Speak("please go up");

//    turn--;
//}

//if (guess == number)
//    //WriteLine("winner");
//    voice.Speak("you win");
//else
//    WriteLine("loser --> {0}", number);

//WriteLine("end");


//26
//Start:
//Write("enter number : ");
//int.TryParse(ReadLine(), out int a);
//var binary = "";
////while (a > 0)
//for (int i = 0; a > 0; i++)
//{
//    binary = (a % 2) + binary;
//    a = a / 2;
//}

//WriteLine(binary);
//goto Start;

//27
//var names = new List<string>()
//{
//    "mobin",
//    "maryam",
//    "sara",
//    "shabnam",
//    "arshia",
//    "ali reza",
//    "ali asghar",
//    "farzin",
//    "shayan"
//};

////for(int i = 0; i < names.Count; i++)
////{
////    WriteLine(names[i]);
////}
//foreach (var item in names)
//{
//    WriteLine(item);
//}
