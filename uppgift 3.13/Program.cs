using System;
namespace Uppgift_3._14
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur gammal är du");
            int ålder=int.Parse(Console.ReadLine());
            if(ålder==19)
            {
                Console.WriteLine("du får delta tävlingen");
                
            }
            if(ålder==16)
            {
                Console.WriteLine("Du får delta tävlingen"); // hh
                //Console.WriteLine("Du får delta tävlingen");
            }
            else
                        {
                            Console.WriteLine("tyvärr! du får inte att delta tävlingen");
                        }
        }
    }
}