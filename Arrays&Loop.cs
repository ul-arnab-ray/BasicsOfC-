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
        }
    }
}