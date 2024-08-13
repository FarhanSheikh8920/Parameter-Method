using System;
using System.Numerics;
using System.Runtime.ExceptionServices;
class Method
{
    public static void Main()
    {
        string[] Name = new string[5];
        int[] number = new int[5];
        Console.WriteLine("Enter intiger number");
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter string number");
        for (int i = 0; i < Name.Length; i++)
        {
            Name[i] = Console.ReadLine();
        }

        Calcultor(Name,number);

    }
    public static void Calcultor(string[] name ,params int[] Number)
    {
        Console.WriteLine("the length is {0}",Number.Length);
        int N = Number.Length;
        for(int i=0;i<N;i++ )
        {
            Console.WriteLine("{0}  name is {1}", Number[i], name[i]);
        }
    }
    
}/**/