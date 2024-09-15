using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            /* Random dice = new Random();

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
             Console.WriteLine((flip == 0) ? "heads" : "tails");*/

            /*string permission = "Admin|Manager";
            int level = 55;

            if(level >= 55)
            {
                Console.WriteLine("Welcome, Super Admin user");

            }else if (level <= 55)
            {
                Console.WriteLine("Welcome, Admin user ");

            }else if(level > 20)
            {
                Console.WriteLine("Contact an Admin for access");

            }else if(level < 20)
            {
                Console.WriteLine("You do not have sufficient privileges.");

            }else 
            { Console.WriteLine("You do not have sufficient privileges.");

            }*/
            /* string permission = "Admin|Manager";
             int level = 53;

             if (permission.Contains("Admin"))
             {
                 if (level > 55)
                 {
                     Console.WriteLine("Welcome, Super Admin user.");
                 }
                 else
                 {
                     Console.WriteLine("Welcome, Admin user.");
                 }
             }
             else if (permission.Contains("Manager"))
             {
                 if (level >= 20)
                 {
                     Console.WriteLine("Contact an Admin for access.");
                 }
                 else
                 {
                     Console.WriteLine("You do not have sufficient privileges.");
                 }
             }
             else
             {
                 Console.WriteLine("You do not have sufficient privileges.");
             }

             int value = 5 >= 10 ? 10 : 20;
             Console.WriteLine($"{value}");*/

            /* bool flag = true;
             int value = 10;
             if (flag)
             {

                 Console.WriteLine($"inside the code block: {value}");
             }

             value = 20;
             Console.WriteLine($"inside the code block: {value}");*/

            /* int value = 5;
             if (value >= 0)
             {
                 int value2 = 6;
                 int result = value + value2;

                 Console.WriteLine($"el resultado es igual: { result}");

             }*/

            //SOLUCION MIA
            /*int[] numbers = { 4, 8, 15, 16, 23, 42 };

             int total = 0;
             bool found = true;
             foreach (int number in numbers)
             {

                 total += number;

                 if (number == 42)
                 {

                     if (found)
                     {
                         Console.WriteLine("Set contains 42");

                     }

                 }

             }
             Console.WriteLine($"Total: {total}");*/

            //SOLUCION DE LA PAGINA

            /*int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }

            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");*/

            /*int employeeLevel = 100;

            string employeeName = "Jhon Smith";

            string Title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    Title = "Senior Associate";
                    break;
                case 300:
                    Title = "Manager";
                    break;
                case 400:
                    Title = "Senior Manager";
                    break;
                default:
                    Title = "Associate";
                    break; 

            }
            Console.WriteLine($"{employeeName}, {Title}");*/

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;

            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }


            Console.WriteLine($"Product: {size} {color} {type}");



        }    
    }
}
