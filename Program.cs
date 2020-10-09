using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            //Task 1
            ArrayList list = new ArrayList() { false, 5, 6.1, true, 153, 12.8, true, 55.5, 7 };

            List<bool> listBool = new List<bool>();
            List<int> listInt = new List<int>();
            List<double> listDouble = new List<double>();

            foreach (var elem in list)
            {
                if (elem is int)
                    listInt.Add((int)elem);
                else if (elem is bool)
                    listBool.Add((bool)elem);
                else
                    listDouble.Add((double)elem);
            }

            Console.Write("Int elements: ");
            foreach (int i in listInt)
            {               
                Console.Write( i + " ");
            }

            Console.WriteLine();
            Console.Write("Bool elements: ");
            foreach (bool i in listBool)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Double elements: ");
            foreach (double i in listDouble)
            {
                Console.Write( i + " ");
            }
            Console.WriteLine();


            //Task 2
            List<string> listString = new List<string>() { "Kate", "Bob", "Name", "Dear" };

            listString.Sort();
            int max = 0;
            string maxLength=" ";

            foreach (string i in listString)
            {
                if (i.Length > max)
                {
                    max = i.Length;
                    maxLength = i;
                }                
            }

            foreach (string i in listString)
            {
                Console.Write($"{i} " );
            }
            Console.WriteLine();
            Console.WriteLine($"Maximum word length:  {maxLength}");
            Console.WriteLine();  

            //Task 3
            PhoneBook<string> phoneBook = new PhoneBook<string>();
            phoneBook.AddNote("Kate", "0671231231");
            phoneBook.AddNote("Bob", "0958587839");
            phoneBook.AddNote("Oksana", "0684523457");

            phoneBook.ShowAll();
            Console.WriteLine();

            phoneBook.EditNote("Bob", "1111");
            phoneBook.SearchNote("Bob");
            Console.WriteLine();

            phoneBook.RemoveNote("Bob");
            Console.WriteLine();
            phoneBook.ShowAll();
            Console.WriteLine();
            Console.WriteLine();


            //Task 4
            CardsDeck cardsDeck = new CardsDeck();           

            try
            {
                cardsDeck.ShowCardInCardsDeck();
                Console.WriteLine();

                cardsDeck.TakeOneCard();
                Console.WriteLine();
                cardsDeck.ShowCardInCardsDeck();
                Console.WriteLine();

                cardsDeck.Distribute6Cards();
                cardsDeck.ShowCardInCardsDeck();

                Console.WriteLine();

                cardsDeck.Shuffle();
                cardsDeck.ShowCardInCardsDeck();

                cardsDeck.Distribute6Cards();              
                cardsDeck.Distribute6Cards();               
                cardsDeck.Distribute6Cards();
                cardsDeck.Distribute6Cards();
                cardsDeck.Distribute6Cards();
                cardsDeck.Distribute6Cards();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
