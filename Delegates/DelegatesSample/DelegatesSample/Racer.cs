using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    public class Racer : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public int CompareTo(object obj) =>
            FirstName.CompareTo((obj as Racer)?.FirstName);
        //             Name.CompareTo(((Racer)obj).Name);

        public override string ToString() => $"{FirstName} {LastName}, country: {Country}";
    }
}
