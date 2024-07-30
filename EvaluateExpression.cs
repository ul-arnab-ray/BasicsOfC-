namespace EvaluateExpressions
{
    public class EvaluateBooleanExpression
    {
        public static void BooleanExpression()
        {
            // ---------Equality Operator---------
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            // ---------Inequality Operator---------
            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue2 = "a";
            Console.WriteLine(myValue2 != "a");

            // ---------Comparison Operator---------
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            string message = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(message.Contains("fox"));
            Console.WriteLine(message.Contains("cow"));

            Console.WriteLine(message.Contains("fox") == false);
            Console.WriteLine(!message.Contains("fox"));

            Console.WriteLine(!message.Contains("fox"));
            Console.WriteLine(!message.Contains("cow"));

            int a = 7;
            int b = 6;
            Console.WriteLine(a != b);
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);

            // ---------Conditional Operator---------
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            //------------Problem 1-------------
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            //------------Problem 2-------------
            string permission = "Admin|Manager";
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
        }
    }
}