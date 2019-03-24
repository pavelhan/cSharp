using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Converter
    {
        public List<string> currencyList = new List<string>();        
        public Converter()
        {
            currencyList.Add("USD");
            currencyList.Add("UAH");
            currencyList.Add("EURO");
            currencyList.Add("GBP");
            currencyList.Add("RUB");
        }
    }
}
