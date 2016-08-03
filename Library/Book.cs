using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
<<<<<<< HEAD
    class Book
=======
    class Book : Media
>>>>>>> ebee15bffd93da4fa04c4bc72cbb842ad79258d2
    {
        public override int RentalLength
        {
            get
            {
<<<<<<< HEAD
                return 7;
            }
            // dummy set method, doesn't do anything
            set
            {
            }
        }
        public override void PrintMediaDetails()
        {
            Console.WriteLine("DVD {0} ({1})", Title, Length);
            Console.WriteLine("Rented on: {0)", RentedDate);
            Console.WriteLine("Due on  {0}", ReturnDueDate());
=======
                return 14;
            }
            // dummy set method - doesn't do anything
            set
            {
            }

        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("Book {0} ({1})", Title, Length);
            Console.WriteLine("Rented on: {0}", RentedDate);
            Console.WriteLine("Due on: {0}", ReturnDueDate());
>>>>>>> ebee15bffd93da4fa04c4bc72cbb842ad79258d2

        }

        public override DateTime ReturnDueDate()
        {
            return RentedDate.AddDays(RentalLength);
        }
    }
<<<<<<< HEAD

=======
>>>>>>> ebee15bffd93da4fa04c4bc72cbb842ad79258d2
}
