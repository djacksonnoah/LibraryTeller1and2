using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Media
    {
        public virtual string Title { get;  set; }
        public virtual string Length { get;  set; }
<<<<<<< HEAD
        public abstract int RentalLength { get; set; }
=======
        public abstract int RentalLength { get; set;  }
>>>>>>> ebee15bffd93da4fa04c4bc72cbb842ad79258d2
        protected DateTime RentedDate { get;  set; }
    
        
        public Media()
        {
            RentedDate = DateTime.Today;
        }
        
        public abstract void PrintMediaDetails();

        public abstract DateTime ReturnDueDate();

        public virtual void  SetRentedDate()
        {
            RentedDate = DateTime.Today;
        }
    }
}
