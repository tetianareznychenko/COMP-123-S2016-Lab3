using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_S2016_Lesson05
{
    /**
     * <summary>
     * This is the course class - we are using it as a custom data type for our Teacher and Student classes
     * </summary>
     * 
     * @class Course
     */
    class Course
    {
        //private instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private string _code;
        private string _description;

        //public properties +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string Code
        {
            get //reading only property
            {
                return _code;
            }
            set //write property
            {
                this._code = value;
            }
        }
        public string Description
        {
            get //reading only property
            {
                return _description;
            }
            set //write property
            {
                this._description = value;
            }
        }
        //constructors+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This constructor takes two parameters: Description and Code 
        * </summary>
        * 
        * @param {string} code
        * @param {string} description
        */
        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
