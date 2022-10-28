using System;

namespace hilo.Game

{
    public class Card
    {
        public int cardNumber;


        public Card()
        {
            getNewCard();
        }
        public void getNewCard()
        {
            Random random = new Random();
            cardNumber = random.Next(1, 14);

        }
    }
}