using System;
public class Pattern
{
    public static void Main()
    {
        int rows, c = 1, a, i, j, n;
        Console.Write("Enter the no of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < rows; i++)
        {
            for (n = 1; n <= rows - i; n++)
            {
                Console.Write(" ");
            }
            for (j = 0; j <= i; j++)
            {
                if (i == 0 || j == 0)
                {
                    c = 1;
                }
                else
                {
                    c = c * (i - j + 1) / j;
                }
                Console.Write("{0} ", c);
            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }
}