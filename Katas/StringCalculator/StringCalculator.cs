using System;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private Func<string, int> _asInt32;

        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty((numbers)))
                return 0;

            _asInt32 = n => Int32.Parse(n);
            var numbersList = numbers.Split(",")
                    .Select(_asInt32).ToList();
            
            return numbersList.Sum();
            
            return -1;
        }
    }
}