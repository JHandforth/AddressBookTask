using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookCLibrary
{
    public class NoOfMales : PersonsData
    {
        public static void GetNoOfMales()
        {
            int noOfMales = 0;
            //for (int i = 0; i < PersonsData.listOfPersons.Count; i++)
            //{
            //    if (listOfPersons[i].Gender == "Male")
            //    {
            //        noOfMales += 1;
            //    }
            //}
            //Console.WriteLine(noOfMales);

            foreach (var Person in listOfPersons)
            {
                if (Person.Gender == " Male")
                {
                    noOfMales += 1;
                }
            }
            Console.WriteLine(noOfMales);
        }
    }
}
