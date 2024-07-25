using System;

namespace Fundamentals
{
    public class fundamentals_CSharp
    {
        public static void c_sharp()
        {
            Console.WriteLine("Hello, World!");

            // console.WriteLine("Hello World!");
            // Console.WriteLine('Hello World!');

            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine("\n");

            Console.WriteLine("Congratulations!");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine("\n");

            Console.WriteLine("This is the first line.");
            Console.Write("This is ");
            Console.Write("the second ");
            Console.Write("line.");

            Console.WriteLine("\n");

            Console.WriteLine("This is the first line.");
            Console.Write("This is the second line.");

            Console.WriteLine("\n");

            char ch = 'b';
            Console.WriteLine(ch);

            Console.WriteLine("\n");

            // Console.WriteLine('Hello World!');

            int s = 234;
            Console.WriteLine(s);
            Console.WriteLine(s + 431);

            Console.WriteLine("\n");

            Console.WriteLine(0.25F);

            Console.WriteLine("\n");

            float f = 21.2323f;
            double d = 3223.34232221d;
            decimal m = 2322112.354551821828m;

            Console.WriteLine($"Float = {f}, Double = {d}, Decimal = {m}");

            bool bl = true;
            Console.WriteLine(bl);
            Console.WriteLine(false & bl);
            Console.WriteLine(false || bl);

            Console.WriteLine("123");
            Console.WriteLine(123);

            Console.WriteLine("true");
            Console.WriteLine(true);

            // string firstName;

            // char userOption;

            // int gameScore;

            // decimal particlesPerMillion;

            // bool processedCustomer;

            // firstName = "Arnab";
            // Console.WriteLine(firstName);
            // Console.WriteLine(firstName + " Ray");
            // Console.WriteLine($"Name = {firstName}");

            // string firstName;
            // "Arnab" = firstName;

            // int firstName;
            // firstName = "Bob";

            string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);
            firstName = "Yasmin";
            Console.WriteLine(firstName);

            // string firstName;
            // Console.WriteLine(firstName);

            string firstNames = "Arnab";
            Console.WriteLine(firstNames);

            var message = "Hello world!";

            // var message = "Hello World!";
            // message = 10.703m;

            // var message;

            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");

            Console.Write($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");

            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");

            // Console.WriteLine("Hello "World"!");

            Console.WriteLine("Hello \"World\"!");

            // Console.WriteLine("c:\source\repos");

            Console.WriteLine("c:\\source\\repos");

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

            Console.Write(@"c:\invoices");

            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            string firstNamee = "Bob";
            string message2 = "Hello " + firstNamee;
            Console.WriteLine(message2);

            string greeting = "Hello";
            string message3 = greeting + " " + firstNamee + "!";
            Console.WriteLine(message3);

            string message4 = greeting + " " + firstNamee + "!";
            Console.WriteLine(message4);

            string message5 = $"{greeting} {firstNamee}!";
            Console.WriteLine(message5);

            int version = 11;
            string updateText = "Update to Windows";
            string message6 = $"{updateText} {version}";
            Console.WriteLine(message6);

            int version2 = 11;
            string updateText2 = "Update to Windows";
            Console.WriteLine($"{updateText2} {version2}!");

            string projectName2 = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName2}\Data");

            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            string firstName7 = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName7 + " sold " + widgetsSold + " widgets.");

            string firstName8 = "Bob";
            int widgetsSold2 = 7;
            Console.WriteLine(firstName8 + " sold " + widgetsSold2 + 7 + " widgets.");

            string firstName9 = "Bob";
            int widgetsSold3 = 7;
            Console.WriteLine(firstName9 + " sold " + (widgetsSold3 + 7) + " widgets.");

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            decimal decimalQuotient = 7.0m / 5;
            decimal decimalQuotient2 = 7 / 5.0m;
            decimal decimalQuotient3 = 7.0m / 5.0m;

            // int decimalQuotient1 = 7 / 5.0m;
            // int decimalQuotient2 = 7.0m / 5;
            // int decimalQuotient3 = 7.0m / 5.0m;
            // decimal decimalQuotient4 = 7 / 5;

            Console.WriteLine($"Decimal quotient: {decimalQuotient}");
            Console.WriteLine($"Decimal quotient: {decimalQuotient2}");
            Console.WriteLine($"Decimal quotient: {decimalQuotient3}");

            int first = 7;
            int second = 5;
            decimal quot = (decimal)first / (decimal)second;
            Console.WriteLine(quot);

            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            int value = 0;
            Console.WriteLine(value);
            value = value + 5;
            Console.WriteLine(value);
            value += 5;
            Console.WriteLine(value);

            value = 0;
            Console.WriteLine(value);
            value = value + 1;
            Console.WriteLine(value);
            value++;
            Console.WriteLine(value);
            Console.WriteLine(value++);
            Console.WriteLine(++value);

            value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;

            Console.WriteLine($"The temperature is {(fahrenheit - 32m) * (5m / 9m)} Celsius.");


        }
    }
}
