﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD : Media
    {
        public override int RentalLength
        {
            get
            {
                return 7;
            }
<<<<<<< HEAD
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
            // dummy set method - doesn't do anything
            set
            {
            }

        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("DVD {0} ({1})", Title, Length);
            Console.WriteLine("Rented on: {0}", RentedDate);
            Console.WriteLine("Due on: {0}", ReturnDueDate());
>>>>>>> ebee15bffd93da4fa04c4bc72cbb842ad79258d2

        }

        public override DateTime ReturnDueDate()
        {
            return RentedDate.AddDays(RentalLength);
        }
    }
}
