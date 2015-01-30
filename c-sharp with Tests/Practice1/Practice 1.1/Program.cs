using System;

namespace Practice_1._1
{
    public static class Program
    {
        static void Main()
        {
            if(StringIsUnique("abcdcefg"))
            {
                Console.WriteLine("It's unique");
            }
            else
            {
                Console.WriteLine("It's not unique");
            }
            Console.Read();
        }

        public static bool StringIsUnique(string stringToValidate)
        {
            for (var i = 0; i < stringToValidate.Length; i++)
            {
                for (var j = i+1; j < stringToValidate.Length; j++)
                {
                    if (stringToValidate[i] == stringToValidate[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
