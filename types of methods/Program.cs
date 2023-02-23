using System;
using System.Runtime.Intrinsics.X86;


namespace practise009;


class programe
{
    static int sum;

    public void add()                      //public - we wnt to give object to call
    {
        int x = 10, y = 12;
        sum = x + y;
        Console.WriteLine(sum);
    }
    static void add1()                     //static -it consider as variable of the class so no need to give object to call
    {                                        // it allow static varible only
        int x = 1, y = 12;
        sum = x + y;
        Console.WriteLine(sum);
    }
    public void add2(int a, int b)            //method with void called by giving name like add2();
    {
        sum = a + b;
        Console.WriteLine(sum);
    }

    static void add3(int m, int n)
    {
        sum = m + n;
        Console.WriteLine(sum);
    }

    static int sub(int a, int c)                       //methods with return type want to write in console.write to show
    {
        sum = a + c;
        return sum;
    }

    public int sub1(int a, int c)
    {
        sum = a + c;
        return sum;
    }

    static void Main(String[] args)
    {
        programe P = new programe();
        Console.WriteLine(P.sub1(31, 30));


    }



}
