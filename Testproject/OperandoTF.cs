using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject
{
    public class OperandoTF
    {


        public OperandoTF()
        {
            //Esta linea de codigo elimina espacios en la cadena y compruba igualdad de 2 valores.
            /*String value1 = "a";
            String value2 = "A";

            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/

            /*Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            String myValue = "a";
            Console.WriteLine(myValue != "a");*/

            /*Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);*/

            /*String pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox")==false);
            Console.WriteLine(!pangram.Contains("cow"));*/

            /*int a = 7;
            int b = 6;
            Console.WriteLine(a != b); //True

            String S1 = "Hello";
            String S2 = "Hello";

            Console.WriteLine(S1 != S2);//False*/

            Random dice = new Random();

            int roll1 = dice.Next(1, 100);


            if (roll1 >= 50)
            {
                Console.WriteLine("Head");


            }else
            {
                Console.WriteLine("Tails");
            }

            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

        }    
    }
}
