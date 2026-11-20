namespace ieeetask1
{
    internal class Program
    {
        //==========Q38==========
        public static void SWAP(int X, int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void SWAP2(ref int X, ref int Y)

        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        //============Q39=============
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 10, 2, 3, 4, 5 };
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }
        public static int SumArray2(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 10, 2, 3, 4, 5 };
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        //=============Q40===============
        static (int sum, int difference) Calculate(int a, int b, int c, int d)
        {
            int sum = a + b;
            int difference = c - d;
            return (sum, difference);
        }

        //=================Q41===============
        static int SumDigits(int num)
        {
            int sum = 0;
            num = Math.Abs(num);  //=> (-num)==>(+num)
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        //===============Q42==============
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //==============Q43===============
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }

        //=================Q44====================
        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        //==================Q45====================
        static string ChangeChar(string text, int position, char newChar)
        {
            if (position < 0 || position >= text.Length)
            {
                return text;
            }
            char[] arr = text.ToCharArray();
            arr[position] = newChar;
            return new string(arr);
        }


        static void Main(string[] args)
        {
            //Q1
            //Console.WriteLine("plz enter a num");
            //int n;
            //n=int.Parse(Console.ReadLine());
            //Console.WriteLine("number is:"+ n);
            //Q2
            //string text = "shemo";
            //if (int.TryParse(text, out int num)) {
            //    Console.WriteLine(num);
            //}
            //else { Console.WriteLine("invailed"); }
            //Q3
            //double a = 15.7;
            //double b = 17.3;
            //double result = a + b;
            //Console.WriteLine(result);
            //Q4
            //string name = Console.ReadLine();
            //string fName= name.Substring(0,5);
            //Console.WriteLine(fName);
            //Q5
            //int x = 15;
            //int y = x;
            // y = 20;
            //Console.WriteLine("x ="+x);
            //Console.WriteLine("y ="+y);
            //Q6
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //arr2[0]= 200;
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr2[0] = "+ arr2[0]);
            //Q7
            //string s1 , s2 , fullName;
            //Console.WriteLine("plz enter fName");
            //s1 = Console.ReadLine();
            //Console.WriteLine("plz enter lName");
            //s2= Console.ReadLine();
            //fullName = s1 +" "+ s2;
            //Console.WriteLine("hello " + fullName);
            //Q8
            //double principal, rate, time , interest;
            //Console.WriteLine("plz enter principal");
            //principal = double.Parse(Console.ReadLine());
            //Console.WriteLine("plz enter rate");
            //rate = double.Parse(Console.ReadLine());
            //Console.WriteLine("plz enter time");
            //time = double.Parse(Console.ReadLine());
            //interest = (principal *  rate * time)/100;
            //Console.WriteLine("interest = "+interest);
            //Q9
            //double weight, height;
            //Console.WriteLine("Enter weight in kg: ");
            //weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter height in meters: ");
            //height = double.Parse(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI = " + bmi);
            //Q10
            //Console.Write("Enter temperature: ");
            //int temp = int.Parse(Console.ReadLine());
            //string result = temp < 10? "Just Cold": temp > 30? "Just Hot": "Just Good";
            //Console.WriteLine(result);
            //Q11
            //Console.Write("enter a day :");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("enter a month :");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("enter a year :");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{day} , {month} , {year}");
            //Console.WriteLine($"{day} / {month} / {year}");
            //Console.WriteLine($"{day} - {month} - {year}");
            //Q12
            //Console.Write("plz enter num :");
            //int num = int.Parse(Console.ReadLine());
            //if ((num%3==0)&&(num%4==0)) {
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            //Q13
            //Console.Write("plz enter a num : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0) {
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive.");
            //}
            //Q14
            //Console.Write("n1:");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("n2:");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.Write("n3:");
            //int n3 = int.Parse(Console.ReadLine());
            //if (n1>n2 && n1>n3)
            //{
            //    Console.WriteLine("the maximum is :" + n1);
            //}
            //else if(n2>n1 && n2 > n3)
            //{
            //    Console.WriteLine("the maximum is :" + n2);
            //}
            //else
            //{
            //    Console.WriteLine("the maximum is :" + n3);
            //}

            //if (n3 < n2 && n3 < n1)
            //{
            //    Console.WriteLine("the minimum is :" + n3);
            //}else if (n2 < n3 && n2 < n1)
            //{
            //    Console.WriteLine("the minimum is :" + n2);
            //}
            //else
            //{
            //    Console.WriteLine("the minimum is :" + n1);
            //}
            //Q15
            //Console.WriteLine("plz enter a num");
            //int num = int.Parse(Console.ReadLine());
            //if (num%2==0) 
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            //Q16
            //Console.WriteLine("plz enter a char");
            //char character = char.ToLower(char.Parse(Console.ReadLine()));
            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant.");
            //}
            //Q17
            //Console.WriteLine("enter month");
            //var month = int.Parse(Console.ReadLine());
            //string monthDays = month switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 days",
            //    4 or 6 or 9 or 11 => "30 days",
            //    2 => "28 days",
            //    _ => "invailed",
            //};
            //Console.WriteLine(monthDays);
            //Q18
            //Console.Write("enter a num : ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Q19
            //Console.Write("enter a num : ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 12; i++)
            //{
            //    int res = i * n;
            //    Console.WriteLine($" {i} * {n} = " + (i * n ));
            //}
            //Q20
            //Console.WriteLine("enter a num");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Q21
            //Console.WriteLine("enter a base");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a exponent");
            //int x = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 1; i <=x; i++)
            //{
            //     res = res * n;
            //}
            //Console.WriteLine("res : " + res);
            //Q22
            //double total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Enter mark of subject {i}: ");
            //    double mark = double.Parse(Console.ReadLine());
            //    total += mark;
            //}
            //double average = total / 5;
            //double percentage = average;
            //Console.WriteLine("Total = " + total);
            //Console.WriteLine("Average = " + average);
            //Console.WriteLine("Percentage = " + percentage + "%");
            //Q23
            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}
            //Q24
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    Console.Write(digit);
            //    num /= 10;
            //}
            //Q25
            //Console.Write("enter start :");
            //int s = int.Parse(Console.ReadLine());
            //Console.Write("enter end :");
            //int e = int.Parse(Console.ReadLine());
            //for (int i = s; i <= e; i++)
            //{
            //    bool isPrime = true;

            //    if (i <= 1)
            //    {
            //        isPrime = false;
            //    }

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Q26
            //Console.WriteLine("Enter a decimal number:");
            //int num = int.Parse(Console.ReadLine());
            //long binary = 0;
            //int remainder;
            //long place = 1;
            //while (num > 0)
            //{
            //    remainder = num % 2;
            //    binary += remainder * place;
            //    num /= 2;
            //    place *= 10;
            //}
            //Console.WriteLine("Binary = " + binary);
            //Q27
            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());
            //if ((x2 - x1) * (y3 - y1) ==
            //    (x3 - x1) * (y2 - y1))
            //{
            //    Console.WriteLine("Points are on one straight line");
            //}
            //else
            //{
            //    Console.WriteLine("Points are not on one straight line");
            //}
            //Q28
            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Q29
            //Console.Write("plz the size : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"plz enter element {i} : ");
            //    arr[i]= int.Parse(Console.ReadLine());
            //    sum+= arr[i];
            //};
            //Console.WriteLine("the sum : "+ sum);
            //Q30
            //Console.Write("plz enter the size : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] merged = new int[n*2];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"plz enter arr1 element {i} : ");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"plz enter arr2 element {i} : ");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0;i < n; i++)
            //{
            //    merged[i] = arr1[i];
            //    merged[i+n] = arr2[i]; 
            //}
            //Array.Sort(merged);
            //foreach (int item in merged)
            //{
            //    Console.Write(item + " ");
            //}
            //Q31
            //int[] arr = { 2, 3, 2, 5, 3, 2, 0 };
            //bool[] visited = new bool[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (visited[i])
            //    {
            //        continue;
            //    }
            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            visited[j] = true;
            //        }
            //    }
            //    Console.WriteLine($"{arr[i]} appears {count} times");
            //}
            //Q32
            //Console.Write("plz enter the size :");
            //int n = int.Parse(Console.ReadLine());
            //int[]arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"enter the element {i} :");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"the minimum : {arr[0]}");
            //Console.WriteLine($"the maximum : {arr[arr.Length-1]}");
            //Q33
            //Console.Write("plz enter the size :");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"enter the element {i} :");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"the second largest : {arr[arr.Length - 2]}");
            //Q34
            //Console.Write("plz enter the size :");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"enter the element {i} :");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int maxDistance = -1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = i - j - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}
            //if (maxDistance == -1)
            //{
            //    Console.WriteLine("no equal numbers");
            //}
            //else
            //{
            //    Console.WriteLine($"the longest distance : {maxDistance}");
            //}
            //Q35
            //Console.Write("Enter a sentence: ");
            //string text = Console.ReadLine();
            //string[] words = text.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));
            //Q36
            //Console.Write("Enter rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter columns: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];
            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"enter element [{i}][{j}] : ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Array.Copy(arr1, arr2, arr1.Length);
            //Console.WriteLine("Second Array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Q37
            //int[] arr = { 10, 20, 30, 40, 50 };
            //Array.Reverse(arr);
            //Console.Write("the reversed array : ");
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Q38
            //int a = 9, b = 4;
            //Console.WriteLine($"{a} , {b}");
            //SWAP(a, b);
            //Console.WriteLine($"{a} , {b}");
            //SWAP2 (ref a, ref b);
            //Console.WriteLine($"{a} , {b}");
            //Q39
            //int[] nums = { 1, 2, 3 };
            //int res = SumArray(nums);
            //Console.WriteLine($"result = {res}");
            //Console.WriteLine($"Arr[0] = {nums[0]}");
            //int res2 = SumArray2(ref nums);
            //Console.WriteLine($"result2 = {res2}");
            //Console.WriteLine($"Arr[0] = {nums[0]}");
            //Q40
            //int result = Calculate(10, 20, 30, 5);
            //Console.WriteLine("Sum = " + result.sum);
            //Console.WriteLine("Difference = " + result.difference);
            //Q41
            //Console.Write("plz enter a num : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(" the sum = "+ SumDigits(num));
            //Q42
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (IsPrime(num))
            //{
            //    Console.WriteLine("Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}
            //Q43
            //int[] numbers = { 10, 5, 30, 2, 20 };
            //MinMaxArray(numbers, out int min, out int max);
            //Console.WriteLine("Minimum = " + min);
            //Console.WriteLine("Maximum = " + max);
            //Q44
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("Factorial is not defined");
            //}
            //else
            //{
            //    Console.WriteLine("Factorial = " + Factorial(num));
            //}
            //Q45
            //string text = "Hello";
            //string result = ChangeChar(text, 2, 'b');
            //Console.WriteLine(result);

        }



    }
}
