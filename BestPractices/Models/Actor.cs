﻿using System;
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

      
        public Actor(string jobTitle) 
        {
            JobTitle = jobTitle;
        }
        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
           
            //value? to check its not null
            set {
                var formattedTitle = value?.Trim();
                jobTitle = formattedTitle;
            }
        }


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation ()
        {
            return "Actor";
        }


        /// <summary>
        /// Books actor and date not specified
        /// </summary>
        public string BookActor()
        {
          
            return BookActor(string.Empty);

        }

        /// <summary>
        /// Books actor on specific date
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = "Actor will not book if" +
                " they cause trouble";
            string theActor = "Actor " + jobTitle + " is Booked";
           
            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". " + details;
            }
             else
            {
                return theActor + ". " + details;
            }
        }

    }
}
