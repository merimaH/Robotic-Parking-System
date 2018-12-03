using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticParkingSystem
{
    class Payment
    {
        private DateTime dateOfPayment;
        private int numberPaidMonths;

        public DateTime DateOfPayment
        {
            get { return dateOfPayment; }
            set { dateOfPayment = value; }
        }
      
        public int NumberPaidMonths
        {
            get { return numberPaidMonths; }
            set { numberPaidMonths = value; }
        }
        
    }
}
