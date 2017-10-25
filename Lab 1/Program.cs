using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //comment for git

            while (true)
            {
                {
                    double length;
                    double width;

                    Console.WriteLine("Could you please give me the length and width of a classroom at grand circus in feet. ");
                    Console.Write("Length: ");
                    string input1 = Console.ReadLine();

                    while (!double.TryParse(input1, out length) || length < 0)
                    {

                        Console.WriteLine("That is not a proper Length. ");
                        Console.Write("Please enter a valid Length: ");
                        input1 = Console.ReadLine();

                    }

                    Console.Write("Width: ");
                    string input2 = Console.ReadLine();
                    double.TryParse(input2, out width);

                    while (!double.TryParse(input2, out width) || width < 0)
                    {
                        Console.WriteLine("That is not a proper Width. ");
                        Console.Write("Please enter a valid Width: ");
                        input2 = Console.ReadLine();

                    }

                    Console.WriteLine("The area for the room you are measuring is {0} ", length * width);
                    Console.WriteLine("Also the perimeter of the same room is {0} ", length * 2 + width * 2);

                    Console.Write("Do you want to continue measuring Yes or No? ");
                    string test = Console.ReadLine().ToLower();

                    if (test == "y" || test == "yes")
                    {
                        continue;
                    }
                    else if (test == "n" || test == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Press (Y/N) ");
                        test = Console.ReadLine().ToLower();
                    }

                }

            }

        }
    }
}
