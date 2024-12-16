namespace DemoSession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formatting
            //string formating
            //Equation : 4+3 =7 
            //Console.WriteLine("Equation : 4+3 =7");

            //string Message = "Equation : 4+3 =7";
            //Console.WriteLine(Message);

            //int X = 4, Y = 3;


            ////1-string Concatination
            //String Message = "Equation : " + X + " + " + Y + " = " + (X + Y);
            //Console.WriteLine(Message);

            ////String :Immuatable Datatype :Can't change its value after creation  


            //2.string Format

            //string Message = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);

            //String Interpolation
            //$:Manipilation

            //String Message = $"Equation : {X} + {Y} ={X+Y}";
            //Console.WriteLine(Message); 
            #endregion


            //Control statement
            #region Control Statement
            //control statement:1.conditional control statement (if statement,switch staement)
            //control statement:2.Loop control statement (for ,foreach ,while,do while)

            //Console.WriteLine("Hello world");
            //Console.WriteLine("Hello world");
            //Console.WriteLine("Hello world");
            //Console.WriteLine("Hello world");
            //Console.WriteLine("Hello world"); 
            #endregion

            //control statement:1.conditional control statement (if statement,switch staement)

            #region conditional
            #region EX01
            //Console.WriteLine("Enter month Number in the 1st quarter : ");
            //int MonthNumber = int .Parse(Console.ReadLine());

            //1->jan
            //2->fep
            //3->mar

            //Console.WriteLine("Jan");
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");

            //1.using if 
            //if (/Exression/)
            //{
            //    //body
            //    //code:this code that will be executed when the expresiion is true
            //}

            //if (false) 
            //{
            //    Console.WriteLine("Hello World");
            //}

            //if (MonthNumber==1)
            //{
            //    //code
            //    Console.WriteLine("Jan");
            //}

            //else if (MonthNumber == 2)
            //{
            //    //code
            //    Console.WriteLine("Feb");
            //}

            //else if (MonthNumber == 3)
            //{
            //    //code
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid MonthNumber");
            //}


            //using switch
            //switch(/Expression/)
            //{
            //    case :
            //code
            //Console.WriteLine("Hello world");
            //}

            //jump table 
            //O(1)
            //switch (MonthNumber)
            //{
            //    case 1:
            //        //code
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        //code
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        //code
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        //code
            //        Console.WriteLine("Inavlid Month Number");
            //        break;
            //}

            #endregion

            #region EX02
            //Console.WriteLine("Enter your name : ");
            //string Name = Console.ReadLine();

            ////Ahmed -> Hi Ahmed
            ////Ali -> Hi Ali
            ////Omar -> Hi omar
            ////Mariam -> Hi Mariam 
            ////Invalid Input 

            ////1.Using if
            //if (Name == "Ahmed" || Name=="ahmed")
            //{
            //    Console.WriteLine("Hi Ahmed");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine("Hi Ali");
            //}
            //else if (Name == "Omar" || Name=="omar")
            //{
            //    Console.WriteLine("Hi Omar");
            //}
            //else if (Name == "Mariam" || Name=="mariam")
            //{
            //    Console.WriteLine("Hi Mariam");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            ////Using switch
            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;

            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi Ali");
            //        break;

            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine("Hi Omar");
            //        break;

            //    case "Mariam":
            //    case "mariam":
            //        Console.WriteLine("Hi Mariam");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;

            //} 
            #endregion

            #region EX03
            //Console.WriteLine("Enter Your age : ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age > 18)
            //{
            //    Console.WriteLine("welcome");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine("Bye Bye");
            //}
            //else if (Age == 18)
            //{
            //    Console.WriteLine("Equal");
            //}

            //switch (Age>18)
            //{
            //    case true:
            //        Console.WriteLine("Welcome :)");
            //        break;

            //    case false:
            //        if (Age<18)
            //        {
            //            Console.WriteLine("Bye Bye");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Equals");
            //        }
            //        break;
            //}

            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine("Welcome");
            //        break;

            //    case < 18:
            //        Console.WriteLine("Bye bye");
            //        break;

            //    default:
            //        Console.WriteLine("Equals");
            //        break;
            //} 
            #endregion

            #region C# 07
            //object Input = new object();
            //Input = 1;
            //Input = "Ahmed";

            //switch (Input)
            //{
            //    case int X when X > 12:
            //        Console.WriteLine("Int Input");
            //        break;

            //    case int X when X < 12:
            //        Console.WriteLine("Int Input");
            //        break;

            //    case String S when S.Length > 12:
            //        Console.WriteLine("String Input");
            //        break;
            //} 
            #endregion

            #region C# 08
            //string Input=Console.ReadLine();

            ////1->option 1
            ////2->option 2
            ////3->option 3

            //switch (Input)
            //{
            //    case "1":
            //        Console.WriteLine("Option 1");
            //        break;

            //    case "2":
            //        Console.WriteLine("Option 2");
            //        break;

            //    case"3":
            //        Console.WriteLine("Option 3");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}

            ////switch Expression

            //Console.WriteLine(Input switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "OPtion 3",
            //    _ => " Invalid Option"
            //}); 
            #endregion
            #endregion

            //control statement:2.Loop control statement (for ,foreach ,while,do while)
            #region Loops
            //1.for loop

            //for(/statement */;/*expression (True - False) */; /*statement/)
            //{
            //    //body
            //    //code:This code that will be repeated
            //}

            //for (Console.WriteLine("Hello 01");true; Console.WriteLine("Hello 02"))
            //{
            //    Console.WriteLine("Hello world");
            //}

            //int X;
            //for (Console.WriteLine("Hello 01"); X <= 10 ; Console.WriteLine("Hello 02"))
            //{
            //    X++;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2.foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //console.writline(Number[0])
            //console.writline(Number[1])

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}

            //3.while
            //while (/Expression/) 
            //{
            //    //code
            //}

            //while (true) 
            //{
            //    Console.WriteLine("Hello world");
            //}
            //int i = 1;
            //while (i <=10) {
            //    Console.WriteLine("Hello world");
            //    i++;
            //}

            //do while

            //do
            //{
            //    //code
            //}
            //while (/Expression/);

            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}
            //while (i<=10);

            //2 4 6 8 19

            //int EvenNumber;
            //do
            //{
            //    Console.WriteLine("Even Number : ");
            //   // EvenNumber = int.Parse(Console.ReadLine()); //May throw Exception  
            //}
            //while (!int.TryParse(Console.ReadLine(), out EvenNumber) || EvenNumber%2 !=0);

            //Console.WriteLine(EvenNumber); 
            #endregion


            //string : Datatype (Reference Type):Heap
            //Immutable datatybe : can't change it's value after creation 

            //string S01;
            //Declare for Reference from 'string'
            //S01:can refer to object from type 'string'
            //S01 : Refer to Null

            //8 bytes will be allocated at stack for the reference "S01"
            //0 bytes will be allocated at Heap

            //S01 = new string("Ahmed");
            //new
            //1. Allocate the number of the bytes for the object at heap
            //2.Initialized the allocated bytes with the default value of the datatype
            //3.call user-defined constructor if exists
            //4. Assign The object  to the refernce S01

            //string Name1 = "Ahmed";
            //Console.WriteLine($"Name1:{Name1}");
            //Console.WriteLine($"Name1Hashcode : {Name1 .GetHashCode()}");

            //string Name2 = "Yassmin";
            //Console.WriteLine($"Name2:{Name2}");
            //Console.WriteLine($"Name2Hashcode : {Name2.GetHashCode()}");

            //Name2 = Name1;

            //Console.WriteLine("=======================================");

            //Console.WriteLine($"Name1:{Name1}");
            //Console.WriteLine($"Name1Hashcode : {Name1.GetHashCode()}");

            //Console.WriteLine($"Name2:{Name2}");
            //Console.WriteLine($"Name2Hashcode : {Name2.GetHashCode()}");

            //Name2 = "Ali";
            //Name2 = new string("Ali");
            ////This line will create New object
            //Name1 = "Hamada";

            //Console.WriteLine("=======================================");

            //Console.WriteLine($"Name1:{Name1}");
            //Console.WriteLine($"Name1Hashcode : {Name1.GetHashCode()}"); 


            //Console.WriteLine($"Name2:{Name2}");
            //Console.WriteLine($"Name2Hashcode : {Name2.GetHashCode()}");

            //string Message = "Hello";
            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"MessageHashCode : {Message.GetHashCode()}");

            ////Message="Ahmed";
            ////Message = new string("Ahmed");
            ////create new object
            //Message += "Ahmed";

            //Console.WriteLine();

            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"MessageHashCode : {Message.GetHashCode()}");


            //StringBuilder : Refernece type: Heap
            //Mutable Datatype : can change its Value  After Creation

            //StringBuilder Message = new StringBuilder("Hello");
            ////StringBuilder Message = new StringBuilder("Hello"); // Invalid

            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"MessageHashCode : {Message.GetHashCode()}");


            //Console.WriteLine("===================");
            ////Message = new StringBuilder("Hello world");

            //Message.Append("World");

            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"MessageHashCode : {Message.GetHashCode()}");
        }
    }
}
