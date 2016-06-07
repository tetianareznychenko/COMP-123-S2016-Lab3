using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    /**
     * <summary>
     * This is Teacher class derived from Person class
     * </summary>
     * 
     * @class Teacher
     * @extends Person
     */

    class Teacher : Person
    {
        //private instance variables +++++++++++++++++++++++++++++++++++++++++++++
        private string _employeeID;

        //public properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }

        //constructors++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor methods takes three parameters: name, age, employeeID
         * </summary>
         * 
         * @constructor Teacher
         * @param {string} name
         * @param {int} age 
         * @param {string} employeeID 

         */
        public Teacher(string name, int age, string employeeID)
            : base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        //public methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void Teaches()
        {
            /**
             * <summary>
             * This method enables the Teaches behaviour for the teacher
             * 
             * @method Teaches
             * @return {void}
             */
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
