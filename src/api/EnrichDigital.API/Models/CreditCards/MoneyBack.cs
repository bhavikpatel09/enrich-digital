using EnrichDigital.API.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Models
{
    public class MoneyBack : CreditCard
    {
        public MoneyBack()
        {
            AnnualCharge = 150;
            CreditLimit = 100000;
            CardType = Constants.CardType.MoneyBack;
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
