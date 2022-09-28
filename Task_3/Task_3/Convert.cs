using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Converter
    {
        private readonly decimal dollarRate;
        private readonly decimal euroRate;
        public Converter(decimal dollar, decimal euro)
        {
            this.dollarRate = dollar;
            this.euroRate = euro;
        }
        public double convertHryvniaToDollar(double hryvny)
            => hryvny / Convert.ToDouble(dollarRate);
        
        public double convertHryvniaToEuro(double hryvny)
            => hryvny / Convert.ToDouble(euroRate);
        public double convertDollarToHryvnia(double dollar)
            => Convert.ToDouble(dollarRate) * dollar;
        public double convertEuroToHryvnia(double euro)
            => Convert.ToDouble(euroRate) * euro;
    }
}
