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
                var indexOf = stringToValidate.IndexOf(stringToValidate[i]);
                if (indexOf >= 0 && indexOf != i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
