using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class Class1
    {
        IList <Review> newReviews = new List<Review>()
        {

        }

        IList<Student> newStudents = new List<Student>() {
                                    new Student() { StudentName = "Steve" };
        new Student() { StudentName = "Bill" };
        new Student() { StudentName = "James" };
    };

    // using(RestaurantDBEntities context = new RestaurantDBEntities())

}
}
