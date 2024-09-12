
//int p1 = 0, p2 = 1;
//int count;
//Console.Write("Enter The Number");
//count = Int32.Parse(Console.ReadLine());

//Console.Write(p1 +" " +p2);
//Fibonacci(count - 2,p1,p2);
//Console.WriteLine();
//for (int i = 2; i < count; i++)
//{
//    p3 = p1 + p2;
//    Console.Write( " " +p3);
//    p1 = p2;
//    p2 = p3;
//}

//static void Fibonacci(int cnt,int p1,int p2)
//{
//    int p3;
//    if (cnt > 0)
//    {
//        p3 = p1 + p2;
//        Console.Write(" " +p3);
//        p1 = p2;
//        p2 = p3;
//        Fibonacci(cnt - 1,p1,p2);
//    }
//}

 static int Fibonacci(int n)
 {
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
 }

 
    int n = 10;
    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }
 
