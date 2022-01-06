using System.Collections;

namespace CSharp
{
    public class Principal
    {
        public static void Main(String[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int quant = 0;
                int esferas = int.Parse(Console.ReadLine());
                for (int j = 2; j <= esferas; j++)
                {
                    int countDiv = 0;
                    for (int k = 1; k <= j; k++)
                    {
                        if (j % k == 0)
                        {
                            countDiv++;
                        }
                    }
                    if (countDiv % 2 == 0)
                    {
                        quant++;
                    }
                }
                Console.WriteLine(quant);
            }
        }
    }
}