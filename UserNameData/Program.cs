using System;

namespace UserNameData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutajal sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutaja eesnime esimest tähte
            //program kuvab kasutaja eesnime tagurpidi
            //main meetordis ei tohi olla rohkem kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnimi: ");
            string userName = (Console.ReadLine());
            GetUserNameData(userName);  
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }

        }
    }
}
