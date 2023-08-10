using static System.Console;

//1
//Write("enter number : ");
//double n = double.Parse(ReadLine());

//Write("enter number : ");
//double m = double.Parse(ReadLine());

//WriteLine("{0} + {1} = {2}", n, m,n+m);


//2
//string password = "abc123";

//Write("enter password : ");
//string userPass = ReadLine();

//if (password == userPass)
//{
//    BackgroundColor = ConsoleColor.Green;
//    ForegroundColor = ConsoleColor.Black;
//    Clear();
//    Write("Yes");
//}
//else
//{
//    BackgroundColor = ConsoleColor.DarkRed;
//    ForegroundColor = ConsoleColor.White;
//    Clear();
//    WriteLine(userPass);
//    Write("No");
//}


//3
//BackgroundColor = ConsoleColor.Green;
//Write("     ");
//BackgroundColor = ConsoleColor.White;
//Write("     ");
//BackgroundColor = ConsoleColor.Blue;
//WriteLine("     ");
//BackgroundColor = ConsoleColor.Yellow;
//Write("     ");
//BackgroundColor = ConsoleColor.DarkCyan;
//Write("     ");
//BackgroundColor = ConsoleColor.Red;
//WriteLine("     ");

//ReadKey();


//4
//Write("enter number : ");
//int n = int.Parse(ReadLine());

////if (n >= 0)
////    Write("positive");
////else
////    Write("negative");

//var result = n >= 0 ? "positive" : "negative";
//Write(result);

//5
//int a = 5;
//string str;

//str = "ali";

//var n = 7;
////n = "reza";

//var m = "amir";
////m = 3;
//m = "arman

//6
//START:
//Write("enter number : ");
//var n = int.Parse(ReadLine());

//if (n >= 0)
//    WriteLine("+");
//else
//    WriteLine("-");

//WriteLine("<-[press any key to continue]->");
//ReadKey();
//Clear();
//goto START;


//7
//START:
//Write("enter color : ");
//var color = ReadLine();

//if(color=="red")
//{
//    Write("STOP<>");
//}
//else if(color=="green")
//{
//    Write("GO->");
//}
//else if(color=="yellow")
//{
//    Write("SLOW!");
//}
//else
//{
//    //Write("alarm");
//    Beep(350, 2000);
//}
//ReadKey();
//Clear();
//goto START;

//8
//START:
//Write("enter number : ");
//double n = double.Parse(ReadLine());

//if (n < 10 && n>-10)
//    WriteLine(1);
//else if (n < 100 && n>-100)
//    WriteLine(2);
//else if (n < 1000 && n > -1000 )
//    WriteLine(3);
//else
//    WriteLine("invalid");

////ReadKey();
//goto START;

//9
//START:
//Write("enter number : ");
//int n=int.Parse(ReadLine());

//if (n >= 10 || n < 0)
//    WriteLine("OK");
//else
//    WriteLine("invalid");

//goto START;

//10
//START:
//Write("enter number : ");
//int n=int.Parse(ReadLine());

//if (n < 10 && n >= 0)
//    WriteLine("invalid");
//else
//    WriteLine("OK");

//goto START;

//11
//START:
//try
//{
//    Write("enter number : ");
//    int n = int.Parse(ReadLine());

//    WriteLine(n * n);
//}
//catch (Exception error)
//{
//    //1
//    //throw;
//    //2
//    //WriteLine("wrong");
//    //3
//    //WriteLine(error);
//    //4
//    WriteLine(error.Message);
//}
//goto START;


//12
//int[] numbers = new int[5];
//string[] names = { "ali", "amir", "reza", "sadegh", "arman" };

//WriteLine(numbers[0]);
//numbers[0] = 12;
//WriteLine(numbers[0]);

//WriteLine(names[3]);
////WriteLine(names[5]);
//Write("enter new name : ");
//names[3] = ReadLine();
//WriteLine(names[3]);

//WriteLine(numbers.Length);
//WriteLine(names.Length);
//WriteLine((new int[5]).Length);

//WriteLine(names[names.Length - 1]);

////12+1
////List<string> names1 = new List<string>();
//var names1 = new List<string>();
//var names2 = 
//    new List<string> { "ali", "amir", "reza", "mahdi","amir" };

////WriteLine(names2[2]);
//////names2[2] = "arman";
////names2[2] = names2[3];
////WriteLine(names2[2]);
////WriteLine(names2.ElementAt(1));
////WriteLine(names1.Count);
//WriteLine(names2.Count);
////names2.Add("arman");
////names2.Insert(1, "sadegh");
////var names3 = new List<string> { "arman", "sadegh" };
////names2.AddRange(names3);
////names2.RemoveAt(2);
////names2.Remove("amir");
////names2.RemoveRange(2,2);
////names2.RemoveAll(n => n == "amir");
//WriteLine(names2.Count);
//WriteLine(names2.Where(n => n == "amir").First());

//14
//START:
//var names =
//    new List<string> { "ali", "amir", "reza", "mahdi", "arman" };

////int index = new Random().Next();
////int index = new Random().Next(50);
////int index = new Random().Next(40,50);
//int index = new Random().Next(names.Count);//.Next(0,names.Count);

//WriteLine(index);
//WriteLine(names[index]);

//ReadKey();
//goto START;

//15
//var names =
//    new List<string> { "ali", "amir", "reza", "mahdi", "arman" };

//Write("enter index : ");
//var i = int.Parse(ReadLine());
//Write("enter index : ");
//var j = int.Parse(ReadLine());

//WriteLine("{0}->{1} , {2}->{3}", i, names[i], j, names[j]);
////WriteLine(i + "->" + names[i] + " , " + j + "->" + names[j]);

//var temp = names[i];
//names[i] = names[j];
//names[j] = temp;

//WriteLine("{0}->{1} , {2}->{3}", i, names[i], j, names[j]);

//16
//for (int i = 0; i < 100; i++)
//for (int i = 0; i < 100; i+=3)
//for (int i = 0; i < 100; i--)
//for (int i = 100; i > 0; i--)
//{
//    Write("{0}, ", i);
//}


//17
//Write("enter number : ");
//var n = int.Parse(ReadLine());

////for (int i = 0; i < n; i+=2)
//for (int i = 0; i < n; i++)
//{
//    if (i % 2 == 0)
//        Write("{0}, ", i);
//}

//18
//Start:
//var names =
//    new List<string> { "ali", "amir", "reza", "mahdi", "arman" };

//Write("enter number : ");
//var input = ReadLine();
//if (!int.TryParse(input, out int a) || a > names.Count)
//{
//    WriteLine("invalid number!");
//    goto Start;
//}

//for (int i = 0; i < a; i++)
//{
//    int n = new Random().Next(names.Count);//Next(0,5)
//    //WriteLine(n);
//    WriteLine(names[n]);

//    names.RemoveAt(n);
//}

//WriteLine("------------");

//ReadKey();
//goto Start;
