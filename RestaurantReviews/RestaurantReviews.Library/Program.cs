using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Library
        {
            ArrayList Restaurants = new ArrayList();
            Library(int reviewers, int restaurants)
            {
                for (int i = 0, i < reviewers; i++)
                {

                }

            }

           public  double AverageRating(Restaurant a)
            {

            }

        }

        interface Iobject
        {
            string Name { get; set; }
            int IDnumber { get; set; }
            string Location { get; set; }
            int MyProperty { get; set; }
        }

        public abstract class Object : Iobject
        {
            public string Name { get; set; }
            public int IDnumber { get; set; }
            public string Location { get; set; }
            public int MyProperty { get; set; }
        }
        public class Restaurant : Object
        {


        }
        public class review : Object
        {

            public string Text { get; set; }

            

        }

    }
}
