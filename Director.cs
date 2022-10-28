using System;
using System.Collections.Generic;


namespace hilo.Game
{

    public class Director
    {
        Card currentCard = new Card();
        bool _isPlaying = true;
        int _winPoints = 100;
        int _losePoints = 75;
        int _totalScore = 300;

    

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
          
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Pull a card? [y/n] ");
            string newCard = Console.ReadLine();
            _isPlaying = (newCard == "y");
        }



        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }
            
            Console.Write("Do you think the next card will be higher or lower (h/l): ");
            string yourGuess = Console.ReadLine();
            Card nextCard = new Card();
            Console.WriteLine($"The next card is: {nextCard.cardNumber}");

            if (yourGuess.Equals("h") && currentCard.cardNumber < nextCard.cardNumber)
            {
                _totalScore += _winPoints;
            }
            /// works
            else if (yourGuess.Equals("h") && currentCard.cardNumber > nextCard.cardNumber)
            {
                _totalScore -= _losePoints;
                if (_totalScore < 0)
                {
                    _totalScore = 0;
                }
            }
            /// works
            else if (yourGuess.Equals("l") && currentCard.cardNumber > nextCard.cardNumber)
            {
                _totalScore += _winPoints;

            }
            else if (yourGuess.Equals("l") && currentCard.cardNumber < nextCard.cardNumber)
            {
                _totalScore -= _losePoints;
                if (_totalScore < 0)
                {
                    _totalScore = 0;
                }
            }
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
           

            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}
