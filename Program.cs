using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamboo_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            takeAwayorEatHere(); 
        }

        private static void invaid()
        {
            Console.WriteLine("\nPlease select between 1 and 3\n");
        }

        public static void menu()
        {
            int selectedMenu = 0;

            while (selectedMenu != 7)
            {
                menuList();
                Console.Write("Select: ");
                selectedMenu = int.Parse(Console.ReadLine());

                switch (selectedMenu)
                {
                    case 1:
                        friedRice();
                        break;
                    case 2:
                        pizza();
                        break;
                    case 3:
                        cola();
                        break;
                    case 4:
                        coffee();
                        break;
                    case 5:
                        icecream();
                        break;
                    case 6:
                        cake();
                        break;
                    case 7:
                        goodbye();
                        break;
                    default:
                        invaid();
                        break;
                }
            }
        }

        private static void goodbye()
        {
            Console.WriteLine("\nHave a good day!\n");
        }

        private static void menuList()
        {
            Console.WriteLine("\nMenu Lists\n------------");
            Console.WriteLine("1. Fried Rice");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Cola");
            Console.WriteLine("4. Coffee");
            Console.WriteLine("5. Ice Cream");
            Console.WriteLine("6. Cake");
            Console.WriteLine("7. Exit\n");
        }

        private static void friedRice()
        {
            Console.WriteLine("\nFried Rice\n------------");
            Console.WriteLine("\n1. Fried Rice with Chicken - 60 Bahts");
            Console.WriteLine("2. Fried Rice with Seafood - 80 Bahts\n");
            Console.Write("Select: ");

            int selectFriedRice = int.Parse(Console.ReadLine());
            if(selectFriedRice == 1)
            {
                double totalDis;
                double total;
                int friedRicewithChicken = 60;
                Console.WriteLine("\nYou selected Fried Rice with Chicken");
                Console.Write("How many?: ");
                int dish = int.Parse(Console.ReadLine());

                if(memberCardCheck() == true)
                {
                    
                    totalDis = (friedRicewithChicken * dish) * 0.25;
                    total = (friedRicewithChicken * dish) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (friedRicewithChicken * dish) + 500;
                    }
                    else
                    {
                        total = (friedRicewithChicken * dish);
                    }
                }
                Console.WriteLine("\nTotal price is " +  total + " Bahts.");
            }
            if (selectFriedRice == 2)
            {
                double totalDis;
                double total;
                int friedRicewithSeafood = 80;
                Console.WriteLine("\nYou selected Fried Rice with Seafood");
                Console.Write("How many?: ");
                int dish = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (friedRicewithSeafood * dish) * 0.25;
                    total = (friedRicewithSeafood * dish) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (friedRicewithSeafood * dish) + 500;
                    }
                    else
                    {
                        total = (friedRicewithSeafood * dish);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }

        private static void pizza()
        {
            Console.WriteLine("\nPizza\n------------");
            Console.WriteLine("\n1. Pizza with bacon - 180 Bahts");
            Console.WriteLine("2. Pizza with sausage - 200 Bahts\n");
            Console.Write("Select: ");

            int selectPizza = int.Parse(Console.ReadLine());
            if (selectPizza == 1)
            {
                double totalDis;
                double total;
                int Pizzawithbacon = 180;
                Console.WriteLine("\nYou selected Pizza with Bacon");
                Console.Write("How many?: ");
                int pie = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (Pizzawithbacon * pie) * 0.25;
                    total = (Pizzawithbacon * pie) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (Pizzawithbacon * pie) + 500;
                    }
                    else
                    {
                        total = (Pizzawithbacon * pie);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
            if (selectPizza == 2)
            {
                double totalDis;
                double total;
                int Pizzawithsausage = 200;
                Console.WriteLine("\nYou selected Pizza with sausage");
                Console.Write("How many?: ");
                int pie = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (Pizzawithsausage * pie) * 0.25;
                    total = (Pizzawithsausage * pie) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (Pizzawithsausage * pie) + 500;
                    }
                    else
                    {
                        total = (Pizzawithsausage * pie);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }
        private static void cola()
        {
            Console.WriteLine("\nCola\n------------");
            Console.WriteLine("\n1. Original - 20 Bahts");
            Console.WriteLine("2. No Sugar - 21 Bahts\n");
            Console.Write("Select: ");

            int selectCola = int.Parse(Console.ReadLine());
            if (selectCola == 1)
            {
                double totalDis;
                double total;
                int original = 20;
                Console.WriteLine("\nYou selected Original Cola");
                Console.Write("How many?: ");
                int bottle = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (original * bottle) * 0.25;
                    total = (original * bottle) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (original * bottle) + 500;
                    }
                    else
                    {
                        total = (original * bottle);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
            if (selectCola == 2)
            {
                double totalDis;
                double total;
                int nosugar = 21;
                Console.WriteLine("\nYou selected No Sugar Cola");
                Console.Write("How many?: ");
                int bottle = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (nosugar * bottle) * 0.25;
                    total = (nosugar * bottle) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (nosugar * bottle) + 500;
                    }
                    else
                    {
                        total = (nosugar * bottle);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }
        private static void coffee()
        {
            Console.WriteLine("\nCoffee\n------------");
            Console.WriteLine("\n1. Hot - 25 Bahts");
            Console.WriteLine("2. Cold - 35 Bahts\n");
            Console.Write("Select: ");

            int selectCoffee = int.Parse(Console.ReadLine());
            if (selectCoffee == 1)
            {
                double totalDis;
                double total;
                int hot = 25;
                Console.WriteLine("\nYou selected Hot Coffee");
                Console.Write("How many?: ");
                int cup = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (hot * cup) * 0.25;
                    total = (hot * cup) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (hot * cup) + 500;
                    }
                    else
                    {
                        total = (hot * cup);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
            if (selectCoffee == 2)
            {
                double totalDis;
                double total;
                int cold = 35;
                Console.WriteLine("\nYou selected Cold Coffee");
                Console.Write("How many?: ");
                int cup = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (cold * cup) * 0.25;
                    total = (cold * cup) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (cold * cup) + 500;
                    }
                    else
                    {
                        total = (cold * cup);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }
        private static void icecream()
        {
            Console.WriteLine("\nIce Cream\n------------");
            Console.WriteLine("\n1. Strawberry - 30 Bahts");
            Console.WriteLine("2. Charcoal - 35 Bahts\n");
            Console.Write("Select: ");

            int selectIcecream = int.Parse(Console.ReadLine());
            if (selectIcecream == 1)
            {
                double totalDis;
                double total;
                int strawberry = 30;
                Console.WriteLine("\nYou selected strawberry Ice Cream");
                Console.Write("How many?: ");
                int cup = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (strawberry * cup) * 0.25;
                    total = (strawberry * cup) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (strawberry * cup) + 500;
                    }
                    else
                    {
                        total = (strawberry * cup);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
            if (selectIcecream == 2)
            {
                double totalDis;
                double total;
                int charcoal = 35;
                Console.WriteLine("\nYou selected Charcoal Ice Cream");
                Console.Write("How many?: ");
                int cup = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {
                    totalDis = (charcoal * cup) * 0.25;
                    total = (charcoal * cup) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (charcoal * cup) + 500;
                    }
                    else
                    {
                        total = (charcoal * cup);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }
        private static void cake()
        {
            Console.WriteLine("\nCake\n------------");
            Console.WriteLine("\n1. Chocolate - 45 Bahts");
            Console.WriteLine("2. Vanilla - 40 Bahts\n");
            Console.Write("Select: ");

            int selectCake = int.Parse(Console.ReadLine());
            if (selectCake == 1)
            {
                double totalDis;
                double total;
                int chocolate = 45;
                Console.WriteLine("\nYou selected Chocolate Cake");
                Console.Write("How many?: ");
                int piece = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (chocolate * piece) * 0.25;
                    total = (chocolate * piece) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (chocolate * piece) + 500;
                    }
                    else
                    {
                        total = (chocolate * piece);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
            if (selectCake == 2)
            {
                double totalDis;
                double total;
                int vanilla = 40;
                Console.WriteLine("\nYou selected Vanilla");
                Console.Write("How many?: ");
                int piece = int.Parse(Console.ReadLine());

                if (memberCardCheck() == true)
                {

                    totalDis = (vanilla * piece) * 0.25;
                    total = (vanilla * piece) - totalDis;
                }
                else
                {
                    char memberCardOpen;
                    Console.Write("Do you want to open membercard?(y/N): ");
                    memberCardOpen = char.Parse(Console.ReadLine());

                    if (memberCardOpen == 'Y' || memberCardOpen == 'y')
                    {
                        memberCardDetail();
                        total = (vanilla * piece) + 500;
                    }
                    else
                    {
                        total = (vanilla * piece);
                    }
                }
                Console.WriteLine("\nTotal price is " + total + " Bahts.");
            }
        }

        private static void memberCardDetail()
        {
            string[] memberCardData = new string[3];
            Console.WriteLine("\nMembership fee: 500 Bahts");
            Console.Write("Enter your name: ");
            memberCardData[0] = "Name: " + Console.ReadLine();
            Console.Write("Enter your phone: ");
            memberCardData[1] = "Phone: " + Console.ReadLine();
            Console.Write("Enter your address: ");
            memberCardData[2] = "Address: " + Console.ReadLine();

            Console.WriteLine();
            foreach(string mem in memberCardData)
            {
                Console.WriteLine(mem);
            }
            Console.WriteLine("\nSuccessfully open membercard and fees will be added to your total amount!");
        }

        private static void takeAwayorEatHere()
        {
            char tore;
            Console.WriteLine("Bamboo House\n------------");
            Console.Write("Take away or Eat Here?(t/E): ");
            tore = char.Parse(Console.ReadLine());

            if(tore == 't' || tore == 'T')
            {
                menu();
            }
            else
            {
                booking();
            }
        }

        private static void booking()
        {
            char booking;
            Console.Write("\nDo you have booking or not?(y/N): ");
            booking = char.Parse(Console.ReadLine());
            if (booking == 'Y' || booking == 'y')
            {
                Console.WriteLine("\nWhich Room\n-----------");
                Console.WriteLine("\n1. VIP Room\n2. Regular Table");
                Console.Write("Select: ");
                int room = int.Parse(Console.ReadLine());
                if(room == 1)
                {
                    Console.WriteLine("\nI will take you to VIP Room!\n");
                    menu();
                }
                else if(room == 2)
                {
                    Console.WriteLine("\nI will take you to Regular Room!\n");
                    menu();
                }
                else
                {
                    Console.WriteLine("\nPlease selected 1 or 2.\n");
                }
            }
            else
            {
                Console.Write("How many people?: ");
                int qtyPeople = int.Parse(Console.ReadLine());

                if(qtyPeople <= 4)
                {
                    Console.WriteLine("\nI will take you to Small table 1 - 4\n");
                    menu();
                }
                else if (qtyPeople >= 5 && qtyPeople <= 10)
                {
                    Console.WriteLine("\nI will take you to Big table 5 - 10\n");
                    menu();
                }
            }
        }

        private static bool memberCardCheck()
        {
            char memberCardChecking;
            Console.Write("\nDo you have membership? (y/N): ");
            memberCardChecking = char.Parse(Console.ReadLine());

            if (memberCardChecking == 'y' || memberCardChecking == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
