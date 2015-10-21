using System;

namespace Calc
{
    // taki kod też działa
    public class Program
    {
        static bool CheckInput(string[] args)
        {
            bool result = true;
            int number;
            
            for (int i = 1; i < args.Length; i++)
            {
                result = Int32.TryParse(args[i], out number);
                if (!result)
                    return false; 
            }

            return true;
        }

        public static int Main(string[] args)
        {
            
            if (args == null || args.Length == 0 || !CheckInput(args))
            {
                return int.MinValue;
            }

            if (args[0] == "sum")
                {
                    int sum = 0;

                    for (int i = 1; i < args.Length; i++)
                    {
                          sum += int.Parse(args[i]);
                    }

                    return sum;
                }

                if (args[0] == "product")
                {
                    int product = 1;

                    for (int i = 1; i < args.Length; i++)
                    {
                        product *= int.Parse(args[i]);
                    }

                    return product;
                }

                if (args[0] == "aseq")
                {
            
                    if (args.Length >= 3)
                    {
                        int difference = int.Parse(args[2]) - int.Parse(args[1]);

                        for (int i = 3; i < args.Length; i++)
                        {
                            if ((int.Parse(args[i]) - int.Parse(args[i - 1])) != difference)
                                return 0;
                        }
                        return 1;
                    }

                    return 0;

                }

                if (args[0] == "ndec")
                {

                    if (args.Length >= 3)
                    {
                 
                        for (int i = 2; i < args.Length; i++)
                        {
                            if ((int.Parse(args[i]) - int.Parse(args[i - 1])) < 0)
                                return 0;
                        }

                        return 1;
                    }

                    return 0;
                }
       
            return int.MinValue;

          
        }
    }
}
