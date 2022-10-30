using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Service.Helpers.Extensions
{
    public static class CalculateFactorial
    {
        public static int CalcFactorial(this int num)
        {
            int result = 1;

            if(num == 0)
               return 0;

            for (int i = 1; i <=num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
