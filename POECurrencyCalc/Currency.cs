using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POECurrencyCalc
{
    class Currency
    {
        double divineInChaos { get; set; }
        public Currency(double divinePrice)
        {
            divineInChaos = divinePrice;
        }
        public double DivineToChaosConvert(double amountOfDiv)
        {
           return  divineInChaos * amountOfDiv;
        }
        public double ChaosToDivineConvert( double amountOfChaos)
        {
            return amountOfChaos / divineInChaos;
        }
    }
}
