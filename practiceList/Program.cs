using System;
using System.Collections.Generic;

namespace practiceList
{
    class Program
    {
        static void Main(string[] args)
        {
            Country C1 = new Country() { Name = "Sweden", Code =  "SWE", Capital = "Stockholm" };
            Country C2 = new Country() { Name = "Findland", Code =  "FIN", Capital = "Helsinki" };
            Country C3 = new Country() { Name = "Denmark", Code =  "DK", Capital = "Köpenhamn" };
            Country C4 = new Country() { Name = "Poland", Code =  "POL", Capital = "Warszawa" };
            Country C5 = new Country() { Name = "Iceland", Code =  "ICE", Capital = "Reykjavik" };

            List<Country> listCountry = new List<Country>();
            listCountry.Add(C1);
            listCountry.Add(C2);
            listCountry.Add(C3);
            listCountry.Add(C4);
            listCountry.Add(C5);

            string userInput = string.Empty;

            do
            {
                Console.WriteLine("Please Enter Country Code: ");
                string ucc = Console.ReadLine();
                Country resultcountry = listCountry.Find(c => c.Code == ucc);
                if (resultcountry == null)
                {
                    Console.WriteLine("Country Code is not valid.");
                }
                else
                {
                    Console.WriteLine("Country Code is valid.");
                }
                do
                {
                    Console.WriteLine("Do you want to continue? (Y/N) ");
                    userInput = Console.ReadLine();
                }
                while (userInput != "N" && userInput != "Y");

                {

                }
            }
            while (userInput == "Y");

            {

            }
        }
    }
}
