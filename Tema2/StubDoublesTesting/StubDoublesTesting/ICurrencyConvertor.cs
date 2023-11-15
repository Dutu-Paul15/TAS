using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubDoublesTesting
{
    public interface ICurrencyConvertor
    {
        float EurToRon(float ValueInEur, float rateEurRon)
        {
            return ValueInEur * rateEurRon;
        }
        float RonToEur(float ValueInRon, float rateEurRon)
        {
            return ValueInRon / rateEurRon;
        }
    }
}
