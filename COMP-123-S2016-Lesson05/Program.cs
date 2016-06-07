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
            //create a new istance of the Student class

            Student tommy = new Student("Tommy", 20, "S123456789");

            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();
            tommy.Courses.Add(new Course("COMP-123", "Programming 2"));
            tommy.Courses.Add(new Course("COMP-125", "Client-Side Web Development"));
            tommy.Courses.Add(new Course("COMP-397", "Web Game Programming"));

            tommy.ShowCourses();
            Console.WriteLine();

            //create a new istance of the Teacher class

            Teacher tom = new Teacher("Tom", 47, "T123456789");
            Console.WriteLine();
            Console.WriteLine();

            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();

            //Console.WriteLine(person.Name);

            //Set a value in the Name property of the Person class
            //person.Name = "Tetiana";

            //get the Name value and print to console
            //Console.WriteLine(person.Name);

            Console.WriteLine();

            List<string> names = new List<string>();

            names.Add("Tom");
            names.Add("Mary");
            names.Add("Rutvic");

            int count = 0;

            foreach (string name in names)
            {
                Console.WriteLine("Name №" + count + " is " + name);
                count++;
            }


            List<Card> Deck = new List<Card>();
            CreateDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck)
        {
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
                    deck.Add(new Card(face, suit));
                }
            }

        }
    }
}
