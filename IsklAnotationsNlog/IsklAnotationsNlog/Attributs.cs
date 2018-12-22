using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklAnotationsNlog
{
    public class ProviderAttribute : System.Attribute
    {
        string title;
        string city;
        string country;

        public ProviderAttribute(string title, string city, string country)
        {
            this.title = title;
            this.country = country;
            this.city = city;
        }
        public virtual string Title
        {
            get { return title; }
        }

        public virtual string Country
        {
            get { return Country; }
        }

        public virtual string City
        {
            get { return City; }
        }
    }
}