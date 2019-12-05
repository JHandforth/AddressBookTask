using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookCLibrary
{
    public class PersonsData
    {
        public static List<Person> listOfPersons = new List<Person>();

        public static void GetPersons()
        {
            string line;

            StreamReader file = new StreamReader(@"\\gbrdcpfs07\profiles$\JHandforth\Redirection\My Documents\VS\AddressBookTaskJH\Task\AddressBook.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                listOfPersons.Add(new Person(words[0], words[1], words[2]));
            }
            file.Close();
        }
    }
}
