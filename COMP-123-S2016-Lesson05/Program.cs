using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    /**
     * Theis is a "driver" class for our Program 
     * 
     * @class Program 
     */
    public class Program
    {

        /**
         * The main method for our driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */

        public static void Main(string[] args)
        {
            //list that represents List of Cards

            Deck deck = new Deck();//create a deck of cards

            deck.Display();//display the initial dtate of deck
            deck.Shuffle();//shuffle the deck
            deck.Display();//display the deck again

            Card cardDealt = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();


        }//end Main

        

    }//end Program 
}//end namespace
