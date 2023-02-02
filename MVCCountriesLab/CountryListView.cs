using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public CountryController(string _name, string _continent, List<string> _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors;
        }

        public List<Country> CountryDb = new List<Country>()
        {
            new Country("Canada", "North America", new List<string>(){"red", "white" }),
            new Country("Finland", "Europe", new List<string>(){"blue", "white" }),
            new Country("Japan", "Asia", new List<string>(){"red", "white"}),
            new Country("Australia", "Australia", new List<string>(){"red", "white", "blue"}),
            new Country("Kazakhstan", "Asia", new List<string>(){"blue", "yellow" })
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            foreach(Country c in CountryDb)
            {
                CountryAction(c);
            }
        }
    }
}
