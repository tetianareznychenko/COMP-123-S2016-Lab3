using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    /**
     * <summary>
     * This class creates an object thet represents a plaing card
     * </summary>
     * @class Card
     */
    public class Card
    {
        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++
        public Faces Face { get; set; }

        public Suits Suit { get; set; }

        //CONSTRUCTORS++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes two parameters: face and suit to instantiable a Card object
         * </summary>
         * @constructor Card
         * @param {Faces} face
         * @param {Suits} suit
         */
        public Card(Faces face, Suits suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
