using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
       public string FavoriteFood { get; private set; }
        public string CityOfBirth { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Exercise One!!!!!!!");

           
            Console.Write("What is your favorite food?");
            string FavoriteFood = Console.ReadLine();

            Console.Write("What city were you born?");
            string CityOfBirth = Console.ReadLine();
            

            Console.Write("Your reversed string is: " + "" + ReverseString(FavoriteFood) + " " + ReverseString(CityOfBirth));
       
            Console.ReadLine();

        }

      
        private static string ReverseString(string value)
        {
            
            char[] StringArray = value.ToCharArray();
            Array.Reverse(StringArray);

            return new string (StringArray);

        }

      

       // public int ReversedArrayOfNumbers()
       //{
       //int[] userInput = new int[];

        //foreach (string userInputs in userInput)
        //{
        // Console.WriteLine(userInputs.Reverse());
        // }
        //return userInput[ ];
        //}
    }
    
}

