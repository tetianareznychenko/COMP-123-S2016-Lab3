using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05

/**<summary>
 * This is the Student class. It is derived from Person class 
 * </summary>
 * 
 * @class Student 
 * @extends Person
 */
{         //child class      //superclass for the Student (parent)
    class Student : Person
    {

        //private instance variables ++++++++++++++++++++++++++++++++++++++++++

        private string _studentID;
        private List<Course> _courses = new List<Course>();

        //public properties +++++++++++++++++++++++++++++++++++++++++++++++++++

        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
            set
            {
                this._courses = value;
            }
        }
        //constructors ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes for the Student class three parameters: name, age, studentID
         * </summary>
         * 
         * @constructor Student
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         */
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;

        }

        //public methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method enables the Studies behaviour for the student
         * </summary>
         * 
         * @method Studies
         * @return void
         */


        public void Studies()
        {
            Console.WriteLine(this.Name + " studies.");
        }

        /**
        * <summary>
        * This method lists all the courses the student is currently enrollled in.
        * </summary>
        * 
        * @method ShowCourses
        * @returns {void}
        */
        public void ShowCourses()
        {
            Console.WriteLine();
            Console.WriteLine("Course List");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            foreach (Course course in this._courses)
            {
                Console.WriteLine("+ " + course.Code + " " + course.Description);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
