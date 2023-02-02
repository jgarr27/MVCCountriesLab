using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    public class Country
    {
        private string v1;
        private string v2;
        private List<string> list;

        public Country(string v1, string v2, List<string> list)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.list = list;
        }

        public object Name { get; internal set; }
        public object Continent { get; internal set; }
        public object Colors { get; internal set; }
    }
}
