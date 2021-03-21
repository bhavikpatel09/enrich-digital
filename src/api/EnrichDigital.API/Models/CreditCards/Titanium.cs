using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Models
{
    public class Titanium : CreditCard
    {
        public Titanium()
        {
            AnnualCharge = 750;
            CreditLimit = 500000;
            CardType = Constants.CardType.Titanium;

        }
        public override int GetAnnualCharge()
        {
            return AnnualCharge;
        }

        public override string GetCardType()
        {
            return CardType;
        }

        public override int GetCreditLimit()
        {
            return CreditLimit;
        }
    }
}
