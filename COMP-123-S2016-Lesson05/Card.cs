using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    public class Card
    {
        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }

        public string Suit { get; set; }

        //CONSTRUCTORS++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes two parameters: face and suit to instantiable a Card object
         * </summary>
         * @constructor Card
         * @param {string} face
         * @param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
