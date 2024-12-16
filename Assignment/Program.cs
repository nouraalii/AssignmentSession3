namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            ////1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int Number;
            //Console.WriteLine("Enter A Number : ");
            //bool Flag= int.TryParse(Console.ReadLine(), out Number);
            //if (Flag) 
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //} 
            #endregion



            #region Question2
            ////2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //int Number;
            //Console.WriteLine("Enter A Number : ");
            //bool Flag= int.TryParse(Console.ReadLine(), out Number);
            //if (Flag)
            //{
            //    if (Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //} 
            #endregion



            #region Question3
            ////3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int Number1 , Number2 , Number3 ;
            //bool Flag1 , Flag2 , Flag3 ;
            //Console.WriteLine("Enter First Number:");
            //Flag1=int.TryParse(Console.ReadLine(), out Number1);

            //Console.WriteLine("Enter Second Number:");
            //Flag2= int.TryParse(Console.ReadLine(), out Number2);

            //Console.WriteLine("Enter Third Number:");
            //Flag3= int.TryParse(Console.ReadLine(), out Number3);

            //if (Flag1 && Flag2 && Flag3) 
            //{
            //    int max = Number1;
            //    int min = Number1;

            //    if (Number2 > max)
            //        max = Number2;
            //    if (Number3 > max)
            //        max = Number3;

            //    if (Number2 < min)
            //        min = Number2;
            //    if (Number3 < min)
            //        min = Number3;

            //    Console.WriteLine($"Max element = {max}");
            //    Console.WriteLine($"Min element = {min}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //} 
            #endregion



            #region Question4
            ////4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int Number;
            //Console.WriteLine("Enter A Number : ");
            //bool Flag = int.TryParse(Console.ReadLine(), out Number);
            //if (Flag)
            //{
            //    if (Number % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //} 
            #endregion



            #region Question5
            ////5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //char InputChar;
            //Console.WriteLine("Enter the charcter");
            //bool Flag = char.TryParse(Console.ReadLine(), out InputChar);
            //if (Flag) 
            //{
            //    if ((InputChar == 'A' || InputChar == 'a')||
            //        (InputChar == 'E' || InputChar == 'e')|| 
            //        (InputChar == 'I' || InputChar == 'i') || 
            //        (InputChar == 'U' || InputChar == 'u') || 
            //        (InputChar == 'O' || InputChar == 'o')) 
            //    {
            //        Console.WriteLine("Vowel letter");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Consonant");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //} 
            #endregion



            #region Question6
            ////6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter the Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //for (int i = 0; i <= Number; i++)
            //{
            //    Sum = Sum + i;
            //}
            //Console.WriteLine("The sum of all numbers between 1 to that number : " + Sum); 
            #endregion



            #region Question7
            ////7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int Number;
            //Console.WriteLine("Enter the Number : ");
            //bool Flag = int.TryParse(Console.ReadLine(), out Number);
            //if (Flag) 
            //{
            //    for (int i = 1; i <= 12; i++) 
            //    {
            //        Console.WriteLine($"{Number} x {i} = {Number * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Inavlid Input");
            //} 
            #endregion



            #region Question8
            ////8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int Number;
            //Console.WriteLine("Enter the Number : ");
            //bool Flag = int.TryParse(Console.ReadLine(), out Number);
            //if (Flag)
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        if (i % 2 ==0)
            //        {
            //            Console.WriteLine($"Even numbers {i}");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Inavlid Input");
            //} 
            #endregion



            #region Question9
            ////9 - Write a program that takes two integers then prints the power.
            //int Number1 , Number2;
            //Console.WriteLine("Write first Number");
            //Number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Write second Number");
            //Number2 = int.Parse(Console.ReadLine());

            //double power=Math.Pow(Number1, Number2);

            //Console.WriteLine($"the power : {power}"); 
            #endregion



            #region Question10
            ////10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int Grade1, Grade2, Grade3, Grade4, Grade5;
            //Console.WriteLine("Enter Grade of subject 1");
            //Grade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Grade of subject 2");
            //Grade2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Grade of subject 3");
            //Grade3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Grade of subject 4");
            //Grade4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Grade of subject 5");
            //Grade5 = int.Parse(Console.ReadLine());

            //int Sum = Grade1 + Grade2 + Grade3 + Grade4 + Grade5;
            //double Avg = Sum / 5;
            //double Percentage = (Sum / 500.0) * 100;
            //Console.WriteLine($"The sum of the grades {Sum} " +
            //    $"The average is {Avg}  " +
            //    $"The Percentage is {Percentage}");
            #endregion



            #region Question11
            ////11- Write a program to input the month number and print the number of days in that month.
            //int Month;
            //Console.WriteLine("Enter The Month:");
            //Month=int.Parse(Console.ReadLine());

            //if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12) 
            //{
            //    Console.WriteLine($"Days in Month {Month} : 31");
            //}
            //else if(Month == 2)
            //{
            //    Console.WriteLine($"Days in Month {Month} : 28 or 29");
            //}
            //else
            //{
            //    Console.WriteLine($"Days in Month {Month} : 30");
            //} 
            #endregion



            #region Question12
            ////12- Write a program to create a Simple Calculator.
            //double Number1, Number2;
            //char operation;

            //Console.WriteLine("Enter the first number: ");
            //Number1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //Number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Choose an operation: +, -, *, /");
            //operation=char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"Result: {Number1} + {Number2} = {Number1 + Number2}");
            //        break;

            //    case '-':
            //        Console.WriteLine($"Result: {Number1} - {Number2} = {Number1 - Number2}");
            //        break;

            //    case '*':
            //        Console.WriteLine($"Result: {Number1} * {Number2} = {Number1 * Number2}");
            //        break;

            //    case '/':
            //        if (Number2 != 0)
            //            Console.WriteLine($"Result: {Number1} / {Number2} = {Number1 / Number2}");
            //        else
            //            Console.WriteLine("Can't divide by zero ");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            //        break;
            //} 
            #endregion



            #region Question13
            ////13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter a string: ");
            //string input = Console.ReadLine();

            //string ReversedString = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    ReversedString += input[i];
            //}

            //Console.WriteLine($"Reversed string: {ReversedString}"); 
            #endregion



            #region Question14
            ////14- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter an integer: ");
            //int input = int.Parse(Console.ReadLine());
            //int reversed = 0;

            //while (input != 0)
            //{
            //    int digit = input % 10;   
            //    reversed = reversed * 10 + digit; 
            //    input = input / 10;
            //}

            //Console.WriteLine("Reversed integer: " + reversed); 
            #endregion



            #region Question15
            ////15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter a number: ");
            //int Number = int.Parse(Console.ReadLine());

            //for (int j = 2; j <= Number; j++)
            //{
            //    bool isPrime = true;
            //    for (int i = 2; i <= j / 2; i++)
            //    {
            //        if (j % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(j);
            //    }
            //} 
            #endregion



            #region Question16
            ////16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("Enter a number to convert: ");
            //int decimalNumber = int.Parse(Console.ReadLine());
            //string BinaryResult = "";

            //if (decimalNumber == 0)
            //{
            //    BinaryResult = "0";
            //}
            //else
            //{
            //    while (decimalNumber > 0)
            //    {
            //        BinaryResult = (decimalNumber % 2) + BinaryResult;

            //        decimalNumber = decimalNumber / 2;
            //    }
            //}
            //Console.WriteLine($"The Binary of the number is: {BinaryResult}"); 
            #endregion



            #region Question17
            ////17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on a single straight line.");
            //} 
            #endregion



            #region Quesstion18
            //Console.WriteLine("Enter the time taken to complete the task (in hours): ");
            //int hours = int.Parse(Console.ReadLine());

            //if (hours >= 2 && hours < 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (hours >= 3 && hours < 4)
            //{
            //    Console.WriteLine("The worker should increase their speed.");
            //}
            //else if (hours >= 4 && hours < 5)
            //{
            //    Console.WriteLine("The worker needs training to improve their speed.");
            //}
            //else if (hours >= 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time cannot be less than 2 hours.");
            //} 
            #endregion

        }
    }
}
