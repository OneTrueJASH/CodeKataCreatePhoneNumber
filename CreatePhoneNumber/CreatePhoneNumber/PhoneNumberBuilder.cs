using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
    public static class PhoneNumberBuilder
    {
        public static string CreatePhoneNumber(int[] input)
        {
            return $"({input[0]}{input[1]}{input[2]}) {input[3]}{input[4]}{input[5]}-{input[6]}{input[7]}{input[8]}{input[9]}";
        }
    }
}
