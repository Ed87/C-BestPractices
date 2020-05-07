using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices.Models
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born");      
        }

        /// <summary>
        /// (this) keyword invokes default constructor 
        /// </summary>
        /// <returns></returns>
        public Actor(string jobTitle) : this ()
        {
            JobTitle = jobTitle;
        }
        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation ()
        {
            return "Actor";
        }
    }
}
