using System;

namespace TarotReading
{
    class Tarot
    {
        public string[] TarotDeck()
        {
            string[] tarotDeck = new string[22];
            #region Tarot Deck
                tarotDeck[0] = "The Fool";
                tarotDeck[1] = "The Magician";
                tarotDeck[2] = "The High Priestess";
                tarotDeck[3] = "The Empress";
                tarotDeck[4] = "The Emperor";
                tarotDeck[5] = "The Hierophant";
                tarotDeck[6] = "The Lovers";
                tarotDeck[7] = "The Chariot";
                tarotDeck[8] = "The Strength";
                tarotDeck[9] = "The Hermit";
                tarotDeck[10] = "Wheel of Fortune";
                tarotDeck[11] = "Justice";
                tarotDeck[12] = "The Hanged Man";
                tarotDeck[13] = "Death";
                tarotDeck[14] = "Temperance";
                tarotDeck[15] = "The Devil";
                tarotDeck[16] = "The Tower";
                tarotDeck[17] = "The Star";
                tarotDeck[18] = "The Moon";
                tarotDeck[19] = "The Sun";
                tarotDeck[20] = "Judgement";
                tarotDeck[21] = "The World";
            #endregion

            return tarotDeck;
        }
        string[] TarotLuck(int i)
        {
            string[][] tarotLuck = new string[22][];
            #region Words Set
                tarotLuck[0] = new string[] {"Word000", "Word001", "Word002"};
                tarotLuck[1] = new string[] {"Word100", "Word101", "Word102"};
                tarotLuck[2] = new string[] {"Word200", "Word201", "Word202"};
                tarotLuck[3] = new string[] {"Word300", "Word301", "Word302"};
                tarotLuck[4] = new string[] {"Word400", "Word401", "Word402"};
                tarotLuck[5] = new string[] {"Word500", "Word501", "Word502"};
                tarotLuck[6] = new string[] {"Word600", "Word601", "Word602"};
                tarotLuck[7] = new string[] {"Word700", "Word701", "Word702"};
                tarotLuck[8] = new string[] {"Word800", "Word801", "Word802"};
                tarotLuck[9] = new string[] {"Word900", "Word901", "Word902"};
                tarotLuck[10] = new string[] {"Word1000", "Word1001", "Word1002"};
                tarotLuck[11] = new string[] {"Word1100", "Word1101", "Word1102"};
                tarotLuck[12] = new string[] {"Word1200", "Word1201", "Word1202"};
                tarotLuck[13] = new string[] {"Word1300", "Word1301", "Word1302"};
                tarotLuck[14] = new string[] {"Word1400", "Word1401", "Word1402"};
                tarotLuck[15] = new string[] {"Word1500", "Word1501", "Word1502"};
                tarotLuck[16] = new string[] {"Word1600", "Word1601", "Word1602"};
                tarotLuck[17] = new string[] {"Word1700", "Word1701", "Word1702"};
                tarotLuck[18] = new string[] {"Word1800", "Word1801", "Word1802"};
                tarotLuck[19] = new string[] {"Word1900", "Word1901", "Word1902"};
                tarotLuck[20] = new string[] {"Word2000", "Word2001", "Word2002"};
                tarotLuck[21] = new string[] {"Word2100", "Word2101", "Word2102"};
            #endregion

            // Recovers word set matching card's index.
            int index = 0;
            if (i >= 0 & i < tarotLuck.Length)
            {
                for (int j = 0; j < tarotLuck.Length; j++)
                    if (i == j)
                    {
                        index = i;
                        break;
                    }
            } else throw new IndexOutOfRangeException();

            return tarotLuck[index];
        }
        public string[] Wordset(string tarotCard)
        {
            string[] tarotDeck = TarotDeck();
            string[] wordset = null;

            for (int i = 0; i < tarotDeck.Length; i++)
                if (tarotDeck[i] == tarotCard)
                {
                    wordset = TarotLuck(i);
                    break;
                }

            return wordset;
        }
        public int CardNumber (string tarotCard)
        {
            string[] tarotDeck = TarotDeck();
            int cardNumber = 0;
            
            // Recovers an individual card's index.
            foreach (string card in tarotDeck)
                if (card == tarotCard)
                {
                    cardNumber = Array.IndexOf(tarotDeck, card);
                    break;
                }

            return cardNumber;
        }
        public int[] CardNumber (string[] tarotCards)
        {
            string[] tarotDeck = TarotDeck();
            int[] cardNumber = new int[3];
            int i = 0;

            // Recovers the index of each card on a given string array.
            foreach (string card in tarotCards)
            {
                foreach (string tarotCard in tarotDeck)
                {
                    if (card == tarotCard)
                    {
                        cardNumber[i] = Array.IndexOf(tarotDeck, tarotCard);
                        break;
                    }
                }
                i++;
            }

            return cardNumber;
        }
    }
    
}
