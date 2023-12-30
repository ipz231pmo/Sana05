using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {
        public string Name { get; set; }
        public decimal ExRate { get; set; }
        public Currency() 
        { 
            Name = string.Empty;
            ExRate = 0;
        }
        public Currency(Currency currency) 
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name) 
        {
            Name = name;
            ExRate=0;
        }
    }
}
