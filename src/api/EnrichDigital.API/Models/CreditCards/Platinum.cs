using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Models
{
    public class Platinum : CreditCard
    {
        public Platinum()
        {
            AnnualCharge = 450;
            CreditLimit = 250000;
            CardType = Constants.CardType.Platinum;

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
