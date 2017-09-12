using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    public enum RacerCompareType
    {
        FirstName,
        LastName,
        Country
    }

    public class RacerComparer : IComparer<Racer>
    {
        private RacerCompareType _compareType;
        public RacerComparer(RacerCompareType compareType) =>
            _compareType = compareType;

        public int Compare(Racer x, Racer y)
        {
            int result = 0;
            switch (_compareType)
            {
                case RacerCompareType.FirstName:
                    result = x.FirstName.CompareTo(y.FirstName);
                    break;
                case RacerCompareType.LastName:
                    result = x.LastName.CompareTo(y.LastName);
                    break;
                case RacerCompareType.Country:
                    result = x.Country.CompareTo(y.Country);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
