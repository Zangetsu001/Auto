using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Automobile
    {
        string model;
        int year;
        public static int totalcars=0;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Automobile() { }
        public Automobile(string model, int year)
        {
            this.Model = model;
            this.Year = year;
            totalcars++;
        }
       

    }
}
