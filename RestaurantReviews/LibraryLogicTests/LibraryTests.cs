using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntity;
using System.Collections;

namespace LibraryLogic.Tests
{
    [TestClass()]
    public class LibraryTests
    {
        [TestMethod()]
        public void LibraryTest()
        {
            Library library = new Library();
            Assert.IsNotNull(library);
        }

        [TestMethod()]
        public void AverageRatingTest()
        {
            Library test = new Library();
            int loopsize = 5, average = 0, expected = 0;
            Restaurant restaurant = new Restaurant();
            List<Review> reviews = new List<Review>();
            ArrayList reviewArr = new ArrayList();

            restaurant.ID = 17;
            for(int i = 0; i < loopsize; i++)
            {
                expected += i;
                reviews[i].RestaurantID = restaurant.ID;
                reviews[i].Rating = i;
                reviewArr.Add(reviews[i]);
            }
            expected /= loopsize;

            for (int i = 0; i < loopsize; i++)
            {
                reviews[i].RestaurantID = restaurant.ID+1;
                reviews[i].Rating = i+2;
                reviewArr.Add(reviews[i]);
            }

            average = ((int)test.AverageRating(reviewArr, restaurant));

            Assert.AreEqual(expected, average);
        }

        [TestMethod()]
        public void TopThreeTest()
        {
            //Assert.IsTrue();
        }

        [TestMethod()]
        public void DisplayAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisplayReviewsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchRestaurantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QuitAppTest()
        {
            Library library = new Library();
            library.QuitApp();
            Assert.IsNotNull(library);
        }
    }
}