using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug15_VarsOpsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //gitignore
            //google it for now
            //used to ignore shit
            //do it each time
            //you'll learn what it's about later
            //you saved a notepad copy
            //save it as ".gitignore" (that's it) in project folder

            string name = "Gabrielle";
            Console.WriteLine(name);

            name = "Dave"; //once we declared "name" is a string, we don't have to repeat "string"
            Console.WriteLine(name);
            //"passing a value" means putting it in the parentheses

            string birthMonth = "August";
            Console.WriteLine(birthMonth);

            //data types:
            int birthMonthNumber = 8; //integers = whole numbers only
            Console.WriteLine(birthMonthNumber);

            float number1 = 2.123456789f; //note the "f" at the end there
            double number2 = 2.123456789123456789d; //note "d"
            decimal number3 = 2.123456789123456789m; //note "m"

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            //when you run this, you'll see they don't print the same number of places.
            //that's the difference between these three. precision.

            //booleans. true/false.
            bool isPresent = true;
            bool seatTaken = false;

            //character. pronounced char like in bbq.
            char lastInitial = 'S'; //use single quote.

            //let's try a boolean experiment.
            int jessicaAge = 23;
            int bobAge = 35;
            //the next line will tell us if it's true or false
            Console.WriteLine(jessicaAge < bobAge);
            //if you flip the < it will return false

            //more exercises from class:
            int billShare = 13;
            Console.WriteLine("Total bill = " + (billShare * 4));

            int totalCups = 7;
            int addedCups = 2;
            Console.WriteLine("Cups still needed = " + (totalCups - addedCups));

            int budget = 40; //better to use float or double or decimal when it's money
            int costOfDiapers = 8;
            Console.WriteLine("Packages affordable is " + (budget / costOfDiapers));

            int cashToday = 41;
            int cashLastWeek = 29;
            Console.WriteLine("Cash earned over the weekend = " + (cashToday - cashLastWeek));

            int milesJulie = 47;
            int milesPranav = (milesJulie - 30);
            Console.WriteLine("Pranav ran " + milesPranav + " miles last week.");

            int costBox = 3;
            int budgetForEnvelopes = 12;
            Console.WriteLine("You can afford " + (budgetForEnvelopes / costBox) + " boxes.");

            double costSalad = 5.12;
            double moneyLeft = 27.10;
            double totalMoney = costSalad + moneyLeft;
            Console.WriteLine("Nor's spending money was " + (totalMoney));

            int students = 331;
            int buses = 6;
            int driven = 7;
            int studentsPerBus = (students - driven) / buses;
            Console.WriteLine($"There were {studentsPerBus} students per bus.");

            double pencilBudget = 24;
            double leftoverBudget = 10;
            int pencilsBought = 7;
            double costPerPencil = ((pencilBudget - leftoverBudget) / pencilsBought);
            Console.WriteLine("Each pencil cost $" + costPerPencil);

            int mathTotal = 72;
            //int x;
            //int y;
            //int z;
            //int y = x + 1;

            int smallestNumber = (mathTotal - 3) / 3;
            Console.WriteLine("How do I get the computer to do this math? " + smallestNumber);


            // 72 = small + small + 1 + small + 2
            //72 = x + y + z
            //y = x+1
            //z = x+1+1

            //int x = (72 - y - zed);
            //int y = (x + 1);
            //int zed = (x + 2);
            //72 = x + y + zed;
            //Console.WriteLine(x);

            //72 = 3x + 3;
            //69 = 3x;
            //23 = x;

            //48 = a + a + 2 + a + 4;
            //48 = 3a + 6;
            //42 = 3a;
            //14 = a;

            int mathTotal2 = 48;
            int smallestNumber2 = (mathTotal2 - 6) / 3;
            Console.WriteLine("Or this math problem? " + smallestNumber2);


            int newPurchase = 7;
            int currentBoxes = 22;
            int maxBoxes = (currentBoxes * 2);
            int originalBoxes = maxBoxes - newPurchase;
            Console.WriteLine("Maria started with boxes equal to: " + originalBoxes);

            Console.WriteLine("What's your name?");
            string donorName = Console.ReadLine();

            Console.WriteLine("In what city do you live?");
            string donorCity = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());
            //you learned today:
            //default of ReadLine is string
            //so if you need anything other than a string
            //you need to convert it via Parse

            Console.WriteLine("Please enter your donation amount.");
            double donation = double.Parse(Console.ReadLine());

            Console.WriteLine($"Thanks, {donorName} of {donorCity}");

        }
    }
}

