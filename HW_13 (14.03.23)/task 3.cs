using System;
using System.Collections.Generic;
using System.Text;

class CardDeck
{
    private Queue<string> deck;

    public CardDeck()
    {
        deck = new Queue<string>();
        ShuffleDeck();
    }

    public void ShuffleDeck()
    {
        List<string> cards = new List<string> { "Туз", "Король", "Дама", "Валет", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        List<string> suits = new List<string> { "Черви", "Бубни", "Хрести", "Пікі" };

        foreach (string suit in suits)
        {
            foreach (string card in cards)
            {
                deck.Enqueue(card + " " + suit);
            }
        }

        Console.WriteLine("Колода перемішана!");
        Console.WriteLine();

    }

    public void DealCards()
    {
        int cardsToDeal = 6;

        if (deck.Count < cardsToDeal)
        {
            Console.WriteLine("Колода закінчилась!");
            return;
        }

        Console.WriteLine("Роздаємо карти:");

        for (int i = 0; i < cardsToDeal; i++)
        {
            Console.WriteLine(deck.Dequeue());
        }
        Console.WriteLine();

    }

    public void ShowDeck()
    {
        Console.WriteLine("Колода містить:");

        foreach (string card in deck)
        {
            Console.WriteLine(card);
            
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        CardDeck deck = new CardDeck();

        while (true)
        {

            Console.WriteLine("Виберіть дію:");
            Console.WriteLine("1 - Перемішати колоду");
            Console.WriteLine("2 - Роздати карти");
            Console.WriteLine("3 - Показати колоду");
            Console.WriteLine("4 - Вийти з програми");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    deck.ShuffleDeck();
                    break;
                case 2:
                    deck.DealCards();
                    break;
                case 3:
                    deck.ShowDeck();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неправильний вибір!");
                    break;
            }

        }
    }
}
