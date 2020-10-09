using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PhoneBook<T>
    {
        Dictionary<T, T> phoneBook;

        public PhoneBook()
        {
            phoneBook = new Dictionary<T, T>();
        }

        public void AddNote(T name, T phone)
        {
            phoneBook.Add(name, phone);
        }

        public void RemoveNote(T keyName)
        {
            phoneBook.Remove(keyName);
            Console.WriteLine($"{keyName} has been deleted!");
        }
        public void EditNote(T keyName, T newPhone)
        {
            phoneBook[keyName] = newPhone;
        }

        public void SearchNote(T keyName)
        {
            if (phoneBook.ContainsKey(keyName))
            {
                Console.WriteLine($"You were looking for: {keyName} - {phoneBook[keyName]}");
            }
            else
            {
                Console.WriteLine("Phonebool does not contain such name!");
            }
        }

        public void ShowAll()
        {
            int count = 1;            

            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{count}) {item.Key} - {item.Value}");
                count++;
            }
        }

    }
}
