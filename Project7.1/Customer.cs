using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    class Customer
    {
        static int _age, _Lower, _Club, _Upper;
        //public static double _TotalCost;

        public Customer()
        {
            _age = age;
            _Lower = Lower;
            _Club = Club;
            _Upper = Upper;
        }
        public static string name
        {
            get; set;
        }

        public static string email
        {
            get; set;
        }

        public static int age
        {
            get; set;
        }

        public static string password
        {
            get; set;
        }


        public static int Lower
        {
            get;
            set;
        }
        public static int Club
        {
            get; set;
        }
        public static int Upper
        {
            get; set;
        }
        public static double TotalCost
        {
            get; set;
        }
    }
}
