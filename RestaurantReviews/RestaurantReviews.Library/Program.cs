using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestaurantReviews.Library
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Library
        {
            List<Review> reviews = new List<Review>();
            List<Restaurant> restaurants = new List<Restaurant>();
            
            Library(int reviewers, int inputrestaurants)
            {
                for (int i = 0; i < reviewers; i++)
                {
                    reviews.Add(new Review());
                }

                for (int i = 0; i < inputrestaurants; i++)
                {
                    restaurants.Add(new Restaurant());
                }

            }

           public double AverageRating(List<Review> a, Restaurant b)
            {
                int qauntity = 0;
                double average = 0;
                foreach (Review element  in a)
                {
                    if(b.Name == element.restaurant)
                    {
                        average += element.rating;
                        qauntity++;
                    }
                }
                return average/qauntity;
            }

            public void TopThree(List<Review> a, List<Restaurant> b)
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
                    if (top.Count() == topX)
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
                    Console.WriteLine($"#{i} {topname[i]}: {top[i]}");
                }

            }

            public void DisplayAll(Restaurant[] restaurant)
            {

                foreach (Restaurant element in restaurant)
                    Console.WriteLine($"");
            }

            public void DisplayReviews(Restaurant[] restaurant)
            {

            }
            public void SearchRestaurants(Restaurant restaurant)
            {

            }
            public void QuitApp()
            {

            }


        }

        public abstract class Object
        {
            public string Name { get; set; }
            public String IDnumber { get; set; }
        }

        public class Restaurant : Object
        {
            int digits = 5;
            static int tracker = 0;
            public string Location { get; set; }

        }

        public class Review : Object
        {
            int digits = 5;
            static int tracker = 0;
            public Review()
            {
                IDnumber = tracker.ToString();
                while (digits > IDnumber.Length)
                    IDnumber = "0" + IDnumber;
                tracker++;
            }
            public Review(string text, string restaurant, double rating, string name)
            {
                this.text = text;
                this.restaurant = restaurant;
                this.rating = rating;
                this.Name = name;
                IDnumber = tracker.ToString();
                while (digits > IDnumber.Length)
                    IDnumber = "0" + IDnumber;
                tracker++;

            }
            public string text { get; set; }
            public string restaurant { get; set; }
            public double rating { get; set; }
        }

    }
    struct nameList
    {
        //string Beginning[] {"Yum", "Yummy ",  }
    }

  /* public class Serializer<T>
    {
        T myObject = new T();
        // Insert code to set properties and fields of the object.  
        XmlSerializer mySerializer = new XmlSerializer(typeof(T));
        // To write to a file, create a StreamWriter object.  
        StreamWriter myWriter = new StreamWriter("myFileName.xml");
        mySerializer.Serialize(myWriter, myObject);  
        myWriter.Close();  
    }*/

}
