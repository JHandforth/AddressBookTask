using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookCLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Date { get; set; }
        public Person(string name, string gender, string date)
        {
            Name = name;
            Gender = gender;
            Date = date;
        }
    }  
}