using System;

namespace Assinment1_Unit16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the detials of the Nokia");
            Nokia myNokia = new Nokia();
            GetProperties(myNokia);
            PrintPhoneDetails(myNokia);
            PrintSpacer();

            Console.WriteLine("Please enter the detials of the Samsung");
            Samsung mySamsung = new Samsung();
            GetProperties(mySamsung);
            PrintPhoneDetails(mySamsung);
            PrintSpacer();

            Console.WriteLine("Please enter the detials of the Iphone");
            Iphone myIphone = new Iphone();
            GetProperties(myIphone);
            PrintPhoneDetails(myIphone);


            Console.ReadLine();

        }

        static void PrintSpacer()
        {
            Console.WriteLine();
        }

        static void Bluetooth(Phone myPhone)
        {
            Console.WriteLine(myPhone.Bluetooth());
        }

        static void WIFI(Phone myPhone)
        {
            Console.WriteLine(myPhone.WIFI());
        }

        static void PrintPhoneDetails(Phone myPhone)
        // displays the properties of the car
        {
            Console.WriteLine("The make of the phone is {0}", myPhone.Make);
            Console.WriteLine("The model of the phone is {0}", myPhone.Model);
            Console.WriteLine("The IEMI number of the phone is {0}", myPhone.IEMINumber);
            Console.WriteLine("The phone number of the phone is {0}", myPhone.PhoneNumber);
        }

        static void GetProperties(Phone myPhone)
        {
            Console.WriteLine("Enter make of phone");
            myPhone.Make = Console.ReadLine();
            Console.WriteLine("Enter Model of phone");
            myPhone.Model = Console.ReadLine();
            while (myPhone.IEMINumber == 0)
            {
                try
                {
                    Console.WriteLine("Enter IEMI number of phone");
                    myPhone.IEMINumber = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input! Please enter valid number.");
                    myPhone.IEMINumber = 0;
                }
            }
            Console.WriteLine("Enter mobile phone number");
            myPhone.PhoneNumber = Console.ReadLine();


        }
    }

    class Phone
    {
        // Define some generic properties for this class
        private string make;
        private string model;
        private double iemiNumber;
        private string phoneNumber;
        //  This is the CONSTRUCTOR to allow you to create an instance of this class
        public Phone() { }

        // Define the accessor functions for this class
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double IEMINumber
        {
            get { return this.iemiNumber; }
            set { this.iemiNumber = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        // This virtual method defines a calculation for the sare of the generic shape
        public virtual string ModelofPhone()
        {
            return "The model of the phone is yet to be defined";
        }

        public virtual string MakeofPhone()
        {
            return "The make of the phone is yet to be defined";
        }

        public virtual string IEMINumberofPhone()
        {
            return "The IEMI number of the phone is yet to be defined";
        }

        public virtual string MobilePhoneNumber()
        {
            return "The phone number of the phone is yet to be defined";
        }

        public string Bluetooth()
        {
            return "Your bluetooth is on";
        }
        public string WIFI()
        {
            return "Your WI-Fi is on";
        }
        public string Message()
        {
            return "You have recieved a message";
        }
    }

    class Nokia : Phone
    {
        // Define the CONSTRUCTOR
        public Nokia() { }

        // Override the inherited methods
        public override string ModelofPhone()
        {
            return string.Format("The model of the Nokia is {0}", Model);
        }

        public override string MakeofPhone()
        {
            return string.Format("The make of the Nokia is {0}", Make);
        }

        public override string IEMINumberofPhone()
        {
            return string.Format("The IEMI number of the Nokia is {0}", IEMINumber);
        }

        public override string MobilePhoneNumber()
        {
            return string.Format("The phone number of the Nokia is {0}", PhoneNumber);
        }
    }

    class Samsung : Phone
    {
        // Define the CONSTRUCTOR
        public Samsung() { }

        // Override the inherited methods
        public override string ModelofPhone()
        {
            return string.Format("The model of the Samsung is {0}", Model);
        }

        public override string MakeofPhone()
        {
            return string.Format("The make of the Samsung is {0}", Make);
        }

        public override string IEMINumberofPhone()
        {
            return string.Format("The IEMI number of the Samsung is {0}", IEMINumber);
        }

        public override string MobilePhoneNumber()
        {
            return string.Format("The phone number of the Samsung is {0}", PhoneNumber);
        }
    }

    class Iphone : Phone
    {
        // Define the CONSTRUCTOR
        public Iphone() { }

        // Override the inherited  methods
        public override string ModelofPhone()
        {
            return string.Format("The model of the Iphone is {0}", Model);
        }

        public override string MakeofPhone()
        {
            return string.Format("The make of the Iphone is {0}", Make);
        }

        public override string IEMINumberofPhone()
        {
            return string.Format("The IEMI number of the Iphone is {0}", IEMINumber);
        }

        public override string MobilePhoneNumber()
        {
            return string.Format("The phone number of the Iphone is {0}", PhoneNumber);
        }
    }
}
