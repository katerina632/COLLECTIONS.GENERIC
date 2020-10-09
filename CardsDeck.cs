using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    enum Suit { Hearts = 0, Diamonds, Clubs, Spades };
    enum Rank { _6=0 , _7, _8, _9, _10, _J, _Q, _K, _A };
    struct Card
    {
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
        public Suit Suit { get; }

        public Rank Rank { get; }
    };
    class CardsDeck
    {
        Queue<Card> cardsDeck;
        public CardsDeck()
        {
            cardsDeck = new Queue<Card>();
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        cardsDeck.Enqueue(new Card((Suit)i, (Rank)j));
                    }
                } 
            };
        }

        public void ShowCardInCardsDeck()
        {
            if (cardsDeck.Count == 0)
                throw new InvalidOperationException("\nQueue is empty!\n");

            int count = 0;
            Console.WriteLine("Now in the deck:");
            foreach (Card c in cardsDeck)
            {
                Console.Write($"{c.Suit} {c.Rank}\t");
                count++;
                if (count == 4)
                {
                    Console.WriteLine();
                    count = 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Shuffle()
        {
            if (cardsDeck.Count == 0)
                throw new InvalidOperationException("\nQueue is empty!\n");

            Random rand = new Random();
            int size = cardsDeck.Count();
            Card[] copyQueue = new Card[size];
            copyQueue = cardsDeck.ToArray();


            for (int i = copyQueue.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                var temp = copyQueue[j];
                copyQueue[j] = copyQueue[i];
                copyQueue[i] = temp;
            }

            cardsDeck.Clear();
            for (int i = 0; i < copyQueue.Length; i++)
            {
                cardsDeck.Enqueue(copyQueue[i]);
            }
            Console.WriteLine("The deck of cards was shuffled!");
            Console.WriteLine();
        }

        public void Distribute6Cards()
        {
            int count = 1;
            for (int i = 0; i < 6; i++)
            {
                if (cardsDeck.Count == 0)
                    throw new InvalidOperationException("\nQueue is empty!\n");

                Console.WriteLine($"{count}) {cardsDeck.Peek().Suit} {cardsDeck.Peek().Rank}");
                cardsDeck.Dequeue();
                count++;
            }
            Console.WriteLine();
        }


        public void TakeOneCard()
        {
            if (cardsDeck.Count == 0)
                throw new InvalidOperationException("\nQueue is empty!\n");

            Console.WriteLine($"You took the card: {cardsDeck.Peek().Suit} {cardsDeck.Peek().Rank}");
            cardsDeck.Dequeue();
            Console.WriteLine();
        }
    }
}
