using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class CopyConstructor
    {
        private string month;
        private int year;

        //Copy constructor declaration
        CopyConstructor(CopyConstructor copyConstructor)
        {
            month = copyConstructor.month;
            year = copyConstructor.year;
        }

        //Instace constructor
        CopyConstructor(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        //Property
        public string Details
        {
            get
            {
                return "Month: " + month + "\nYear: " + year.ToString();
            }
        }

        public static void Main()
        {
            //Creating a new object of class
            CopyConstructor copyConstructor1 = new CopyConstructor("Aug", 2000);

            //Copying copyConstructor1 details copying to copyConstructor2
            CopyConstructor copyConstructor2 = new CopyConstructor(copyConstructor1);
            Console.WriteLine(copyConstructor2.Details);
        }

    }
}
