using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    /**
     * <summary>
     * This class extends the List<Card> generic type   
     * </summary>
     * 
     * @class Card
     */
    public class Deck : List<Card>
    {
        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is default constructor for the Deck class   
        * </summary>
        * 
        * @constructor Deck
        */
        public Deck()
        {
            //create my deck of cards
            this._create();
        }

        //PRIVATE METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @private
         * @method _create
         * @returns {void}
         */

        private void _create()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit)); //add aninymous Card object to the list
                }
            }
        }

             
                /*
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                }
                for (int face = 1; face < 14; face++)
                {
                    this.Add(new Card(face, suit)); //add aninymous Card object to the list
                } //end for - face

            }// end for suit

        }//end of Create Deck method

         // PUBLIC STATIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++
         /**
          * <summary>
          * This method displays the List of Cards object to the Console
          * </summary>
          * 
          * @method Display
          * @return viod
          */

        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+    Current Deck                                  +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        /**
          * <summary>
          * This method randomly shuffles a List of Card objects
          * </summary>
          * 
          * @method Shuffle
          * @return viod
          */
        public void Shuffle()
        {
            //create a pseudo-random number sequence and stores it in random
            Random random = new Random();
            //record the number of cards in the deck List
            int cardCount = this.Count;

            //iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard];//copy current card to temp location
                int randomCard = random.Next(0, cardCount);//get a random card index
                this[currentCard] = this[randomCard];//copy value from random card to current card
                this[randomCard] = tempCard; //cory current card to random card
            }
        }
        /**
        * <summary>
        * This method will remove the 0th item from the deck and return it to the caller
        * </summary>
        * 
        * @method Deal
        * @returns {Card} 
        */
        public Card Deal()
        {
            Card returnedCard = this[0]; //copy the 0th card in the stack to the returnedCard

            //check to see if the deck is not empty
            if(this.Count>0)
            {
                this.RemoveAt(0); //remove the 0th Card from deck
            }
            
            return returnedCard; 
        }
    }
}
