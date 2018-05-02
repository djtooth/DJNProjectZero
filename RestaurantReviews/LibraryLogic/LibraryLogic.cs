using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntity;


namespace LibraryLogic
{
    public class Library
    {
        //Obsolete Code
        //List<Review> reviews = new List<Review>();
        //List<Restaurant> restaurants = new List<Restaurant>();

        //Library(int reviewers, int inputrestaurants)
        //{
        //    for (int i = 0; i < reviewers; i++)
        //    {
        //        reviews.Add(new Review());
        //    }

        //    for (int i = 0; i < inputrestaurants; i++)
        //    {
        //        restaurants.Add(new Restaurant());
        //    }

            public Library()
        {

        }
             

        public double AverageRating(ArrayList reviews, Restaurant b)
        {
            int qauntity = 0;
            int sum = 0;
            double average;
            foreach (Review element in reviews)
            {
                if (b.ID == element.RestaurantID)
                {
                    sum += (int)element.Rating;
                    qauntity++;
                }
            }
            if (qauntity == 0)
                return 0;
            average = sum / qauntity;
            return average;
        }

        public void TopThree(ArrayList a, ArrayList b)
        { // top what restrants
            int topX = 3;
            double tempaverage;
            List<double> top = new List<double>();
            List<string> topname = new List<string>();
            foreach (Restaurant element in b)
            {
                //finds the average rating of the restaurant
                tempaverage = AverageRating(a, element);
                //checks if there are already 3 ratings
                if (top.Count == topX)
                {
                    if (tempaverage < top[0])
                        continue;
                    //checks if the current restaurant is higher rated than the top three
                    for (int i = topX; i > 0; i--)
                    {
                        if (tempaverage > top[i - 1])
                        {
                            top[i - 1] = tempaverage;
                            topname[i - 1] = element.Name;
                            break;
                        }
                    }
                }
                else
                {
                    top.Add(tempaverage);
                    topname.Add(element.Name);
                }
            }
            for (int i = 0; i < topX; i++)
            {
                Console.WriteLine($"#{i+1} {topname[i]}: {top[i]}");
            }
        }

        public void DisplayAll(ArrayList restaurant, int sort)
        {
            if (sort == 1)
                restaurant = Namesort(restaurant);


            Console.WriteLine("-------------------------------");
            Console.WriteLine("ID | Name | Location ");
            Console.WriteLine("-------------------------------");

            foreach (Restaurant element in restaurant)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", element.ID, element.Name, element.Location));
            }
            Console.WriteLine("-------------------------------");
        }

        //Displays all reviews of a restaurant
        public void DisplayReviews(ArrayList reviews, Restaurant restaurant)
        {
            Console.WriteLine("ID | Name | Restaurant Name | Rating | Text ");
            foreach (Review element in reviews)
            {
                if (element.RestaurantID == restaurant.ID)
                {
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-5}",
                        element.ID, element.Name, element.RestaurantID, element.Rating, element.Text));
                }
            }
        }

        internal ArrayList Namesort(ArrayList restaurant)
        {
            ArrayList temp = new ArrayList();
            int lowest;
            while(restaurant.Count > 0)
            {
                lowest = -1;
                for(int i = 0; i <restaurant.Count; i++)
                {
                    if (lowest == -1)
                        lowest = 0;
                    if (0 > (((Restaurant)restaurant[i]).Name.CompareTo(((Restaurant)restaurant[lowest]).Name)))
                        lowest = i;
                }
                temp.Add(restaurant[lowest]);
                restaurant.RemoveAt(lowest);
            }
            return temp;
        }



        //Search Restaurants (By partial name), display all matching results
        public void SearchRestaurants(ArrayList restaurant,string target)
        {
            string compare;
            int found = 0;
            foreach(Restaurant element in restaurant)
            {
                compare = element.Name.ToUpper();
                if (compare.Contains(target.ToUpper()))
                {
                    found++;
                    if (found == 1)
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("ID | Name | Location ");
                        Console.WriteLine("-------------------------------");
                    }
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", element.ID, element.Name, element.Location));
                }
            }
            if (found == 0)
                Console.WriteLine($"{target} could not be found in the restaurants.");
        }

        //Quits application
        public void QuitApp()
        {
            Console.ReadKey();
            System.Environment.Exit(0);
        }


    }
}
