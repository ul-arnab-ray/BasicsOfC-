namespace Array_Loops
{
    public class Array_Loops_Concept
    {
        public static void ArrayLoop()
        {
            string[] fraudulentOrderIDs = new string[4];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            fraudulentOrderIDs[3] = "D000";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudulentOrderIDs2[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs2[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs2[2]}");

            fraudulentOrderIDs2[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs2[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            string[] names = { "Arnab", "Shyam", "Ram" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] inv = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sm = 0;
            foreach (int itm in inv)
            {
                sm += itm;
            }
            Console.WriteLine($"We have {sm} items in inventory.");

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            // --------Problem: Report the Order IDs that need further investigation---------
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }

            // ------------For Statement--------------
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }

            string[] names2 = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names2[i]);
            }

            foreach (var n in names2)
            {
                Console.WriteLine(n);
            }

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // ------------Do & While Statement--------------
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);

            Random random2 = new Random();
            int current2 = random2.Next(1, 11);

            while (current2 >= 3)
            {
                Console.WriteLine(current2);
                current2 = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current2}");

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);

            // ------------------Problem---------------------
            int hero = 10;
            int monster = 10;
            Random randomNum = new Random();
            do
            {
                int attack = randomNum.Next(1, 11);
                monster -= attack;
                Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

                if (monster <= 0) continue;

                attack = randomNum.Next(1, 11);
                hero -= attack;
                Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            string? readResult;
            Console.WriteLine("Enter a string:");
            do
            {
                readResult = Console.ReadLine();
            } while (readResult == null);

            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);

            // ----------------Problem 1--------------
            string? userInput;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    valueEntered = userInput;
                }

                validNumber = int.TryParse(valueEntered, out numValue);

                if (validNumber == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            } while (validNumber == false);

            Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            userInput = Console.ReadLine();

            // ----------------Problem 2--------------
            string? userInput2;
            string roleName = "";
            bool validEntry2 = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                userInput2 = Console.ReadLine();
                if (userInput2 != null)
                {
                    roleName = userInput2.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry2 = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry2 == false);

            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            userInput2 = Console.ReadLine();

            // ----------------Problem 3--------------
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                while (periodLocation != -1)
                {
                    mySentence = myString.Remove(periodLocation);
                    myString = myString.Substring(periodLocation + 1);
                    myString = myString.TrimStart();
                    periodLocation = myString.IndexOf(".");
                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }
    }
}