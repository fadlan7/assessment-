namespace BankIndonesiaAssessment;

public class Answer
{
    public static void NumberOne()
    {
        Console.Write("Input n value : ");
        String input = Console.ReadLine();

        int parseInput = int.Parse(input);

        for (var i = 1; i <= parseInput; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.Write(" OKYES ");
            }
            else if (i % 4 == 0)
            {
                Console.Write(" YES ");
            }
            else if (i % 3 == 0)
            {
                Console.Write(" OK ");
            }
            else
            {
                Console.Write($" {i} ");
            }
        }
    }

    public static void NumberTwo()
    {
        Console.Write("Input n value : ");
        String input = Console.ReadLine();

        int parseInput = int.Parse(input);

        for (int i = 1; i <= parseInput; i++)
        {
            var row = "";
            for (int j = 0; j < i; j++)
            {
                row += i;
            }

            Console.WriteLine(row);
        }

        Console.WriteLine();
        for (int i = 1; i <= parseInput; i++)
        {
            var row = "";
            for (int j = i; j >= 1; j--)
            {
                row += j;
            }

            Console.WriteLine(row);
        }

        Console.WriteLine();
        int initialValue = 1;
        Boolean result = true;
        for (int i = 0; i <= parseInput; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (initialValue == parseInput)
                {
                    result = false;
                }
                else if (initialValue == 1)
                {
                    result = true;
                }


                Console.Write(result ? $"{initialValue++}" : $"{initialValue--}");
            }

            Console.WriteLine();
        }


        Console.WriteLine();
        for (int i = 0; i < parseInput; i++)
        {
            for (int j = 0; j < parseInput; j++)
            {
                Console.Write(j % 2 == 0 ? $"{1 + (j * parseInput) + i} " : $"{j * parseInput + (parseInput - i)} ");
            }

            Console.WriteLine();
        }
    }

    public static void NumberThree()
    {
        int[] n = { 12, 9, 13, 6, 10, 4, 7, 2 };

        var nResult = n.Where(num => num % 3 != 0).OrderBy(num => num).ToArray();

        Console.Write($"n = [ {string.Join(", ", nResult)} ]");
    }
}