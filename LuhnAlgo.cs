using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Algorithms
{
    class LuhnAlgo
    {
        public static bool CheckByLuhn(string cardNumber)
        {
            int str_length = cardNumber.Length;
            bool isSecond = false;
            int sum = 0;
            
            for(int i = str_length - 1; i >= 0; i--)
            {
                int digitValue = cardNumber[i] - '0';

                if (isSecond == true)
                    digitValue *= 2;
                
                sum += digitValue / 10; 
                sum += digitValue % 10;

                isSecond = !isSecond;

            }
            return sum % 10 == 0;
        }
    }
}


