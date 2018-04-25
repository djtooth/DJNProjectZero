using System;

namespace ObjectsNameSpace
{

    public abstract class Object
    {
        protected const int digits = 5;
        public string Name { get; set; }
        public String IDnumber { get; set; }
    }

    public class Restaurant : Object
    {
        static int tracker = 0;
        public string Location { get; set; }
        public Restaurant() { }
        public Restaurant(string name, string location)
        {
            this.Name = name;
            IDnumber = tracker.ToString();
            while (digits > IDnumber.Length)
                IDnumber = "0" + IDnumber;
            tracker++;
        }

    }

    public class Review : Object
    {
        static int tracker = 0;
        public Review() { }
        public Review(string text, string restaurantID, double rating, string name)
        {
            this.text = text;
            this.restaurantID = restaurantID;
            this.rating = rating;
            this.Name = name;
            IDnumber = tracker.ToString();
            while (digits > IDnumber.Length)
                IDnumber = "0" + IDnumber;
            tracker++;

        }
        public string text { get; set; }
        public string restaurantID { get; set; }
        public double rating { get; set; }
    }
}
