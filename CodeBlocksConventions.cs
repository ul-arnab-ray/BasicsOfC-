namespace CodeBlocksConvention
{
    public class CodeBlocksRules
    {
        public static void codeBlocks()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }
            // Console.WriteLine($"Outside the code block: {value}"); //ERROR

            bool flag2 = true;
            int value2;

            if (flag2)
            {
                // Console.WriteLine($"Inside the code block: {value2}"); //ERROR
            }

            value2 = 10;
            Console.WriteLine($"Outside the code block: {value2}");

            //-------Correct way--------
            bool flag3 = true;
            int value3 = 0;

            if (flag3)
            {
                Console.WriteLine($"Inside the code block: {value3}");
            }

            value3 = 10;
            Console.WriteLine($"Outside the code block: {value3}");


            bool flag4 = true;
            if (flag4)
            {
                Console.WriteLine(flag4);
            }
            // ------------OR--------------
            if (flag)
                Console.WriteLine(flag);
            // ------------OR--------------
            if (flag) Console.WriteLine(flag);

            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");

            // ------------OR--------------

            if (name == "bob")
                Console.WriteLine("Found Bob");
            else if (name == "steve")
                Console.WriteLine("Found Steve");
            else
                Console.WriteLine("Found Chuck");

            // ------------Practice---------------
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42) found = true;
            }
            if (found) Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");
        }
    }
}