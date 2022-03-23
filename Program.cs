using ClassLibrary2;
using System;

namespace ConsoleApp8

{
    public class Program
    {
        static void Main(string[] args)
        {
            int Firstnumber = Convert.ToInt32(Console.ReadLine());
            int Secondnumber = Convert.ToInt32(Console.ReadLine());

        Adittion k = new Adittion();
        AddingFirstnameandSecondname k1 = new AddingFirstnameandSecondname();
         string Firstname = Console.ReadLine();
         string Secondname = Console.ReadLine();
            Console.WriteLine(k.Addingtwonumbers(Firstnumber, Secondnumber));

            Console.WriteLine(k1.Fullname(Firstname, Secondname));
        }
    }






    
       
}
