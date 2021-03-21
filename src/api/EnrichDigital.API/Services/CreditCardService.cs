using EnrichDigital.API.Constants;
using EnrichDigital.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Services
{
    public class CreditCardService : ICreditCardService
    {
        public CreditCard GetCreditCardDetails(string cardType)
        {
            CreditCard creditCard = null;

            switch (cardType)
            {
                case CardType.MoneyBack:
                    creditCard = new MoneyBack();
                    break;
                case CardType.Platinum:
                    creditCard = new Platinum();
                    break;
                case CardType.Titanium:
                    creditCard = new Titanium();
                    break;
            }
            return creditCard;

        }
    }
}
