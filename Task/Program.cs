using System;
using System.Collections.Generic;
using System.IO;
using AddressBookCLibrary;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PersonsData.GetPersons();
            NoOfMales.GetNoOfMales();
        }
    }
}