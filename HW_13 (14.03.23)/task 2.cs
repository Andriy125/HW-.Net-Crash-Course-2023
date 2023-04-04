using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        PhoneBook phoneBook = new PhoneBook();

        phoneBook.AddContact("Іваненко Олександр", "0987654321");
        phoneBook.AddContact("Петренко Іван", "0671234567");
        phoneBook.AddContact("Сидоренко Марина", "0501112233");

        phoneBook.UpdateContact("Сидоренко Марина", "0662223344");
        phoneBook.SearchContact("Іваненко Олександр");
        phoneBook.DeleteContact("Петренко Іван");
        phoneBook.SearchContact("Петренко Іван");
    }
}

class PhoneBook
{
    private Dictionary<string, string> contacts = new Dictionary<string, string>();

    // Додавання контакту
    public void AddContact(string name, string phoneNumber)
    {
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Контакт з таким ім'ям вже існує!");
        }
        else
        {
            contacts.Add(name, phoneNumber);
            Console.WriteLine("Контакт успішно доданий!");
        }
    }

    public void UpdateContact(string name, string newPhoneNumber)
    {
        if (contacts.ContainsKey(name))
        {
            contacts[name] = newPhoneNumber;
            Console.WriteLine("Номер телефону успішно змінено!");
        }
        else
        {
            Console.WriteLine("Контакт з таким ім'ям не знайдено!");
        }
    }


    public void DeleteContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            contacts.Remove(name);
        }
        else
        {
            Console.WriteLine("Контакт з таким ім'ям не знайдено!");
        }
    }

    public void SearchContact(string phoneNumber)
    {
        if (contacts.ContainsKey(phoneNumber))
        {
            Console.WriteLine($"Номер телефону {phoneNumber} належить {contacts[phoneNumber]}.");
        }
        else
        {
            Console.WriteLine($"Номер телефону {phoneNumber} не існує в телефонній книзі.");
        }
    }

}