using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    public class CountryView
    {
        //property
        public Country DisplayCountry { get; set; }




        //constructor
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} | {DisplayCountry.Continent} | {DisplayCountry.Colors}");
        }
    }
}
//DONE