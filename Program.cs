using System;

namespace TarotReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Program tarot = new Program();
            string[] cardsDrawing = tarot.CardsDrawing();
            string tarotReading;
            
            Console.WriteLine($"\t{cardsDrawing[0]}\t{cardsDrawing[1]}\t{cardsDrawing[2]}");
            
            tarotReading = tarot.TarotReading(cardsDrawing);
            Console.WriteLine(tarotReading);
        }
        string[] CardsDrawing()
        {
            string[] cardsReading = new string[3];
            Tarot tarot = new Tarot();
            string[] tarotDeck = tarot.TarotDeck();
            Random cardPicking = new Random();

            // Avoids the drawing of the same card.
            while (cardsReading[0] == cardsReading[1] || cardsReading[0] == cardsReading[2] || cardsReading[1] == cardsReading[2])
            {
                for (int ctrl = 0; ctrl < (cardsReading.Length); ctrl++)
                    cardsReading[ctrl] = tarotDeck[cardPicking.Next(tarotDeck.Length)];
            }

            return cardsReading;
        }
        string TarotReading(string[] tarotCards)
        {
            string tarotReading;
            string firstWord;
            string secondWord;
            string thirdWord;

            Tarot tarot = new Tarot();
            string[][] wordset = new string[3][];
            int i = 0;

            // Recovers word set for each card.
            foreach (string card in tarotCards)
            {
                wordset[i] = tarot.Wordset(card);
                i++;
            }

            // Recovers cards' index and gives a value for the first and last positions.
            int[] cardNumbers = tarot.CardNumber(tarotCards);
            int firstWordValue = cardNumbers[0] - cardNumbers[2];
            int thirdWordValue = cardNumbers[2] - cardNumbers[0];

            // Determines the word of a word set from the position's value.
            if (firstWordValue < 0)
                firstWord = wordset[0][0];
            else firstWord = wordset[0][2];
            
            if (thirdWordValue < 0)
                thirdWord = wordset[2][0];
            else thirdWord = wordset[2][2];
            
            secondWord = wordset[1][1];

            tarotReading = $"\t{firstWord} {secondWord} {thirdWord}";

            return tarotReading;  
        }
    }
}
