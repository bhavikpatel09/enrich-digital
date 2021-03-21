using EnrichDigital.API.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Models
{
    public abstract class CreditCard
    {
        public string CardType { get; set; }
        public int AnnualCharge { get; set; }
        public int CreditLimit { get; set; }
        public abstract int GetAnnualCharge();
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
    }
}
