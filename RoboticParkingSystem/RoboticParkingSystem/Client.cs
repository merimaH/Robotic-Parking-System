using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace RoboticParkingSystem
{
    class Client
    {
        private String firstName;
        private String lasteName;
        private String adress;
        private Image fingerprint;
        private Payment payment;
        private int pinCode;

        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

        public Payment Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public String Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public Image Fingerprint
        {
            get { return fingerprint; }
            set { fingerprint = value; }
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lasteName; }
            set { lasteName = value; }
        }
        public Client(String firstName,String lastName,String adress,Image fingerprint,Payment payment)
        {
            this.firstName = firstName;
            this.lasteName = lastName;
            this.adress = adress;
            this.fingerprint = fingerprint;
            this.payment = payment;
        }




    }
}
