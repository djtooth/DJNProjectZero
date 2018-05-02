using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class DataAccess
    {
        RestaurantDBEntities context = new RestaurantDBEntities();

        //Used for initial population of database
    public void CreateRecords()
    {
            string[] name1 = new string[] {"Adam","Bob","Cindy","Deana", "Emile","Fernando","Gurtrude","Heather"};
            string[] name2 = new string[] { "Zelos", "Yeow", "Xeros", "Wembly", "Vernerable", "Ule", "The Terrible", "Son" };
            string[] rname1 = new string[] { "Inkies ", "Jelly Stuff'd ", "Krusti", "Lazy " };
            string[] rname2 = new string[] { "Munchies", "Nachos", "Os", "Portion", "Quik", "Ramen" };
            string[] location = new string[] { "Texas", "Lousianna", "Tennessee", "Arizona", "California", "Mexico", "Canada", "Florida", "Virginia" };
            
            for (int i = 0; i < rname1.Count(); i++)
            {
                for (int o = 0; o < rname2.Count(); o++)
                {
                    var Nrestaurant = new Restaurant();
                    Nrestaurant.Name = rname1[i] + rname2[o];
                    Nrestaurant.Location = location[(i + o) % location.Count()];
                    context.Restaurants.Add(Nrestaurant);
                }
            }

            for (int i = 0; i < name1.Count(); i++)
            {
                for (int o = 0; o < name2.Count(); o++)
                {
                    var Nreview = new Review();
                    var Nrelation = new Relation();

                    Nreview.Name = name1[i] + " " + name2[o];
                    Nreview.Rating = (i + o) % 10 + 1;
                    Nreview.RestaurantID = (i + o) % (rname1.Count() + rname2.Count()) + 1;
                    Nreview.Text = "To do";

                    //Nrelation.ReviewID = context.Reviews.Last().ID;
                    //Nrelation.RestaurantID = context.Restaurants.Last().ID;

                    context.Reviews.Add(Nreview);
                    //context.Relations.Add(Nrelation);
                }
            }
            context.SaveChanges();
    }

        //returns all review records
        public ArrayList getReviews()
        {
            ArrayList reviewArr = new ArrayList();
            var reviewList = context.Reviews.ToList();
            foreach (var element in reviewList)
            {
                reviewArr.Add(element);
            }
            return reviewArr;
        }

        //Returns all restaurant records
        public ArrayList getRestaurants()
        {
            ArrayList restaurantArr = new ArrayList();
            var restaurantList = context.Restaurants.ToList();
            foreach (var element in restaurantList)
            {
                restaurantArr.Add(element);
            }
            return restaurantArr;
        }
    }
}
